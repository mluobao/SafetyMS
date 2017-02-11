using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZhuGuan.AnQuan.IBLL;
using ZhuGuan.AnQuan.Model;

namespace ZhuGuan.AnQuan.UI.Portal.HiddenDangerInfoUI
{
    public partial class HiddenDangerInfoModifyZrInfoFrm : BaseFrm
    {
        private readonly List<int> Ids;
        public event Action InitDgvList;
        private IHiddenDangerInfoService HiddenDangerInfoService;
        private IUnitInfoService UnitInfoService;
        private ITeamInfoService TeamInfoService;

        public HiddenDangerInfoModifyZrInfoFrm(List<int> ids)
        {
            InitializeComponent();
            Ids = ids;
        }

        private void HiddenDangerInfoModifyZrInfoFrm_Load(object sender, EventArgs e)
        {
            WindowState=FormWindowState.Maximized;
            dgvModify.AutoGenerateColumns = false;
            HiddenDangerInfoService = ServiceSession.HiddenDangerInfoService;
            UnitInfoService = ServiceSession.UnitInfoService;
            TeamInfoService = ServiceSession.TeamInfoService;

            dgvModify.Controls.Add(cbxZrbz);
            dgvModify.Controls.Add(cbxIsAchieved);
            
            List<HiddenDangerInfo> entities = HiddenDangerInfoService.AsNoTrackingGetEntities(h => Ids.Contains(h.HDId)).ToList();
            dgvModify.DataSource = entities;
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
                    
                    
                    case "Zrbz":
                        Rectangle rectZrbz = dgvModify.GetCellDisplayRectangle(cbxCell.ColumnIndex, cbxCell.RowIndex, true);
                        cbxZrbz.Text = cbxCell.Value == null ? "" : cbxCell.Value.ToString();
                        cbxZrbz.Size = rectZrbz.Size;
                        cbxZrbz.Top = rectZrbz.Top;
                        cbxZrbz.Left = rectZrbz.Left;
                        cbxZrbz.Visible = true;
                        cbxIsAchieved.Visible = false;
                        break;
                    
                    case "AchievedDesp":
                        Rectangle rectAchieved = dgvModify.GetCellDisplayRectangle(cbxCell.ColumnIndex, cbxCell.RowIndex,
                            true);
                        cbxIsAchieved.Text = cbxCell.Value == null ? "" : cbxCell.Value.ToString();
                        cbxIsAchieved.Size = rectAchieved.Size;
                        cbxIsAchieved.Top = rectAchieved.Top;
                        cbxIsAchieved.Left = rectAchieved.Left;
                        cbxIsAchieved.Visible = true;
                        cbxZrbz.Visible = false;
                        break;

                    

                    default:
                        cbxZrbz.Visible = false;
                        cbxIsAchieved.Visible = false;
                        break;

                }
            }
        }

        private void cbxZrbz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvModify.CurrentCell == null)
            {
                return;
            }
            ComboBox cbx = sender as ComboBox;
            dgvModify.CurrentCell.Value = cbx.Text.Trim();
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
