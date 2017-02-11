using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZhuGuan.AnQuan.IBLL;
using ZhuGuan.AnQuan.Model;

namespace ZhuGuan.AnQuan.UI.Portal.AccidentInfoUI
{
    public partial class AccidentInfoAddFrm : BaseFrm
    {
        public IAccidentInfoService AccidentInfoService;
        private IUnitInfoService UnitInfoService;

        public event Action InitDgvList;
        public AccidentInfoAddFrm()
        {
            InitializeComponent();
        }

        private void AccidentInfoAddFrm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            dtpInspDate.Value = DateTime.Now.Date;
            AccidentInfoService = ServiceSession.AccidentInfoService;
            UnitInfoService = ServiceSession.UnitInfoService;

            dgvAdd.Controls.Add(cbxUnit2);
            dgvAdd.Controls.Add(cbxAcciType);   
            dgvAdd.Controls.Add(cbxClass);

            //添加责任单位
            var unitEntities = UnitInfoService.AsNoTrackingGetEntities(u => u.IsZrdw == 1 && u.DelFlag == DelFlagNormal)
                .Select(u => new { u.Id, u.UnitName }).ToList();
            cbxUnit.DisplayMember = "UnitName";
            cbxUnit.ValueMember = "Id";
            cbxUnit.DataSource = unitEntities;
            cbxUnit.SelectedIndex = -1;
            cbxUnit2.DisplayMember = "UnitName";
            cbxUnit2.ValueMember = "Id";
            cbxUnit2.DataSource = unitEntities;
            cbxUnit2.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //添加
            dgvAdd.Rows.Add();
            int currentRowIndex = dgvAdd.RowCount - 1;
            dgvAdd.Rows[currentRowIndex].Cells[1].Value = dtpInspDate.Value.ToString("yyyy-MM-dd");
            dgvAdd.Rows[currentRowIndex].Cells[2].Value = cbxUnit.Text.Trim();
            dgvAdd.CurrentCell = dgvAdd.Rows[currentRowIndex].Cells[3];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //删除
            if (dgvAdd.CurrentRow != null)
            {
                int currentRowIndex = dgvAdd.CurrentRow.Index - 1;
                dgvAdd.Rows.Remove(dgvAdd.CurrentRow);
                if (dgvAdd.RowCount > 0)
                {
                    dgvAdd.CurrentCell = dgvAdd.Rows[currentRowIndex].Cells[1];
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //保存
            if (dgvAdd.RowCount == 0)
            {
                this.Close();
            }
            dgvAdd.EndEdit();
            List<AccidentInfo> entities = new List<AccidentInfo>();

            foreach (DataGridViewRow row in dgvAdd.Rows)
            {
                if (row.Cells["Unit"].Value != null)
                {
                    entities.Add(new AccidentInfo()
                    {
                        HappenDate = row.Cells["HappenDate"].Value==null? DateTime.Now.Date:Convert.ToDateTime(row.Cells["HappenDate"].Value.ToString()),
                        Unit = row.Cells["Unit"].Value==null? String.Empty : row.Cells["Unit"].Value.ToString(),
                        AcciType = row.Cells["AcciType"].Value==null? string.Empty : row.Cells["AcciType"].Value.ToString(),
                        AcciDesp = row.Cells["AcciDesp"].Value==null? string.Empty : row.Cells["AcciDesp"].Value.ToString(),
                        AcciAnalysis = row.Cells["AcciAnalysis"].Value==null? string.Empty : row.Cells["AcciAnalysis"].Value.ToString(),
                        Class2 = row.Cells["Class2"].Value==null? string.Empty : row.Cells["Class2"].Value.ToString(),
                        Remark = row.Cells["Remark"].Value == null ? string.Empty : row.Cells["Remark"].Value.ToString(),
                        DelFlag = (short)DelFlagNormal
                    });
                }
            }

            if (AccidentInfoService.AddEntities(entities) != null)
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
                    case "Unit":
                        Rectangle rectUnit = dgvAdd.GetCellDisplayRectangle(cbxCell.ColumnIndex, cbxCell.RowIndex, true);
                        cbxUnit2.Text = cbxCell.Value == null ? "" : cbxCell.Value.ToString();
                        cbxUnit2.Size = rectUnit.Size;
                        cbxUnit2.Top = rectUnit.Top;
                        cbxUnit2.Left = rectUnit.Left;
                        cbxUnit2.Visible = true;
                        cbxAcciType.Visible = false;
                        cbxClass.Visible = false;
                        break;
                    case "AcciType":
                        Rectangle rectAcciType = dgvAdd.GetCellDisplayRectangle(cbxCell.ColumnIndex, cbxCell.RowIndex, true);
                        cbxAcciType.Text = cbxCell.Value == null ? "" : cbxCell.Value.ToString();
                        cbxAcciType.Size = rectAcciType.Size;
                        cbxAcciType.Top = rectAcciType.Top;
                        cbxAcciType.Left = rectAcciType.Left;
                        cbxAcciType.Visible = true;
                        cbxUnit2.Visible = false;
                        cbxClass.Visible = false;
                        break;
                    case "Class2":
                        Rectangle rectClass = dgvAdd.GetCellDisplayRectangle(cbxCell.ColumnIndex, cbxCell.RowIndex, true);
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
            if (dgvAdd.CurrentCell == null)
            {
                return;
            }
            ComboBox cbx = sender as ComboBox;
            dgvAdd.CurrentCell.Value = cbx.Text.Trim();
        }
    }
}
