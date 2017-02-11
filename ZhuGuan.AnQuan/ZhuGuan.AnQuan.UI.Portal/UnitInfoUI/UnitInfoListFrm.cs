using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ZhuGuan.AnQuan.IBLL;

namespace ZhuGuan.AnQuan.UI.Portal.UnitInfoUI
{
    public partial class UnitInfoListFrm : BaseFrm
    {
        private IUnitInfoService UnitInfoService;
        private ITeamInfoService TeamInfoService;

        public UnitInfoListFrm()
        {
            InitializeComponent();
        }

        private void UnitInfoListFrm_Load(object sender, EventArgs e)
        {
            dgvList.AutoGenerateColumns = false;

            UnitInfoService = ServiceSession.UnitInfoService;
            TeamInfoService = ServiceSession.TeamInfoService;

            InitDgvList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            InitDgvList();
        }

        private void InitDgvList()
        {
            var UnitInfoList = UnitInfoService
                .AsNoTrackingGetEntities(u => u.Id > 0 && u.DelFlag == DelFlagNormal)
                .ToList();
            dgvList.DataSource = UnitInfoList;
            chkSelectAll.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //添加方法
            UnitInfoAddFrm addFrm = new UnitInfoAddFrm();
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
            UnitInfoModifyFrm modifyFrm = new UnitInfoModifyFrm(ids);
            modifyFrm.InitDgvList += InitDgvList;
            modifyFrm.ShowDialog();
            chkSelectAll.Checked = false;
        }

        private List<int> GetSelectedIds()
        {
            List<int> ids = new List<int>();
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


            if (UnitInfoService.DeleteEntities(ids))
            {
                chkSelectAll.Checked = false;
                btnSearch_Click(sender, e);
                var TIds = TeamInfoService.GetEntities(t => ids.Contains(t.UnitInfoId)).Select(t => t.Id).ToList();
                TeamInfoService.DeleteEntities(TIds);   //删除相应的班组信息
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
