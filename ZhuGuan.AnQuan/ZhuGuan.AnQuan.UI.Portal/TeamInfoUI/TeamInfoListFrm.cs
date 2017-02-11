using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ZhuGuan.AnQuan.IBLL;

namespace ZhuGuan.AnQuan.UI.Portal.TeamInfoUI
{
    public partial class TeamInfoListFrm : BaseFrm
    {
        private ITeamInfoService TeamInfoService;
        private IUnitInfoService UnitInfoService;

        public TeamInfoListFrm()
        {
            InitializeComponent(); 
        }

        private void TeamInfoListFrm_Load(object sender, EventArgs e)
        {
            dgvList.AutoGenerateColumns = false;

            TeamInfoService = ServiceSession.TeamInfoService;
            UnitInfoService = ServiceSession.UnitInfoService;
            //添加责任单位
            var unitEntities = UnitInfoService.AsNoTrackingGetEntities(u => u.IsInspUnit == 1 && u.DelFlag == DelFlagNormal)
                .Select(u => new { u.Id, u.UnitName }).ToList();
            cbxUnit.DisplayMember = "UnitName";
            cbxUnit.ValueMember = "Id";
            cbxUnit.DataSource = unitEntities;
            cbxUnit.SelectedIndex = -1;

            InitDgvList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            InitDgvList();
        }

        private void InitDgvList()
        {
            string unitName = cbxUnit.Text.Trim();


            var TeamInfoList = TeamInfoService
                .AsNoTrackingGetEntities(t => t.Id > 0 && t.DelFlag == DelFlagNormal && t.UnitInfo.UnitName.Contains(unitName))
                .Select(t => new {t.Id, t.TeamName, t.DelFlag, t.Remark, t.UnitInfo.UnitName})
                .ToList();
            dgvList.DataSource = TeamInfoList;
            chkSelectAll.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //添加方法
            TeamInfoAddFrm addFrm=new TeamInfoAddFrm();
            addFrm.InitDgvList += InitDgvList;
            addFrm.ShowDialog();
            chkSelectAll.Checked = false;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //修改
            var ids = GetSelectedIds();

            if (ids.Count == 0)
            {
                MessageBox.Show("请至少选中一条要修改的信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            TeamInfoModifyFrm modifyFrm = new TeamInfoModifyFrm(ids);
            modifyFrm.InitDgvList += InitDgvList;
            modifyFrm.ShowDialog();
            chkSelectAll.Checked = false;
        }

        private List<int> GetSelectedIds()
        {
            List<int> ids=new List<int>();
            if (dgvList.RowCount == 0)
            {
                return ids;
            }
            dgvList.EndEdit();
            foreach (DataGridViewRow row in dgvList.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == "1")
                {
                    ids.Add(Convert.ToInt32(row.Cells["Id"].Value));
                }
            }
            return ids;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //删除
            var ids = GetSelectedIds();

            if (ids.Count == 0)
            {
                MessageBox.Show("请至少选中一条要删除的信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dr = MessageBox.Show("确定要删除当前选中的信息吗？", "删除确认", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel)
            {
                return;
            }


            if (TeamInfoService.DeleteEntities(ids))
            {
                chkSelectAll.Checked = false;
                btnSearch_Click(sender, e);
            }
            chkSelectAll.Checked = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //退出
            this.Close();
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            int selectFlag = 0;

            if (chkSelectAll.Checked)
            {
                selectFlag = 1;
            }
            else
            {
                selectFlag = 0;
            }
            foreach (DataGridViewRow row in dgvList.Rows)
            {
                row.Cells[0].Value = selectFlag;
            }
        }
    }
}
