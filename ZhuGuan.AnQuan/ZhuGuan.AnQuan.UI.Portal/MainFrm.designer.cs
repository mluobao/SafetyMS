namespace ZhuGuan.AnQuan.UI.Portal
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.tStrip = new System.Windows.Forms.ToolStrip();
            this.tssepHiddenDangerInfo = new System.Windows.Forms.ToolStripSeparator();
            this.tssepAccidentInfo = new System.Windows.Forms.ToolStripSeparator();
            this.tssepUserInfo = new System.Windows.Forms.ToolStripSeparator();
            this.tssepUnitInfo = new System.Windows.Forms.ToolStripSeparator();
            this.tssepTeamInfo = new System.Windows.Forms.ToolStripSeparator();
            this.tssepQuit = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.labTip = new System.Windows.Forms.Label();
            this.splitContainerContent = new System.Windows.Forms.SplitContainer();
            this.btnHiddenDangerInfo = new System.Windows.Forms.Button();
            this.btnAccidentInfo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.labTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sStrip = new System.Windows.Forms.StatusStrip();
            this.tSSLabLoginUser1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLabLoginUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLabUnit1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLabUnit = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerLabTip = new System.Windows.Forms.Timer(this.components);
            this.tsbtnHiddenDangerInfo = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAccidentInfo = new System.Windows.Forms.ToolStripButton();
            this.tsbtnModifyPwd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUserInfo = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUnitInfo = new System.Windows.Forms.ToolStripButton();
            this.tsbtnTeamInfo = new System.Windows.Forms.ToolStripButton();
            this.tsbtnQuit = new System.Windows.Forms.ToolStripButton();
            this.tStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerContent)).BeginInit();
            this.splitContainerContent.Panel1.SuspendLayout();
            this.splitContainerContent.Panel2.SuspendLayout();
            this.splitContainerContent.SuspendLayout();
            this.sStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tStrip
            // 
            this.tStrip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnHiddenDangerInfo,
            this.tssepHiddenDangerInfo,
            this.tsbtnAccidentInfo,
            this.tssepAccidentInfo,
            this.tsbtnModifyPwd,
            this.tssepUserInfo,
            this.tsbtnUserInfo,
            this.tssepUnitInfo,
            this.tsbtnUnitInfo,
            this.tssepTeamInfo,
            this.tsbtnTeamInfo,
            this.tssepQuit,
            this.tsbtnQuit});
            this.tStrip.Location = new System.Drawing.Point(0, 0);
            this.tStrip.Name = "tStrip";
            this.tStrip.Size = new System.Drawing.Size(1008, 26);
            this.tStrip.TabIndex = 1;
            this.tStrip.Text = "tStrip";
            // 
            // tssepHiddenDangerInfo
            // 
            this.tssepHiddenDangerInfo.Name = "tssepHiddenDangerInfo";
            this.tssepHiddenDangerInfo.Size = new System.Drawing.Size(6, 26);
            // 
            // tssepAccidentInfo
            // 
            this.tssepAccidentInfo.Name = "tssepAccidentInfo";
            this.tssepAccidentInfo.Size = new System.Drawing.Size(6, 26);
            // 
            // tssepUserInfo
            // 
            this.tssepUserInfo.Name = "tssepUserInfo";
            this.tssepUserInfo.Size = new System.Drawing.Size(6, 26);
            // 
            // tssepUnitInfo
            // 
            this.tssepUnitInfo.Name = "tssepUnitInfo";
            this.tssepUnitInfo.Size = new System.Drawing.Size(6, 26);
            // 
            // tssepTeamInfo
            // 
            this.tssepTeamInfo.Name = "tssepTeamInfo";
            this.tssepTeamInfo.Size = new System.Drawing.Size(6, 26);
            // 
            // tssepQuit
            // 
            this.tssepQuit.Name = "tssepQuit";
            this.tssepQuit.Size = new System.Drawing.Size(6, 26);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.IsSplitterFixed = true;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 26);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.BackgroundImage = global::ZhuGuan.AnQuan.UI.Portal.Properties.Resources.aqheader;
            this.splitContainerMain.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainerMain.Panel1.Controls.Add(this.labTip);
            this.splitContainerMain.Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerContent);
            this.splitContainerMain.Panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.splitContainerMain.Size = new System.Drawing.Size(1008, 616);
            this.splitContainerMain.SplitterDistance = 222;
            this.splitContainerMain.TabIndex = 2;
            // 
            // labTip
            // 
            this.labTip.AutoSize = true;
            this.labTip.BackColor = System.Drawing.Color.Transparent;
            this.labTip.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTip.ForeColor = System.Drawing.SystemColors.Info;
            this.labTip.Location = new System.Drawing.Point(9, 9);
            this.labTip.Name = "labTip";
            this.labTip.Size = new System.Drawing.Size(145, 17);
            this.labTip.TabIndex = 0;
            this.labTip.Text = "有 0 个新注册用户";
            // 
            // splitContainerContent
            // 
            this.splitContainerContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerContent.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerContent.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.splitContainerContent.IsSplitterFixed = true;
            this.splitContainerContent.Location = new System.Drawing.Point(0, 0);
            this.splitContainerContent.Name = "splitContainerContent";
            // 
            // splitContainerContent.Panel1
            // 
            this.splitContainerContent.Panel1.Controls.Add(this.btnHiddenDangerInfo);
            this.splitContainerContent.Panel1.Controls.Add(this.btnAccidentInfo);
            // 
            // splitContainerContent.Panel2
            // 
            this.splitContainerContent.Panel2.Controls.Add(this.btnDelete);
            this.splitContainerContent.Panel2.Controls.Add(this.rtxtContent);
            this.splitContainerContent.Panel2.Controls.Add(this.labTitle);
            this.splitContainerContent.Panel2.Controls.Add(this.label1);
            this.splitContainerContent.Panel2.Controls.Add(this.btnAdd);
            this.splitContainerContent.Panel2.Controls.Add(this.btnEdit);
            this.splitContainerContent.Panel2.Controls.Add(this.label2);
            this.splitContainerContent.Size = new System.Drawing.Size(1008, 390);
            this.splitContainerContent.SplitterDistance = 225;
            this.splitContainerContent.TabIndex = 3;
            // 
            // btnHiddenDangerInfo
            // 
            this.btnHiddenDangerInfo.Location = new System.Drawing.Point(15, 42);
            this.btnHiddenDangerInfo.Margin = new System.Windows.Forms.Padding(15);
            this.btnHiddenDangerInfo.Name = "btnHiddenDangerInfo";
            this.btnHiddenDangerInfo.Size = new System.Drawing.Size(80, 80);
            this.btnHiddenDangerInfo.TabIndex = 1;
            this.btnHiddenDangerInfo.Text = "隐患信息";
            this.btnHiddenDangerInfo.UseVisualStyleBackColor = true;
            this.btnHiddenDangerInfo.Click += new System.EventHandler(this.tsbtnHiddenDangerInfo_Click);
            // 
            // btnAccidentInfo
            // 
            this.btnAccidentInfo.Location = new System.Drawing.Point(125, 42);
            this.btnAccidentInfo.Margin = new System.Windows.Forms.Padding(15);
            this.btnAccidentInfo.Name = "btnAccidentInfo";
            this.btnAccidentInfo.Size = new System.Drawing.Size(80, 80);
            this.btnAccidentInfo.TabIndex = 2;
            this.btnAccidentInfo.Text = "事故信息";
            this.btnAccidentInfo.UseVisualStyleBackColor = true;
            this.btnAccidentInfo.Click += new System.EventHandler(this.tsbtnAccidentInfo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(650, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "删除当前内容";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rtxtContent
            // 
            this.rtxtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtContent.Location = new System.Drawing.Point(14, 56);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(748, 306);
            this.rtxtContent.TabIndex = 14;
            this.rtxtContent.Text = "";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.ForeColor = System.Drawing.Color.Blue;
            this.labTitle.Location = new System.Drawing.Point(237, 30);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(77, 14);
            this.labTitle.TabIndex = 13;
            this.labTitle.Text = "这里是标题";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = "标题：";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(550, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "添加新内容";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(454, 26);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "编辑内容";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(14, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "【过往事故案例分析】";
            // 
            // sStrip
            // 
            this.sStrip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSLabLoginUser1,
            this.tSSLabLoginUser,
            this.toolStripStatusLabel1,
            this.tssLabUnit1,
            this.tssLabUnit});
            this.sStrip.Location = new System.Drawing.Point(0, 617);
            this.sStrip.Name = "sStrip";
            this.sStrip.Size = new System.Drawing.Size(1008, 25);
            this.sStrip.TabIndex = 3;
            this.sStrip.Text = "statusStrip1";
            // 
            // tSSLabLoginUser1
            // 
            this.tSSLabLoginUser1.Name = "tSSLabLoginUser1";
            this.tSSLabLoginUser1.Size = new System.Drawing.Size(107, 20);
            this.tSSLabLoginUser1.Text = "当前登录用户：";
            // 
            // tSSLabLoginUser
            // 
            this.tSSLabLoginUser.Name = "tSSLabLoginUser";
            this.tSSLabLoginUser.Size = new System.Drawing.Size(57, 20);
            this.tSSLabLoginUser.Text = "luobao";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(21, 20);
            this.toolStripStatusLabel1.Text = "&&";
            // 
            // tssLabUnit1
            // 
            this.tssLabUnit1.Name = "tssLabUnit1";
            this.tssLabUnit1.Size = new System.Drawing.Size(79, 20);
            this.tssLabUnit1.Text = "所属单位：";
            // 
            // tssLabUnit
            // 
            this.tssLabUnit.Name = "tssLabUnit";
            this.tssLabUnit.Size = new System.Drawing.Size(107, 20);
            this.tssLabUnit.Text = "铸管部职能部室";
            // 
            // timerLabTip
            // 
            this.timerLabTip.Interval = 10000;
            this.timerLabTip.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tsbtnHiddenDangerInfo
            // 
            this.tsbtnHiddenDangerInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnHiddenDangerInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnHiddenDangerInfo.Image")));
            this.tsbtnHiddenDangerInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnHiddenDangerInfo.Name = "tsbtnHiddenDangerInfo";
            this.tsbtnHiddenDangerInfo.Size = new System.Drawing.Size(69, 23);
            this.tsbtnHiddenDangerInfo.Text = "隐患信息";
            this.tsbtnHiddenDangerInfo.Click += new System.EventHandler(this.tsbtnHiddenDangerInfo_Click);
            // 
            // tsbtnAccidentInfo
            // 
            this.tsbtnAccidentInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnAccidentInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAccidentInfo.Image")));
            this.tsbtnAccidentInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAccidentInfo.Name = "tsbtnAccidentInfo";
            this.tsbtnAccidentInfo.Size = new System.Drawing.Size(69, 23);
            this.tsbtnAccidentInfo.Text = "事故信息";
            this.tsbtnAccidentInfo.Click += new System.EventHandler(this.tsbtnAccidentInfo_Click);
            // 
            // tsbtnModifyPwd
            // 
            this.tsbtnModifyPwd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnModifyPwd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnModifyPwd.Image")));
            this.tsbtnModifyPwd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnModifyPwd.Name = "tsbtnModifyPwd";
            this.tsbtnModifyPwd.Size = new System.Drawing.Size(69, 23);
            this.tsbtnModifyPwd.Text = "修改密码";
            this.tsbtnModifyPwd.Click += new System.EventHandler(this.tsbtnModifyPwd_Click);
            // 
            // tsbtnUserInfo
            // 
            this.tsbtnUserInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnUserInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUserInfo.Image")));
            this.tsbtnUserInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUserInfo.Name = "tsbtnUserInfo";
            this.tsbtnUserInfo.Size = new System.Drawing.Size(69, 23);
            this.tsbtnUserInfo.Text = "用户管理";
            this.tsbtnUserInfo.Click += new System.EventHandler(this.tsbtnUserInfo_Click);
            // 
            // tsbtnUnitInfo
            // 
            this.tsbtnUnitInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnUnitInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUnitInfo.Image")));
            this.tsbtnUnitInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUnitInfo.Name = "tsbtnUnitInfo";
            this.tsbtnUnitInfo.Size = new System.Drawing.Size(69, 23);
            this.tsbtnUnitInfo.Text = "单位信息";
            this.tsbtnUnitInfo.Click += new System.EventHandler(this.tsbtnUnitInfo_Click);
            // 
            // tsbtnTeamInfo
            // 
            this.tsbtnTeamInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnTeamInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnTeamInfo.Image")));
            this.tsbtnTeamInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnTeamInfo.Name = "tsbtnTeamInfo";
            this.tsbtnTeamInfo.Size = new System.Drawing.Size(69, 23);
            this.tsbtnTeamInfo.Text = "班组信息";
            this.tsbtnTeamInfo.Click += new System.EventHandler(this.tsbtnTeamInfo_Click);
            // 
            // tsbtnQuit
            // 
            this.tsbtnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnQuit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnQuit.Image")));
            this.tsbtnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnQuit.Name = "tsbtnQuit";
            this.tsbtnQuit.Size = new System.Drawing.Size(69, 23);
            this.tsbtnQuit.Text = "关闭程序";
            this.tsbtnQuit.Click += new System.EventHandler(this.tsbtnQuit_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 642);
            this.Controls.Add(this.sStrip);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.tStrip);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.Text = "安全管理程序";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.tStrip.ResumeLayout(false);
            this.tStrip.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerContent.Panel1.ResumeLayout(false);
            this.splitContainerContent.Panel2.ResumeLayout(false);
            this.splitContainerContent.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerContent)).EndInit();
            this.splitContainerContent.ResumeLayout(false);
            this.sStrip.ResumeLayout(false);
            this.sStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tStrip;
        private System.Windows.Forms.ToolStripButton tsbtnHiddenDangerInfo;
        private System.Windows.Forms.ToolStripSeparator tssepHiddenDangerInfo;
        private System.Windows.Forms.ToolStripButton tsbtnAccidentInfo;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.ToolStripSeparator tssepAccidentInfo;
        private System.Windows.Forms.ToolStripSeparator tssepUserInfo;
        private System.Windows.Forms.ToolStripButton tsbtnUserInfo;
        private System.Windows.Forms.ToolStripSeparator tssepUnitInfo;
        private System.Windows.Forms.ToolStripButton tsbtnUnitInfo;
        private System.Windows.Forms.ToolStripSeparator tssepTeamInfo;
        private System.Windows.Forms.ToolStripButton tsbtnTeamInfo;
        private System.Windows.Forms.ToolStripSeparator tssepQuit;
        private System.Windows.Forms.ToolStripButton tsbtnQuit;
        private System.Windows.Forms.StatusStrip sStrip;
        private System.Windows.Forms.ToolStripStatusLabel tSSLabLoginUser1;
        private System.Windows.Forms.ToolStripStatusLabel tSSLabLoginUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssLabUnit1;
        private System.Windows.Forms.ToolStripStatusLabel tssLabUnit;
        private System.Windows.Forms.SplitContainer splitContainerContent;
        private System.Windows.Forms.Button btnHiddenDangerInfo;
        private System.Windows.Forms.Button btnAccidentInfo;
        private System.Windows.Forms.Label labTip;
        private System.Windows.Forms.Timer timerLabTip;
        private System.Windows.Forms.ToolStripButton tsbtnModifyPwd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RichTextBox rtxtContent;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label2;
    }
}