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
    public partial class HiddenDangerInfoAddFrm : BaseFrm
    {
        private IHiddenDangerInfoService HiddenDangerInfoService;
        private IUnitInfoService UnitInfoService;
        private ITeamInfoService TeamInfoService;
        private List<string> roleNames;

        public event Action InitDgvList;
        public HiddenDangerInfoAddFrm()
        {
            InitializeComponent();
        }

        private void HiddenDangerInfoAddFrm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            dtpInspDate.Value = DateTime.Now.Date;
            HiddenDangerInfoService = ServiceSession.HiddenDangerInfoService;
            UnitInfoService = ServiceSession.UnitInfoService;
            TeamInfoService = ServiceSession.TeamInfoService;

            dgvAdd.Controls.Add(cbxInspUnit2);
            dgvAdd.Controls.Add(cbxZrdw);
            dgvAdd.Controls.Add(cbxZrbz);
            dgvAdd.Controls.Add(dtpPreTime);  
            dgvAdd.Controls.Add(cbxIsAchieved);
            dgvAdd.Controls.Add(cbxClass);
            dgvAdd.Controls.Add(cbxLevel);
            roleNames = AppCommon.CurrentLoginUser.RoleInfo.Select(r => r.RoleName).ToList();
            
            //加载下拉框中的选项
            LoadCombList();
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
                labInspUnit.Visible = false;
                cbxInspUnit.Visible = false;
                cbxInspUnit.Text = AppCommon.CurrentLoginUser.UnitName;
                dgvAdd.Columns["InspUnit"].ReadOnly = true;
                return;
            }
            var inspUnitEntities =
                UnitInfoService.AsNoTrackingGetEntities(u => u.IsInspUnit == 1 && u.DelFlag == DelFlagNormal)
                    .Select(u => new {u.Id, u.UnitName}).ToList();
            cbxInspUnit.DisplayMember = "UnitName";
            cbxInspUnit.ValueMember = "Id";
            cbxInspUnit.DataSource = inspUnitEntities;
            cbxInspUnit.SelectedIndex = -1;
            cbxInspUnit2.DisplayMember = "UnitName";
            cbxInspUnit2.ValueMember = "Id";
            cbxInspUnit2.DataSource = inspUnitEntities;
            cbxInspUnit2.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //添加
            dgvAdd.Rows.Add();
            int currentRowIndex = dgvAdd.RowCount - 1;
            dgvAdd.Rows[currentRowIndex].Cells["InspDate"].Value = dtpInspDate.Value.ToString("yyyy-MM-dd");
            dgvAdd.Rows[currentRowIndex].Cells["InspUnit"].Value = cbxInspUnit.Text.Trim();
            dgvAdd.Rows[currentRowIndex].Cells["TraceMan"].Value = AppCommon.CurrentLoginUser.UserName;
            dgvAdd.CurrentCell = dgvAdd.Rows[currentRowIndex].Cells[3];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //删除
            if (dgvAdd.CurrentRow != null)
            {
                int currentRowIndex = dgvAdd.CurrentRow.Index-1;
                dgvAdd.Rows.Remove(dgvAdd.CurrentRow);
                if (dgvAdd.RowCount > 0)
                {
                    dgvAdd.CurrentCell = dgvAdd.Rows[currentRowIndex].Cells[1];
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvAdd.RowCount == 0)
            {
                this.Close();
            }
            dgvAdd.EndEdit();
            //保存
            List<HiddenDangerInfo> entities = new List<HiddenDangerInfo>();

            foreach (DataGridViewRow row in dgvAdd.Rows)
            {
                if (row.Cells["InspUnit"].Value != null)
                {
                    entities.Add(new HiddenDangerInfo()
                    {
                        InspDate = row.Cells["InspDate"].Value==null? DateTime.Now.Date : Convert.ToDateTime(row.Cells["InspDate"].Value.ToString()),
                        InspUnit = row.Cells["InspUnit"].Value==null? string.Empty : row.Cells["InspUnit"].Value.ToString(),
                        Zrdw = row.Cells["Zrdw"].Value==null? String.Empty : row.Cells["Zrdw"].Value.ToString(),
                        Zrbz = row.Cells["Zrbz"].Value==null? String.Empty : row.Cells["Zrbz"].Value.ToString(),
                        HidProblem = row.Cells["HidProblem"].Value==null? String.Empty : row.Cells["HidProblem"].Value.ToString(),
                        ReformMeasure = row.Cells["ReformMeasure"].Value == null ? String.Empty : row.Cells["ReformMeasure"].Value.ToString(),
                        PreTime =row.Cells["PreTime"].Value == null ? (Nullable<DateTime>) null : Convert.ToDateTime(row.Cells["PreTime"].Value.ToString()) ,//要空数据强制转换成可空的DateTime类型
                        AchievedDesp = row.Cells["AchievedDesp"].Value == null ? "未整改":row.Cells["AchievedDesp"].Value.ToString(),
                        ReasonNotCompleted = row.Cells["ReasonNotCompleted"].Value == null ? string.Empty:row.Cells["ReasonNotCompleted"].Value.ToString(),
                        TraceMan = row.Cells["TraceMan"].Value==null? string.Empty : row.Cells["TraceMan"].Value.ToString(),
                        Class2 = row.Cells["Class2"].Value == null ? string.Empty : row.Cells["Class2"].Value.ToString(),
                        Level2 = row.Cells["Level2"].Value == null ? string.Empty : row.Cells["Level2"].Value.ToString(),
                        Remark = row.Cells["Remark"].Value == null ? string.Empty : row.Cells["Remark"].Value.ToString(),
                        DelFlag = (short)DelFlagNormal
                    });
                }
            }

            if (HiddenDangerInfoService.AddEntities(entities) != null)
            {
                InitDgvList();
                this.Close();
            }
        }

        private void dgvAdd_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvAdd.BeginEdit(true);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAdd_CurrentCellChanged(object sender, EventArgs e)
        {
            DataGridViewCell cbxCell = dgvAdd.CurrentCell;
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
                        Rectangle rectInspUnit = dgvAdd.GetCellDisplayRectangle(cbxCell.ColumnIndex,
                                cbxCell.RowIndex, true);
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
                        Rectangle rectZrdw = dgvAdd.GetCellDisplayRectangle(cbxCell.ColumnIndex, cbxCell.RowIndex, true);
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
                        Rectangle rectZrbz = dgvAdd.GetCellDisplayRectangle(cbxCell.ColumnIndex, cbxCell.RowIndex, true);
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
                        Rectangle rectPreTime = dgvAdd.GetCellDisplayRectangle(cbxCell.ColumnIndex, cbxCell.RowIndex, true);
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
                        Rectangle rectAchieved = dgvAdd.GetCellDisplayRectangle(cbxCell.ColumnIndex, cbxCell.RowIndex,
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
                        Rectangle rectClass = dgvAdd.GetCellDisplayRectangle(cbxCell.ColumnIndex, cbxCell.RowIndex, true);
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
                        Rectangle rectLevel = dgvAdd.GetCellDisplayRectangle(cbxCell.ColumnIndex, cbxCell.RowIndex, true);
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
            if (dgvAdd.CurrentCell == null)
            {
                return;
            }
            ComboBox cbx = sender as ComboBox;
            dgvAdd.CurrentCell.Value = cbx.Text.Trim();
        }

        private void dtpPreTime_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            dgvAdd.CurrentCell.Value = dtp.Value.ToString("yyyy-MM-dd");
        }

        private void cbxZrbz_Enter(object sender, EventArgs e)
        {
            if (dgvAdd.CurrentCell != null && dgvAdd.CurrentCell.OwningColumn.Name == "Zrbz"&& dgvAdd.CurrentRow.Cells[dgvAdd.CurrentCell.ColumnIndex-1].Value!=null)
            {
                //给责任班组添加Item
                var unitName = dgvAdd.CurrentRow.Cells[dgvAdd.CurrentCell.ColumnIndex - 1].Value.ToString();
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
