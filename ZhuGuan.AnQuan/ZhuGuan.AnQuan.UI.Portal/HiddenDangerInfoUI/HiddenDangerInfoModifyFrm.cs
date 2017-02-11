using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZhuGuan.AnQuan.Common;
using ZhuGuan.AnQuan.IBLL;
using ZhuGuan.AnQuan.Model;

namespace ZhuGuan.AnQuan.UI.Portal.HiddenDangerInfoUI
{
    public partial class HiddenDangerInfoModifyFrm : BaseFrm
    {
        private readonly List<int> Ids;
        public event Action InitDgvList;
        private IHiddenDangerInfoService HiddenDangerInfoService;
        private IUnitInfoService UnitInfoService;
        private ITeamInfoService TeamInfoService;
        private List<string> roleNames;

        public HiddenDangerInfoModifyFrm(List<int> ids)
        {
            InitializeComponent();
            Ids = ids;
        }

        private void HiddenDangerInfoModifyFrm_Load(object sender, EventArgs e)
        {
            WindowState=FormWindowState.Maximized;
            dgvModify.AutoGenerateColumns = false;
            HiddenDangerInfoService = ServiceSession.HiddenDangerInfoService;
            UnitInfoService = ServiceSession.UnitInfoService;
            TeamInfoService = ServiceSession.TeamInfoService;

            dgvModify.Controls.Add(cbxInspUnit2);
            dgvModify.Controls.Add(cbxZrdw);
            dgvModify.Controls.Add(cbxZrbz);
            dgvModify.Controls.Add(dtpPreTime);
            dgvModify.Controls.Add(cbxIsAchieved);
            dgvModify.Controls.Add(cbxClass);
            dgvModify.Controls.Add(cbxLevel);
            roleNames = AppCommon.CurrentLoginUser.RoleInfo.Select(r => r.RoleName).ToList();

            LoadCombList();


            List<HiddenDangerInfo> entities = HiddenDangerInfoService.AsNoTrackingGetEntities(h => Ids.Contains(h.HDId)).ToList();
            dgvModify.DataSource = entities;
        }

        private void LoadCombList()
        {
            //添加责任单位

            var zrdwEntities = UnitInfoService.AsNoTrackingGetEntities(u => u.IsZrdw == 1 && u.DelFlag == DelFlagNormal)
                .Select(u => new { u.Id, u.UnitName }).ToList();
            cbxZrdw.DisplayMember = "UnitName";
            cbxZrdw.ValueMember = "Id";
            cbxZrdw.DataSource = zrdwEntities;
            cbxZrdw.SelectedIndex = -1;

            //添加检查单位
            if (!(roleNames.Contains("管理员") || roleNames.Contains("事业部领导") || roleNames.Contains("安全主管") ||
                roleNames.Contains("安全办")))
            {
                dgvModify.Columns["InspUnit"].ReadOnly = true;
                return;
            }


            var inspUnitEntities =
                UnitInfoService.AsNoTrackingGetEntities(u => u.IsInspUnit == 1 && u.DelFlag == DelFlagNormal)
                    .Select(u => new {u.Id, u.UnitName}).ToList();
            cbxInspUnit2.DisplayMember = "UnitName";
            cbxInspUnit2.ValueMember = "Id";
            cbxInspUnit2.DataSource = inspUnitEntities;
            cbxInspUnit2.SelectedIndex = -1;
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            dgvModify.EndEdit();
            //保存
            List<HiddenDangerInfo> entities = dgvModify.DataSource as List<HiddenDangerInfo>;

            if (HiddenDangerInfoService.UpdateEntities(entities))
            {
                InitDgvList();
                this.Close();
            }

        }

        private void miQuit_Click(object sender, EventArgs e)
        {
            //退出
            this.Close();
        }

        private void dgvModify_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvModify.BeginEdit(true);
        }

