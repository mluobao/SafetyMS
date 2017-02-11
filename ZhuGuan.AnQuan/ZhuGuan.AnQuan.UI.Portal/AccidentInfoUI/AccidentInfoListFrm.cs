using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ZhuGuan.AnQuan.Common;
using ZhuGuan.AnQuan.IBLL;

namespace ZhuGuan.AnQuan.UI.Portal.AccidentInfoUI
{
    public partial class AccidentInfoListFrm : BaseFrm
    {
        private IAccidentInfoService AccidentInfoService;
        private IUnitInfoService UnitInfoService;

        public AccidentInfoListFrm()
        {
            InitializeComponent(); 
        }

        private void AccidentInfoListFrm_Load(object sender, EventArgs e)
        {
            var roleNames = AppCommon.CurrentLoginUser.RoleInfo.Select(r => r.RoleName).ToList();
            if (!(roleNames.Contains("管理员") || roleNames.Contains("事业部领导") || roleNames.Contains("安全主管") ||
                roleNames.Contains("安全办")))
            {
                tsbtnAdd.Enabled = false;
                tsbtnModify.Enabled = false;
                tsbtnDelete.Enabled = false;
            }


            WindowState=FormWindowState.Maximized;
            dgvList.AutoGenerateColumns = false;
            dtpStartDate.Value= new DateTime(DateTime.Now.Year,DateTime.Now.Month,1);
            dtpEndDate.Value = DateTime.Now.Date;

            AccidentInfoService = ServiceSession.AccidentInfoService;
            UnitInfoService = ServiceSession.UnitInfoService;
            //添加责任单位
            var unitEntities = UnitInfoService.AsNoTrackingGetEntities(u => u.IsZrdw == 1 && u.DelFlag == DelFlagNormal)
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
            string unit = cbxUnit.Text.Trim();
            string acciType = cbxAcciType.Text.Trim();
            string class2 = cbxClass.Text.Trim();


            var accidentInfoList = AccidentInfoService
                .AsNoTrackingGetEntities(
                    a =>
                        a.AId > 0 && a.HappenDate >= dtpStartDate.Value && a.HappenDate <= dtpEndDate.Value &&
                        a.DelFlag == DelFlagNormal
                        && a.Unit.Contains(unit) && a.AcciType.Contains(acciType) && a.Class2.Contains(class2))
                .ToList();
            dgvList.DataSource = accidentInfoList;
            chkSelectAll.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //添加方法
            AccidentInfoAddFrm addFrm=new AccidentInfoAddFrm();
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
            
            AccidentInfoModifyFrm modifyFrm = new AccidentInfoModifyFrm(ids);
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
                    ids.Add(Convert.ToInt32(row.Cells["AId"].Value));
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


            if (AccidentInfoService.DeleteEntities(ids))
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "导出数据到Excel";
            sfd.DefaultExt = "xls";
            sfd.Filter = "Excel文档(*.xls)|*.xls|所有文件(All.*)|*.*";
            sfd.FileName = "事故信息表";
            string fileTitle = "事故信息表";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                InfoesReports.ExportToExcel(sfd.FileName, fileTitle, dgvList);
            }
        }
    }
}
