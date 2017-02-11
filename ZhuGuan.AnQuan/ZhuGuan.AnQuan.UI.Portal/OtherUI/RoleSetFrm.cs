using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ZhuGuan.AnQuan.IBLL;
using ZhuGuan.AnQuan.Model;

namespace ZhuGuan.AnQuan.UI.Portal.OtherUI
{
    public partial class RoleSetFrm : BaseFrm
    {
        private int UserId;
        private IUserInfoService UserInfoService;
        private IRoleInfoService RoleInfoService;
        private UserInfo CurrentUser;
        public RoleSetFrm(int userId)
        {
            InitializeComponent();
            UserId = userId;
        }

        private void RoleSetFrm_Load(object sender, EventArgs e)
        {
            UserInfoService = ServiceSession.UserInfoService;
            RoleInfoService = ServiceSession.RoleInfoService;

            LoadRoleSet();//加载原先设置的权限
        }

        private void LoadRoleSet()
        {
            CurrentUser = UserInfoService.AsNoTrackingGetEntities(u => u.Id == UserId).FirstOrDefault();
            labUser.Text = "请为【" + CurrentUser.UserName + "】设置权限";

            var allSelectedRoles = (from r in CurrentUser.RoleInfo select r.RoleName).ToList();
            foreach (var control in pnlContainer.Controls)
            {
                var chk = control as CheckBox;
                if (allSelectedRoles.Contains(chk.Text.Trim()))
                {
                    chk.Checked = true;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            List<string> setRoleNameList=new List<string>();
            foreach (var control in pnlContainer.Controls)
            {
                var chk = control as CheckBox;
                if (chk.Checked)
                {
                    setRoleNameList.Add(chk.Text.Trim());
                }
            }
            //设置用户权限
            
            if (UserInfoService.SetRole(UserId, setRoleNameList))
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