        private void dgvModify_CurrentCellChanged(object sender, EventArgs e)
        {
            DataGridViewCell cbxCell = dgvModify.CurrentCell;
            if (cbxCell != null)
            {
                switch (cbxCell.OwningColumn.Name)
                {
                    case "InspUnit":
                        if (!(roleNames.Contains("管理员") || roleNames.Contains("事业部领导") || roleNames.Contains("安全主管") ||
                              roleNames.Contains("安全办")))
                        {
                            break;
                        }
                        Rectangle rectInspUnit = dgvModify.GetCellDisplayRectangle(cbxCell.ColumnIndex, cbxCell.RowIndex, true);
                        cbxInspUnit2.Text = cbxCell.Value == null ? "" : cbxCell.Value.ToString();
                        cbxInspUnit2.Size = rectInspUnit.Size;
                        cbxInspUnit2.Top = rectInspUnit.Top;
                        cbxInspUnit2.Left = rectInspUnit.Left;
                        cbxInspUnit2.Visible = true;
                        cbxZrdw.Visible = false;
                        cbxZrbz.Visible = false;
                        dtpPreTime.Visible = false;
                        cbxIsAchieved.Visible = false;
                        cbxClass.Visible = false;
                        cbxLevel.Visible = false;
                        break;
                    case "Zrdw":
                        Rectangle rectZrdw = dgvModify.GetCellDisplayRectangle(cbxCell.ColumnIndex, cbxCell.RowIndex, true);
                        cbxZrdw.Text = cbxCell.Value == null ? "" : cbxCell.Value.ToString();
                        cbxZrdw.Size = rectZrdw.Size;
                        cbxZrdw.Top = rectZrdw.Top;
                        cbxZrdw.Left = rectZrdw.Left;
                        cbxZrdw.Visible = true;
                        cbxInspUnit2.Visible = false;
                        cbxZrbz.Visible = false;
                        dtpPreTime.Visible = false;
                        cbxIsAchieved.Visible = false;
                        cbxClass.Visible = false;
                        cbxLevel.Visible = false;
                        break;
                    case "Zrbz":
                        Rectangle rectZrbz = dgvModify.GetCellDisplayRectangle(cbxCell.ColumnIndex, cbxCell.RowIndex, true);
                        cbxZrbz.Text = cbxCell.Value == null ? "" : cbxCell.Value.ToString();
                        cbxZrbz.Size = rectZrbz.Size;
                        cbxZrbz.Top = rectZrbz.Top;
                        cbxZrbz.Left = rectZrbz.Left;
                        cbxZrbz.Visible = true;
                        cbxZrdw.Visible = false;
                        cbxInspUnit2.Visible = false;
                        dtpPreTime.Visible = false;
                        cbxIsAchieved.Visible = false;
                        cbxClass.Visible = false;
                        cbxLevel.Visible = false;
                        break;
                    case "PreTime":
                        Rectangle rectPreTime = dgvModify.GetCellDisplayRectangle(cbxCell.ColumnIndex, cbxCell.RowIndex, true);
                        dtpPreTime.Text = cbxCell.Value == null ? "" : cbxCell.Value.ToString();
                        dtpPreTime.Size = rectPreTime.Size;
                        dtpPreTime.Top = rectPreTime.Top;
                        dtpPreTime.Left = rectPreTime.Left;
                        dtpPreTime.Visible = true;
                        cbxInspUnit2.Visible = false;
                        cbxZrdw.Visible = false;
                        cbxZrbz.Visible = false;
                        cbxIsAchieved.Visible = false;
                        cbxClass.Visible = false;
                        cbxLevel.Visible = false;
                        break;
                    case "AchievedDesp":
                        Rectangle rectAchieved = dgvModify.GetCellDisplayRectangle(cbxCell.ColumnIndex, cbxCell.RowIndex,
                            true);
                        cbxIsAchieved.Text = cbxCell.Value == null ? "" : cbxCell.Value.ToString();
                        cbxIsAchieved.Size = rectAchieved.Size;
                        cbxIsAchieved.Top = rectAchieved.Top;
                        cbxIsAchieved.Left = rectAchieved.Left;
                        cbxIsAchieved.Visible = true;
                        cbxClass.Visible = false;
                        cbxInspUnit2.Visible = false;
                        cbxZrdw.Visible = false;
                        cbxZrbz.Visible = false;
                        dtpPreTime.Visible = false;
                        cbxLevel.Visible = false;
                        break;

                    case "Class2":
                        Rectangle rectClass = dgvModify.GetCellDisplayRectangle(cbxCell.ColumnIndex, cbxCell.RowIndex, true);
                        cbxClass.Text = cbxCell.Value == null ? "" : cbxCell.Value.ToString();
                        cbxClass.Size = rectClass.Size;
                        cbxClass.Top = rectClass.Top;
                        cbxClass.Left = rectClass.Left;
                        cbxClass.Visible = true;
                        cbxInspUnit2.Visible = false;
                        cbxZrdw.Visible = false;
                        cbxZrbz.Visible = false;
                        dtpPreTime.Visible = false;
                        cbxIsAchieved.Visible = false;
                        cbxLevel.Visible = false;
                        break;
                    case "Level2":
                        Rectangle rectLevel = dgvModify.GetCellDisplayRectangle(cbxCell.ColumnIndex, cbxCell.RowIndex, true);
                        cbxLevel.Text = cbxCell.Value == null ? "" : cbxCell.Value.ToString();
                        cbxLevel.Size = rectLevel.Size;
                        cbxLevel.Top = rectLevel.Top;
                        cbxLevel.Left = rectLevel.Left;
                        cbxLevel.Visible = true;
                        cbxInspUnit2.Visible = false;
                        cbxZrdw.Visible = false;
                        cbxZrbz.Visible = false;
                        dtpPreTime.Visible = false;
                        cbxIsAchieved.Visible = false;
                        cbxClass.Visible = false;
                        break;

                    default:
                        cbxInspUnit2.Visible = false;
                        cbxZrdw.Visible = false;
                        cbxZrbz.Visible = false;
                        dtpPreTime.Visible = false;
                        cbxIsAchieved.Visible = false;
                        cbxClass.Visible = false;
                        cbxLevel.Visible = false;
                        break;

                }
            }
        }

