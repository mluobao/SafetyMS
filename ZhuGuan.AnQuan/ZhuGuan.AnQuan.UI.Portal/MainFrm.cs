using System;
using System.Linq;
using System.Windows.Forms;
using ZhuGuan.AnQuan.Common;
using ZhuGuan.AnQuan.IBLL;
using ZhuGuan.AnQuan.UI.Portal.AccidentInfoUI;
using ZhuGuan.AnQuan.UI.Portal.HiddenDangerInfoUI;
using ZhuGuan.AnQuan.UI.Portal.OtherUI;
using ZhuGuan.AnQuan.UI.Portal.TeamInfoUI;
using ZhuGuan.AnQuan.UI.Portal.UnitInfoUI;
using ZhuGuan.AnQuan.UI.Portal.UserInfoUI;

namespace ZhuGuan.AnQuan.UI.Portal
{
    public partial class MainFrm : BaseFrm
    {
        private ICaseAnalysisInfoService CaseAnalysisInfoService;
        private int CaseId;
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            LoginFrm loginFrm = new LoginFrm();
            if (loginFrm.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
            
            var roleNames = AppCommon.CurrentLoginUser.RoleInfo.Select(r => r.RoleName).ToList();
            if (!(roleNames.Contains("管理员") || roleNames.Contains("事业部领导") || roleNames.Contains("安全主管") ||
                roleNames.Contains("安全办")))
            {
                MeunsVisibleSet();
                labTip.Visible = false;
            }
            else
            {
                IUserInfoService UserInfoService = ServiceSession.UserInfoService;
                var registerCount = UserInfoService.AsNoTrackingGetEntities(u => u.IsVerified == 0 && u.DelFlag==1).ToList().Count;
                labTip.Text = "有 " + registerCount + " 个新注册用户";
                timerLabTip.Enabled = true;
            }
            tSSLabLoginUser.Text = AppCommon.CurrentLoginUser.UserName;
            tssLabUnit.Text = AppCommon.CurrentLoginUser.UnitName;
            WindowState=FormWindowState.Maximized;
            InitCase();
        }

        private void InitCase()
        {
            CaseAnalysisInfoService = ServiceSession.CaseAnalysisInfoService;
            var entity =
                CaseAnalysisInfoService.AsNoTrackingGetEntities(c => c.DelFlag == 1)
                    .OrderByDescending(c => c.Id)
                    .FirstOrDefault();
            if (entity == null)
            {
                labTitle.Text = "这里是标题";
                rtxtContent.Text = "";
                return;
            }
            labTitle.Text = entity.Title + "(" + entity.SubTime.ToString("yyyy-MM-dd") + ")";
            rtxtContent.Text = entity.Content;
            CaseId = entity.Id;
        }

        private void MeunsVisibleSet()
        {
            tssepUserInfo.Visible = false;
            tssepUnitInfo.Visible = false;
            tssepTeamInfo.Visible = false;

            tsbtnUserInfo.Visible = false;
            tsbtnUnitInfo.Visible = false;
            tsbtnTeamInfo.Visible = false;

            btnEdit.Visible = false;
        }

        private void tsbtnHiddenDangerInfo_Click(object sender, EventArgs e)
        {
            HiddenDangerInfoListFrm hiddenDangerInfo = StaticFormFactory.GetHiddenDangerInfoListFrm();
            hiddenDangerInfo.Show();
            hiddenDangerInfo.Focus();
        }

        private void tsbtnAccidentInfo_Click(object sender, EventArgs e)
        {
            AccidentInfoListFrm accidentInfo = StaticFormFactory.GetAccidentInfoListFrm();
            accidentInfo.Show();
            accidentInfo.Focus();
        }

        private void tsbtnModifyPwd_Click(object sender, EventArgs e)
        {
            ModifyPwdFrm modifyPwd=new ModifyPwdFrm();
            modifyPwd.ShowDialog();
        }

        private void tsbtnUserInfo_Click(object sender, EventArgs e)
        {
            UserInfoListFrm userInfo = StaticFormFactory.GetUserInfoListFrm();
            userInfo.Show();
            userInfo.Focus();
        }

        private void tsbtnUnitInfo_Click(object sender, EventArgs e)
        {
            //单位信息
            UnitInfoListFrm unitInfo = StaticFormFactory.GetUnitInfoListFrm();
            unitInfo.Show();
            unitInfo.Focus();
        }

        private void tsbtnTeamInfo_Click(object sender, EventArgs e)
        {
            //班组信息
            TeamInfoListFrm teamInfo = StaticFormFactory.GeTeamInfoListFrm();
            teamInfo.Show();
            teamInfo.Focus();
        }

        private void tsbtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labTip.Visible = false;
            timerLabTip.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //修改
            if (string.IsNullOrEmpty(rtxtContent.Text.Trim()))
            {
                return;
            }
            EditCaseFrm editCaseFrm = new EditCaseFrm(1);
            editCaseFrm.InvokeInitCase += InitCase;
            editCaseFrm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //添加
            EditCaseFrm editCaseFrm = new EditCaseFrm(0);
            editCaseFrm.InvokeInitCase += InitCase;
            editCaseFrm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtxtContent.Text.Trim()))
            {
                return;
            }
            if (CaseAnalysisInfoService.Delete(CaseId))
            {
                InitCase();
            }
        }
    }
}
