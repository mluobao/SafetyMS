using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZhuGuan.AnQuan.IBLL;
using ZhuGuan.AnQuan.Model;
using ZhuGuan.AnQuan.Model.ClassExt;

namespace ZhuGuan.AnQuan.UI.Portal.UserInfoUI
{
    public partial class UserInfoAddFrm : BaseFrm
    {
        public IUserInfoService UserInfoService;
        private IUnitInfoService UnitInfoService;

        public event Action InitDgvList;
        public UserInfoAddFrm()
        {
            InitializeComponent();
        }

        private void UserInfoAddFrm_Load(object sender, EventArgs e)
        {
            UserInfoService = ServiceSession.UserInfoService;
            UnitInfoService = ServiceSession.UnitInfoService;

            dgvAdd.Controls.Add(cbxUnit2);

            //添加责任单位
            var unitEntities = UnitInfoService.AsNoTrackingGetEntities(u => u.IsInspUnit == 1 && u.DelFlag == DelFlagNormal)
                .Select(u => new UnitItemInfo(){ Id = u.Id, UnitName = u.UnitName }).ToList();
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
            dgvAdd.Rows[currentRowIndex].Cells[1].Value = cbxUnit.Text.Trim();
            dgvAdd.CurrentCell = dgvAdd.Rows[currentRowIndex].Cells[2];
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
                    dgvAdd.CurrentCell = dgvAdd.Rows[currentRowIndex].Cells[2];
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
            List<UserInfo> entities = new List<UserInfo>();
            var unitItems = cbxUnit.DataSource as List<UnitItemInfo>;
            foreach (DataGridViewRow row in dgvAdd.Rows)
            {
                if (row.Cells["UserName"].Value != null)
                {
                    entities.Add(new UserInfo()
                    {
                        UnitInfoId = row.Cells["UnitName"].Value == null ? 0 : unitItems.Where(ui => ui.UnitName == row.Cells["UnitName"].Value.ToString()).Select(ui => ui.Id).FirstOrDefault(),
                        UserName = row.Cells["UserName"].Value == null ? string.Empty : row.Cells["UserName"].Value.ToString(),
                        Pwd = row.Cells["Pwd"].Value == null ? string.Empty : row.Cells["Pwd"].Value.ToString(),
                        Remark = row.Cells["Remark"].Value == null ? string.Empty : row.Cells["Remark"].Value.ToString(),
                        DelFlag = (short)DelFlagNormal,
                        IsVerified = row.Cells["IsVerified"].Value == null ? (short)1 : short.Parse(row.Cells["IsVerified"].Value.ToString())
                    });
                }
            }

            var addResult = UserInfoService.AddEntities(entities);

            if (addResult != null)
            {
                foreach (var entity in addResult)
                {
                    UserInfoService.SetRole(entity.Id, new List<string>() {"责任单位"});
                }
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
                    case "UnitName":
                        Rectangle rectUnit = dgvAdd.GetCellDisplayRectangle(cbxCell.ColumnIndex, cbxCell.RowIndex, true);
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
            if (dgvAdd.CurrentCell == null)
            {
                return;
            }
            ComboBox cbx = sender as ComboBox;
            dgvAdd.CurrentCell.Value = cbx.Text.Trim();
        }
    }
}