        private void cbxInspUnit2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvModify.CurrentCell == null)
            {
                return;
            }
            ComboBox cbx = sender as ComboBox;
            dgvModify.CurrentCell.Value = cbx.Text.Trim();
        }

        private void dtpPreTime_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            dgvModify.CurrentCell.Value = dtp.Value.ToString("yyyy-MM-dd");
        }

        private void cbxZrbz_Enter(object sender, EventArgs e)
        {
            if (dgvModify.CurrentCell != null && dgvModify.CurrentCell.OwningColumn.Name == "Zrbz" && dgvModify.CurrentRow.Cells[dgvModify.CurrentCell.ColumnIndex - 1].Value != null)
            {
                //给责任班组添加Item
                var unitName = dgvModify.CurrentRow.Cells[dgvModify.CurrentCell.ColumnIndex - 1].Value.ToString();
                var unitId =
                    UnitInfoService.AsNoTrackingGetEntities(u => u.UnitName == unitName && u.DelFlag == DelFlagNormal)
                        .Select(u => u.Id).FirstOrDefault();

                var zrbzEntities = TeamInfoService.AsNoTrackingGetEntities(t => t.DelFlag == DelFlagNormal && t.UnitInfoId == unitId)
                .Select(t => new { t.Id, t.TeamName }).ToList();
                cbxZrbz.DisplayMember = "TeamName";
                cbxZrbz.ValueMember = "Id";
                cbxZrbz.DataSource = zrbzEntities;
                cbxZrbz.SelectedIndex = -1;

            }
        }
    }
}
