using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZhuGuan.AnQuan.IBLL;
using ZhuGuan.AnQuan.Model;

namespace ZhuGuan.AnQuan.UI.Portal.UnitInfoUI
{
    public partial class UnitInfoAddFrm : BaseFrm
    {
        public IUnitInfoService UnitInfoService;

        public event Action InitDgvList;
        public UnitInfoAddFrm()
        {
            InitializeComponent();
        }

        private void UnitInfoAddFrm_Load(object sender, EventArgs e)
        {
            UnitInfoService = ServiceSession.UnitInfoService;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //添加
            dgvAdd.Rows.Add();
            int currentRowIndex = dgvAdd.RowCount - 1;
            dgvAdd.CurrentCell = dgvAdd.Rows[currentRowIndex].Cells[1];
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
            List<UnitInfo> entities = new List<UnitInfo>();
            foreach (DataGridViewRow row in dgvAdd.Rows)
            {
                if (row.Cells["UnitName"].Value != null)
                {
                    entities.Add(new UnitInfo()
                    {
                        UnitName = row.Cells["UnitName"].Value == null ? string.Empty : row.Cells["UnitName"].Value.ToString(),
                        IsInspUnit = row.Cells["IsInspUnit"].Value == null ? (short)0 : Int16.Parse(row.Cells["IsInspUnit"].Value.ToString()),
                        IsZrdw = row.Cells["IsZrdw"].Value == null ? (short)0 : Int16.Parse(row.Cells["IsZrdw"].Value.ToString()),
                        UnitProperty = row.Cells["UnitProperty"].Value == null ? string.Empty : row.Cells["UnitProperty"].Value.ToString(),
                        Remark = row.Cells["Remark"].Value == null ? string.Empty : row.Cells["Remark"].Value.ToString(),
                        DelFlag = DelFlagNormal
                    });
                }
            }

            if (UnitInfoService.AddEntities(entities) != null)
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
    }
}
