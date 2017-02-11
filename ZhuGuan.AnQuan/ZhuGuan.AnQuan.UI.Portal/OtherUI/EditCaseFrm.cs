using System;
using System.Linq;
using System.Windows.Forms;
using ZhuGuan.AnQuan.IBLL;
using ZhuGuan.AnQuan.Model;

namespace ZhuGuan.AnQuan.UI.Portal.OtherUI
{
    public partial class EditCaseFrm :BaseFrm
    {
        ICaseAnalysisInfoService CaseAnalysisInfoService;
        public event Action InvokeInitCase;
        private int Flag;
        private int Id;
        /// <summary>
        /// 打开编辑窗口，1是修改，0是添加
        /// </summary>
        /// <param name="flag"></param>
        public EditCaseFrm(int flag)
        {
            InitializeComponent();
            Flag = flag;
            if (Flag == 1)
            {
                Text = "修改事故案例信息";
            }
            if (Flag == 0)
            {
                Text = "添加事故案例信息";
            }
        }

        private void AddNewCaseFrm_Load(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Maximized;
            CaseAnalysisInfoService = ServiceSession.CaseAnalysisInfoService;

            if (Flag == 0)
            {
                return;
            }
            var entity =
                CaseAnalysisInfoService.AsNoTrackingGetEntities(c => c.DelFlag == 1)
                    .OrderByDescending(c => c.Id)
                    .FirstOrDefault();
            if (entity != null)
            {
                InitTxt(entity);
            }
        }

        private void InitTxt(CaseAnalysisInfo entity)
        {
            Id = entity.Id;
            txtTitle.Text = entity.Title;
            rtxtContent.Text = entity.Content;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text.Trim()) || string.IsNullOrEmpty(rtxtContent.Text.Trim()))
            {
                MessageBox.Show("内容和标题，不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CaseAnalysisInfo caseAnalysisInfo= new CaseAnalysisInfo();
            caseAnalysisInfo.Title = txtTitle.Text;
            caseAnalysisInfo.Content = rtxtContent.Text;
            caseAnalysisInfo.SubTime = DateTime.Now.Date;


            if (Flag == 0)
            {
                CaseAnalysisInfoService.Add(caseAnalysisInfo);
            }
            if (Flag == 1)
            {
                caseAnalysisInfo.Id = Id;
                CaseAnalysisInfoService.Update(caseAnalysisInfo);
            }
            InvokeInitCase();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
