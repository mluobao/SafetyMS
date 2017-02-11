using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZhuGuan.AnQuan.IBLL;
using ZhuGuan.AnQuan.Model;
using ZhuGuan.AnQuan.Model.ClassExt;

namespace ZhuGuan.AnQuan.UI.Portal.TeamInfoUI
{
    public partial class TeamInfoModifyFrm : BaseFrm
    {
        private readonly List<int> Ids;
        public event Action InitDgvList;
        public ITeamInfoService TeamInfoService;
        private IUnitInfoService UnitInfoService;
        private List<UnitItemInfo> unitItems;

        public TeamInfoModifyFrm(List<int> ids)
        {
            InitializeComponent();
            Ids = ids;
        }

        private void TeamInfoModifyFrm_Load(object sender, EventArgs e)
        {
            dgvModify.AutoGenerateColumns = false;

            dgvModify.Controls.Add(cbxUnit2);

            UnitInfoService = ServiceSession.UnitInfoService;
            //添加责任单位
            unitItems = UnitInfoService.AsNoTrackingGetEntities(u => u.IsInspUnit == 1 && u.DelFlag == DelFlagNormal)
                .Select(u => new UnitItemInfo() { Id = u.Id, UnitName = u.UnitName }).ToList();
            cbxUnit2.DisplayMember = "UnitName";
            cbxUnit2.ValueMember = "Id";
            cbxUnit2.DataSource = unitItems;

            TeamInfoService = ServiceSession.TeamInfoService;
            var teamList = TeamInfoService.AsNoTrackingGetEntities(u => Ids.Contains(u.Id)).ToList();
            var teamEntities = teamList.Select(t => new TeamInfo()
                {
                    Id = t.Id,
                    TeamName = t.TeamName,
                    DelFlag = t.DelFlag,
                    Remark = t.Remark,
                    UnitName = unitItems.Where(ui => ui.Id == t.UnitInfoId).Select(ui => ui.UnitName).FirstOrDefault()
                }).ToList();


            dgvModify.DataSource = teamEntities;
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            dgvModify.EndEdit();
            //保存
            List<TeamInfo> teamlist = dgvModify.DataSource as List<TeamInfo>;
            var teamEntities = teamlist.Select(t => new TeamInfo()
            {
                Id = t.Id,
                TeamName = t.TeamName,
                DelFlag = t.DelFlag,
                Remark = t.Remark,
                UnitInfoId = unitItems.Where(ui => ui.UnitName == t.UnitName).Select(ui => ui.Id).FirstOrDefault()
            }).ToList();

            if (TeamInfoService.UpdateEntities(teamEntities))
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
                    case "UnitName":
                        Rectangle rectUnit = dgvModify.GetCellDisplayRectangle(cbxCell.ColumnIndex, cbxCell.RowIndex, true);
                        cbxUnit2.Text = cbxCell.Value == null ? "" : cbxCell.Value.ToString();
                        cbxUnit2.Size = rectUnit.Size;
                        cbxUnit2.Top = rectUnit.Top;
                        cbxUnit2.Left = rectUnit.Left;
                        cbxUnit2.Visible = true;
                        break;

                    default:
                        cbxUnit2.Visible = false;
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
    }
}
