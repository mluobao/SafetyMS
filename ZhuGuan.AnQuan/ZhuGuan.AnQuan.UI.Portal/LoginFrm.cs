using System;
using System.Linq;
using System.Windows.Forms;
using ZhuGuan.AnQuan.Common;
using ZhuGuan.AnQuan.IBLL;
using ZhuGuan.AnQuan.Model;
using ZhuGuan.AnQuan.Model.Enum;
using ZhuGuan.AnQuan.UI.Portal.OtherUI;

namespace ZhuGuan.AnQuan.UI.Portal
{
    public partial class LoginFrm : BaseFrm
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string pwd = txtPwd.Text.Trim();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("用户名和密码不能为空！","提示",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            IUserInfoService UserInfoService = ServiceSession.UserInfoService;
            IUnitInfoService UnitInfoService = ServiceSession.UnitInfoService;


            short isFlag = 1;

            var loginUser = UserInfoService.AsNoTrackingGetEntities(u => u.UserName == userName && u.Pwd == pwd && u.DelFlag == (short)DelFlagEnum.Normal && u.IsVerified == isFlag).FirstOrDefault();
            if (loginUser != null)
            {
                AppCommon.CurrentLoginUser = new UserInfo()
                {
                    Id = loginUser.Id,
                    UserName = loginUser.UserName,
                    Pwd = loginUser.Pwd,
                    UnitInfoId = loginUser.UnitInfoId,
                    UnitName = UnitInfoService.AsNoTrackingGetEntities(u=>u.Id==loginUser.UnitInfoId).Select(u=>u.UnitName).FirstOrDefault(),
                    RoleInfo = loginUser.RoleInfo
                };
                this.DialogResult= DialogResult.OK;
            }
            else
            {
                MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnRCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void lnkLabRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegisterFrm userRegister = new UserRegisterFrm();
            userRegister.ShowDialog();
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //在密码框中按回车键
            if (e.KeyChar == '\r')
            {
                btnLogin.PerformClick();
            }
        }

    }
}
