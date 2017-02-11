using System;
using System.Linq;
using System.Windows.Forms;
using ZhuGuan.AnQuan.Common;
using ZhuGuan.AnQuan.IBLL;

namespace ZhuGuan.AnQuan.UI.Portal.OtherUI
{
    public partial class ModifyPwdFrm : BaseFrm
    {
        public ModifyPwdFrm()
        {
            InitializeComponent();
        }

        private void ModifyPwdFrm_Load(object sender, EventArgs e)
        {
            labTip.Text = "请为【" + AppCommon.CurrentLoginUser.UserName + "】设置新密码：";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string oldPwd = txtOldPwd.Text.Trim();
            string newPwd = txtNewPwd.Text.Trim();
            if (string.IsNullOrEmpty(oldPwd) || string.IsNullOrEmpty(newPwd))
            {
                MessageBox.Show("原密码和新密码都不能为空，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (oldPwd != AppCommon.CurrentLoginUser.Pwd)
            {
                MessageBox.Show("原密码不正确，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            IUserInfoService UserInfoService = ServiceSession.UserInfoService;
            var entity = UserInfoService.AsNoTrackingGetEntities(u => u.Id == AppCommon.CurrentLoginUser.Id).FirstOrDefault();
            entity.Pwd = newPwd;
            if (UserInfoService.Update(entity))
            {
                AppCommon.CurrentLoginUser.Pwd = newPwd;
                MessageBox.Show("密码修改成功，下次请使用新密码登录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
