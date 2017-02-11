using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZhuGuan.AnQuan.IBLL;
using ZhuGuan.AnQuan.Model;

namespace ZhuGuan.AnQuan.UI.Portal.AccidentInfoUI
{
    public partial class AccidentInfoModifyFrm : BaseFrm
    {
        private readonly List<int> Ids;
        public event Action InitDgvList;
        public IAccidentInfoService AccidentInfoService;
        private IUnitInfoService UnitInfoService;

        public AccidentInfoModifyFrm(List<int> ids)
        {
            InitializeComponent();
            Ids = ids;
        }

        private void AccidentInfoModifyFrm_Load(object sender, EventArgs e)
        {
            WindowState=FormWindowState.Maximized;
            dgvModify.AutoGenerateColumns = false;

            dgvModify.Controls.Add(cbxUnit2);
            dgvModify.Controls.Add(cbxAcciType);
            dgvModify.Controls.Add(cbxClass);

            UnitInfoService = ServiceSession.UnitInfoService;
            //添加责任单位
            var unitEntities = UnitInfoService.AsNoTrackingGetEntities(u => u.IsZrdw == 1 && u.DelFlag == DelFlagNormal)
                .Select(u => new { u.Id, u.UnitName }).ToList();
            cbxUnit2.DisplayMember = "UnitName";
            cbxUnit2.ValueMember = "Id";
            cbxUnit2.DataSource = unitEntities;

            AccidentInfoService = ServiceSession.AccidentInfoService;
            List<AccidentInfo> entities = AccidentInfoService.AsNoTrackingGetEntities(a => Ids.Contains(a.AId)).ToList();
            dgvModify.DataSource = entities;
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            dgvModify.EndEdit();
            //保存
            List<AccidentInfo> entities = dgvModify.DataSource as List<AccidentInfo>;

            if (AccidentInfoService.UpdateEntities(entities))
            {
                //MessageBox.Show("修改成功");
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
                    case "Unit":
                        Rectangle rectUnit = dgvModify.GetCellDisplayRectangle(cbxCell.ColumnIndex, cbxCell.RowIndex, true);
                        cbxUnit2.Text = cbxCell.Value == null ? "" : cbxCell.Value.ToString();
                        cbxUnit2.Size = rectUnit.Size;
                        cbxUnit2.Top = rectUnit.Top;
                        cbxUnit2.Left = rectUnit.Left;
                        cbxUnit2.Visible = true;
                        cbxAcciType.Visible = false;
                        cbxClass.Visible = false;
                        break;
                    case "AcciType":
                        Rectangle rectAcciType = dgvModify.GetCellDisplayRectangle(cbxCell.ColumnIndex, cbxCell.RowIndex, true);
                        cbxAcciType.Text = cbxCell.Value == null ? "" : cbxCell.Value.ToString();
                        cbxAcciType.Size = rectAcciType.Size;
                        cbxAcciType.Top = rectAcciType.Top;
                        cbxAcciType.Left = rectAcciType.Left;
                        cbxAcciType.Visible = true;
                        cbxUnit2.Visible = false;
                        cbxClass.Visible = false;
                        break;
                    case "Class2":
                        Rectangle rectClass = dgvModify.GetCellDisplayRectangle(cbxCell.ColumnIndex, cbxCell.RowIndex, true);
                        cbxClass.Text = cbxCell.Value == null ? "" : cbxCell.Value.ToString();
                        cbxClass.Size = rectClass.Size;
                        cbxClass.Top = rectClass.Top;
                        cbxClass.Left = rectClass.Left;
                        cbxClass.Visible = true;
                        cbxUnit2.Visible = false;
                        cbxAcciType.Visible = false;
                        break;

                    default:
                        cbxUnit2.Visible = false;
                        cbxAcciType.Visible = false;
                        cbxClass.Visible = false;
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

        private void mStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
