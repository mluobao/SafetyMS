using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ZhuGuan.AnQuan.IBLL;
using ZhuGuan.AnQuan.Model;

namespace ZhuGuan.AnQuan.UI.Portal.UnitInfoUI
{
    public partial class UnitInfoModifyFrm : BaseFrm
    {
        private readonly List<int> Ids;
        public event Action InitDgvList;
        public IUnitInfoService UnitInfoService;

        public UnitInfoModifyFrm(List<int> ids)
        {
            InitializeComponent();
            Ids = ids;
        }

        private void UnitInfoModifyFrm_Load(object sender, EventArgs e)
        {
            dgvModify.AutoGenerateColumns = false;

            UnitInfoService = ServiceSession.UnitInfoService;

            var entities = UnitInfoService.AsNoTrackingGetEntities(u => Ids.Contains(u.Id)).ToList();
            dgvModify.DataSource = entities;
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            dgvModify.EndEdit();
            //保存
            List<UnitInfo> entities = dgvModify.DataSource as List<UnitInfo>;


            if (UnitInfoService.UpdateEntities(entities))
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
    }
}
