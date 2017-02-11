using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ZhuGuan.AnQuan.Common;
using ZhuGuan.AnQuan.IBLL;

namespace ZhuGuan.AnQuan.UI.Portal.HiddenDangerInfoUI
{
    public partial class HiddenDangerInfoListFrm : BaseFrm
    {
        private IHiddenDangerInfoService HiddenDangerInfoService;
        private IUnitInfoService UnitInfoService;
        private ITeamInfoService TeamInfoService;
        private List<string> roleNames;

        public HiddenDangerInfoListFrm()
        {
            InitializeComponent();
        }

        private void HiddenDangerInfoListFrm_Load(object sender, EventArgs e)
        {
            WindowState=FormWindowState.Maximized;
            dgvList.AutoGenerateColumns = false;
            dtpStartDate.Value= new DateTime(DateTime.Now.Year,DateTime.Now.Month,1);
            dtpEndDate.Value = DateTime.Now.Date;
            roleNames = AppCommon.CurrentLoginUser.RoleInfo.Select(r => r.RoleName).ToList();

            HiddenDangerInfoService = ServiceSession.HiddenDangerInfoService;
            UnitInfoService = ServiceSession.UnitInfoService;

            //添加检查单位
            var inspUnitEntities =
                UnitInfoService.AsNoTrackingGetEntities(u => u.IsInspUnit == 1 && u.DelFlag == DelFlagNormal)
                    .Select(u => new { u.Id, u.UnitName }).ToList();
            cbxInspUnit.DisplayMember = "UnitName";
            cbxInspUnit.ValueMember = "Id";
            cbxInspUnit.ItemHeight = 15;
            cbxInspUnit.DataSource = inspUnitEntities;
            cbxInspUnit.SelectedIndex = -1;

            //添加责任单位
            var zrdwEntities = UnitInfoService.AsNoTrackingGetEntities(u => u.IsZrdw == 1 && u.DelFlag == DelFlagNormal)
                .Select(u => new { u.Id, u.UnitName }).ToList();
            cbxZrdw.DisplayMember = "UnitName";
            cbxZrdw.ValueMember = "Id";
            cbxZrdw.DataSource = zrdwEntities;
            cbxZrdw.SelectedIndex = -1;

            InitDgvList();
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            InitDgvList();
        }

        private void InitDgvList()
        {
            string inspUnit = cbxInspUnit.Text.Trim();
            string zrdw = cbxZrdw.Text.Trim();
            string zrbz = cbxZrbz.Text.Trim();
            string class2 = cbxClass.Text.Trim();
            string level2 = cbxLevel.Text.Trim();
            string achievedDesp = cbxIsAchieved.Text.Trim();

            var hiddenDangerInfoList = HiddenDangerInfoService
                .AsNoTrackingGetEntities(
                    h =>
                        h.HDId > 0 && h.InspDate >= dtpStartDate.Value && h.InspDate <= dtpEndDate.Value &&
                        h.DelFlag == DelFlagNormal
                        && h.InspUnit.Contains(inspUnit) && h.Zrdw.Contains(zrdw) && h.Zrbz.Contains(zrbz) &&
                        h.Class2.Contains(class2)
                        && h.Level2.Contains(level2) && h.AchievedDesp.Contains(achievedDesp))
                .ToList();
            dgvList.DataSource = hiddenDangerInfoList;
            chkSelectAll.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //添加方法
            HiddenDangerInfoAddFrm addFrm=new HiddenDangerInfoAddFrm();
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

            if (!(roleNames.Contains("管理员") || roleNames.Contains("事业部领导") || roleNames.Contains("安全主管") ||
                  roleNames.Contains("安全办")))
            {
                //判断是否包含别单位的信息
                if (IsContainsInspUnit(ids, AppCommon.CurrentLoginUser.UnitName))
                {
                    MessageBox.Show("不能修改【非本单位】录入的信息，请重新选择！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            HiddenDangerInfoModifyFrm modifyFrm = new HiddenDangerInfoModifyFrm(ids);
            modifyFrm.InitDgvList += InitDgvList;
            modifyFrm.ShowDialog();
            chkSelectAll.Checked = false;
        }

        //判断是否包含非本单位的信息 
        private bool IsContainsInspUnit(List<int> ids, string unitName)
        {
            if (
                HiddenDangerInfoService.GetEntities(h => ids.Contains(h.HDId) && h.InspUnit != unitName).Any())
            {
                return true;
            }
            return false;
        }

        private void tsbtnModifyZrInfo_Click(object sender, EventArgs e)
        {
            //修改责任信息
            var ids = GetSelectedIds();

            if (ids.Count == 0)
            {
                MessageBox.Show("请至少选中一条要修改的信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(roleNames.Contains("管理员") || roleNames.Contains("事业部领导") || roleNames.Contains("安全主管") ||
                  roleNames.Contains("安全办")))
            {
                //判断是否责任单位是否是本单位
                if (IsContainsZrdw(ids, AppCommon.CurrentLoginUser.UnitName))
                {
                    MessageBox.Show("不能修改【责任单位】不是本单位的信息，请重新选择！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }


            HiddenDangerInfoModifyZrInfoFrm modifyZrInfo=new HiddenDangerInfoModifyZrInfoFrm(ids);
            modifyZrInfo.InitDgvList += InitDgvList;
            modifyZrInfo.ShowDialog();
            chkSelectAll.Checked = false;
        }
        
        //判断是否包含非本单位的信息 
        private bool IsContainsZrdw(List<int> ids, string unitName)
        {
            if (
                HiddenDangerInfoService.GetEntities(h => ids.Contains(h.HDId) && h.Zrdw != unitName).Any())
            {
                return true;
            }
            return false;
        }

        private List<int> GetSelectedIds()
        {
            List<int> ids=new List<int>();
            if (dgvList.RowCount == 0)
            {
                return ids;
            }
            dgvList.EndEdit();  //调用一下编辑结束事件或是将当前单元格指向别处

            foreach (DataGridViewRow row in dgvList.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == "1")
                {
                    ids.Add(Convert.ToInt32(row.Cells["HDId"].Value));
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


            if (HiddenDangerInfoService.DeleteEntities(ids))
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

        private void cbxZrdw_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbx=sender as ComboBox;
        }

        private void cbxZrdw_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbxZrdw.SelectedValue==null){ return;}
            int unitId= Int32.Parse(cbxZrdw.SelectedValue.ToString());
            TeamInfoService = ServiceSession.TeamInfoService;
            //给责任班组添加Item
            var zrbzEntities = TeamInfoService.AsNoTrackingGetEntities(t => t.DelFlag == DelFlagNormal && t.UnitInfoId == unitId)
                .Select(t => new {t.Id, t.TeamName}).ToList();
            cbxZrbz.DisplayMember = "TeamName";
            cbxZrbz.ValueMember = "Id";
            cbxZrbz.DataSource = zrbzEntities;
            cbxZrbz.SelectedIndex = -1;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
           
            SaveFileDialog sfd= new SaveFileDialog();
            sfd.Title = "导出数据到Excel";
            sfd.DefaultExt = "xls";
            sfd.Filter = "Excel文档(*.xls)|*.xls|所有文件(All.*)|*.*";
            sfd.FileName = "隐患整改信息表";
            string fileTitle = "隐患整改信息表";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                InfoesReports.ExportToExcel(sfd.FileName,fileTitle,dgvList);
            }
        }
    }
}
