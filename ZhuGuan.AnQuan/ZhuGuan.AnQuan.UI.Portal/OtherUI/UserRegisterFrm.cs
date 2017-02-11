using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ZhuGuan.AnQuan.IBLL;
using ZhuGuan.AnQuan.Model;
using ZhuGuan.AnQuan.Model.Enum;

namespace ZhuGuan.AnQuan.UI.Portal.OtherUI
{
    public partial class UserRegisterFrm : BaseFrm
    {
        private IUserInfoService UserInfoService;
        public UserRegisterFrm()
        {
            InitializeComponent();
        }

        private void UserRegisterFrm_Load(object sender, EventArgs e)
        {
            IUnitInfoService UnitInfoService = ServiceSession.UnitInfoService;
            UserInfoService = ServiceSession.UserInfoService;
            //添加单位
            var unitEntities = UnitInfoService.AsNoTrackingGetEntities(u => u.IsInspUnit == 1 && u.DelFlag == (short)DelFlagEnum.Normal)
                .Select(u => new { u.Id, u.UnitName }).ToList();
            cbxUnit.DisplayMember = "UnitName";
            cbxUnit.ValueMember = "Id";
            cbxUnit.DataSource = unitEntities;
            cbxUnit.SelectedIndex = -1;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string unitName = cbxUnit.Text.Trim();
            string userName = txtUserName.Text.Trim();
            string pwd = txtPwd.Text.Trim();
            string remark = txtRemark.Text.Trim();
            if (string.IsNullOrEmpty(unitName) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("单位、用户名、密码均不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int unitId = int.Parse(cbxUnit.SelectedValue.ToString().Trim());
            var hadUser = UserInfoService.AsNoTrackingGetEntities(u => u.UserName == userName).Select(u => u.UserName).FirstOrDefault();
            if (!string.IsNullOrEmpty(hadUser))
            {
                MessageBox.Show("该用户已经存在，如果忘记密码请联系安全主管！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var newUser= new UserInfo()
            {
                UnitName = unitName,
                UnitInfoId = unitId,
                UserName = userName,
                Pwd=pwd,
                Remark = remark,
                DelFlag = 1,
                IsVerified = 0
            };
            var addResult = UserInfoService.Add(newUser);

            if(addResult!=null)
            {
                UserInfoService.SetRole(addResult.Id, new List<string>() {"责任单位"});
                MessageBox.Show("注册成功，请提醒或等待安全主管审核！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
