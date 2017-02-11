namespace ZhuGuan.AnQuan.UI.Portal.HiddenDangerInfoUI
{
    partial class HiddenDangerInfoListFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HiddenDangerInfoListFrm));
            this.gbxOperate = new System.Windows.Forms.GroupBox();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.cbxIsAchieved = new System.Windows.Forms.ComboBox();
            this.cbxLevel = new System.Windows.Forms.ComboBox();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.cbxZrbz = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxZrdw = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxInspUnit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.SelectStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HDId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InspDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InspUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HidProblem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReformMeasure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zrdw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zrbz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AchievedDesp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReasonNotCompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TraceMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tStrip = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnModify = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnModifyZrInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnQuit = new System.Windows.Forms.ToolStripButton();
            this.gbxOperate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.tStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxOperate
            // 
            this.gbxOperate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxOperate.Controls.Add(this.chkSelectAll);
            this.gbxOperate.Controls.Add(this.cbxIsAchieved);
            this.gbxOperate.Controls.Add(this.cbxLevel);
            this.gbxOperate.Controls.Add(this.cbxClass);
            this.gbxOperate.Controls.Add(this.cbxZrbz);
            this.gbxOperate.Controls.Add(this.label8);
            this.gbxOperate.Controls.Add(this.cbxZrdw);
            this.gbxOperate.Controls.Add(this.label7);
            this.gbxOperate.Controls.Add(this.cbxInspUnit);
            this.gbxOperate.Controls.Add(this.label6);
            this.gbxOperate.Controls.Add(this.dtpEndDate);
            this.gbxOperate.Controls.Add(this.label5);
            this.gbxOperate.Controls.Add(this.dtpStartDate);
            this.gbxOperate.Controls.Add(this.label4);
            this.gbxOperate.Controls.Add(this.label2);
            this.gbxOperate.Controls.Add(this.label3);
            this.gbxOperate.Controls.Add(this.label1);
            this.gbxOperate.Controls.Add(this.btnSearch);
            this.gbxOperate.Location = new System.Drawing.Point(20, 34);
            this.gbxOperate.Name = "gbxOperate";
            this.gbxOperate.Size = new System.Drawing.Size(969, 90);
            this.gbxOperate.TabIndex = 0;
            this.gbxOperate.TabStop = false;
            this.gbxOperate.Text = "数据操作";
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(901, 24);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(48, 16);
            this.chkSelectAll.TabIndex = 4;
            this.chkSelectAll.Text = "全选";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // cbxIsAchieved
            // 
            this.cbxIsAchieved.FormattingEnabled = true;
            this.cbxIsAchieved.Items.AddRange(new object[] {
            "未整改",
            "已整改"});
            this.cbxIsAchieved.Location = new System.Drawing.Point(820, 53);
            this.cbxIsAchieved.Name = "cbxIsAchieved";
            this.cbxIsAchieved.Size = new System.Drawing.Size(60, 20);
            this.cbxIsAchieved.TabIndex = 3;
            // 
            // cbxLevel
            // 
            this.cbxLevel.FormattingEnabled = true;
            this.cbxLevel.Items.AddRange(new object[] {
            "A：重大安全隐患",
            "B：较大安全隐患",
            "C：一般安全隐患",
            "D：较小安全隐患"});
            this.cbxLevel.Location = new System.Drawing.Point(696, 53);
            this.cbxLevel.Name = "cbxLevel";
            this.cbxLevel.Size = new System.Drawing.Size(116, 20);
            this.cbxLevel.TabIndex = 3;
            // 
            // cbxClass
            // 
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Items.AddRange(new object[] {
            "A：人的不安全行为",
            "B：物的不安全状态",
            "C：安全基础管理"});
            this.cbxClass.Location = new System.Drawing.Point(559, 53);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(129, 20);
            this.cbxClass.TabIndex = 3;
            // 
            // cbxZrbz
            // 
            this.cbxZrbz.FormattingEnabled = true;
            this.cbxZrbz.Location = new System.Drawing.Point(461, 53);
            this.cbxZrbz.Name = "cbxZrbz";
            this.cbxZrbz.Size = new System.Drawing.Size(90, 20);
            this.cbxZrbz.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(818, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "完成情况：";
            // 
            // cbxZrdw
            // 
            this.cbxZrdw.FormattingEnabled = true;
            this.cbxZrdw.Location = new System.Drawing.Point(353, 53);
            this.cbxZrdw.Name = "cbxZrdw";
            this.cbxZrdw.Size = new System.Drawing.Size(100, 20);
            this.cbxZrdw.TabIndex = 3;
            this.cbxZrdw.SelectedIndexChanged += new System.EventHandler(this.cbxZrdw_SelectedIndexChanged);
            this.cbxZrdw.SelectedValueChanged += new System.EventHandler(this.cbxZrdw_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(696, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "风险等级：";
            // 
            // cbxInspUnit
            // 
            this.cbxInspUnit.FormattingEnabled = true;
            this.cbxInspUnit.Location = new System.Drawing.Point(245, 53);
            this.cbxInspUnit.Name = "cbxInspUnit";
            this.cbxInspUnit.Size = new System.Drawing.Size(100, 20);
            this.cbxInspUnit.TabIndex = 3;
            this.cbxInspUnit.SelectedIndexChanged += new System.EventHandler(this.cbxZrdw_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(562, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "问题分类：";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(134, 53);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(105, 21);
            this.dtpEndDate.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "责任班组：";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(6, 53);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(105, 21);
            this.dtpStartDate.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "责任单位：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "—";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "检查单位：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "检查日期：";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(901, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 20);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvList
            // 
            this.dgvList.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectStatus,
            this.HDId,
            this.InspDate,
            this.InspUnit,
            this.HidProblem,
            this.ReformMeasure,
            this.Class2,
            this.Level2,
            this.PreTime,
            this.Zrdw,
            this.Zrbz,
            this.AchievedDesp,
            this.ReasonNotCompleted,
            this.TraceMan,
            this.Remark});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.GridColor = System.Drawing.Color.Black;
            this.dgvList.Location = new System.Drawing.Point(20, 130);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(969, 500);
            this.dgvList.TabIndex = 1;
            // 
            // SelectStatus
            // 
            this.SelectStatus.FalseValue = "0";
            this.SelectStatus.HeaderText = "选择";
            this.SelectStatus.IndeterminateValue = "0";
            this.SelectStatus.Name = "SelectStatus";
            this.SelectStatus.TrueValue = "1";
            this.SelectStatus.Width = 50;
            // 
            // HDId
            // 
            this.HDId.DataPropertyName = "HDId";
            this.HDId.HeaderText = "编号";
            this.HDId.Name = "HDId";
            this.HDId.ReadOnly = true;
            this.HDId.Visible = false;
            // 
            // InspDate
            // 
            this.InspDate.DataPropertyName = "InspDate";
            this.InspDate.HeaderText = "检查日期";
            this.InspDate.Name = "InspDate";
            this.InspDate.ReadOnly = true;
            this.InspDate.Width = 80;
            // 
            // InspUnit
            // 
            this.InspUnit.DataPropertyName = "InspUnit";
            this.InspUnit.HeaderText = "检查单位";
            this.InspUnit.Name = "InspUnit";
            this.InspUnit.ReadOnly = true;
            this.InspUnit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.InspUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HidProblem
            // 
            this.HidProblem.DataPropertyName = "HidProblem";
            this.HidProblem.HeaderText = "隐患问题";
            this.HidProblem.Name = "HidProblem";
            this.HidProblem.ReadOnly = true;
            // 
            // ReformMeasure
            // 
            this.ReformMeasure.DataPropertyName = "ReformMeasure";
            this.ReformMeasure.HeaderText = "整改防范措施";
            this.ReformMeasure.Name = "ReformMeasure";
            this.ReformMeasure.Width = 120;
            // 
            // Class2
            // 
            this.Class2.DataPropertyName = "Class2";
            this.Class2.HeaderText = "问题分类";
            this.Class2.Name = "Class2";
            this.Class2.Width = 120;
            // 
            // Level2
            // 
            this.Level2.DataPropertyName = "Level2";
            this.Level2.HeaderText = "风险等级";
            this.Level2.Name = "Level2";
            this.Level2.Width = 120;
            // 
            // PreTime
            // 
            this.PreTime.DataPropertyName = "PreTime";
            this.PreTime.HeaderText = "预计完成时间";
            this.PreTime.Name = "PreTime";
            this.PreTime.ReadOnly = true;
            this.PreTime.Width = 75;
            // 
            // Zrdw
            // 
            this.Zrdw.DataPropertyName = "Zrdw";
            this.Zrdw.HeaderText = "责任单位";
            this.Zrdw.Name = "Zrdw";
            this.Zrdw.ReadOnly = true;
            this.Zrdw.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Zrdw.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Zrbz
            // 
            this.Zrbz.DataPropertyName = "Zrbz";
            this.Zrbz.HeaderText = "责任班组";
            this.Zrbz.Name = "Zrbz";
            this.Zrbz.ReadOnly = true;
            this.Zrbz.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Zrbz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AchievedDesp
            // 
            this.AchievedDesp.DataPropertyName = "AchievedDesp";
            this.AchievedDesp.HeaderText = "整改完成情况";
            this.AchievedDesp.Name = "AchievedDesp";
            this.AchievedDesp.Width = 75;
            // 
            // ReasonNotCompleted
            // 
            this.ReasonNotCompleted.DataPropertyName = "ReasonNotCompleted";
            this.ReasonNotCompleted.HeaderText = "到期未整改原因";
            this.ReasonNotCompleted.Name = "ReasonNotCompleted";
            this.ReasonNotCompleted.Width = 120;
            // 
            // TraceMan
            // 
            this.TraceMan.DataPropertyName = "TraceMan";
            this.TraceMan.HeaderText = "录入人";
            this.TraceMan.Name = "TraceMan";
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            // 
            // tStrip
            // 
            this.tStrip.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.toolStripSeparator1,
            this.tsbtnModify,
            this.toolStripSeparator2,
            this.tsbtnDelete,
            this.toolStripSeparator5,
            this.tsbtnModifyZrInfo,
            this.toolStripSeparator3,
            this.tsbtnExport,
            this.toolStripSeparator4,
            this.tsbtnQuit});
            this.tStrip.Location = new System.Drawing.Point(0, 0);
            this.tStrip.Name = "tStrip";
            this.tStrip.Size = new System.Drawing.Size(1008, 29);
            this.tStrip.TabIndex = 2;
            this.tStrip.Text = "toolStrip1";
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAdd.Image")));
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(46, 26);
            this.tsbtnAdd.Text = "添加";
            this.tsbtnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // tsbtnModify
            // 
            this.tsbtnModify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnModify.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnModify.Image")));
            this.tsbtnModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnModify.Name = "tsbtnModify";
            this.tsbtnModify.Size = new System.Drawing.Size(110, 26);
            this.tsbtnModify.Text = "修改录入信息";
            this.tsbtnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelete.Image")));
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(46, 26);
            this.tsbtnDelete.Text = "删除";
            this.tsbtnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 29);
            // 
            // tsbtnModifyZrInfo
            // 
            this.tsbtnModifyZrInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnModifyZrInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnModifyZrInfo.Image")));
            this.tsbtnModifyZrInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnModifyZrInfo.Name = "tsbtnModifyZrInfo";
            this.tsbtnModifyZrInfo.Size = new System.Drawing.Size(110, 26);
            this.tsbtnModifyZrInfo.Text = "修改责任信息";
            this.tsbtnModifyZrInfo.Click += new System.EventHandler(this.tsbtnModifyZrInfo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 29);
            // 
            // tsbtnExport
            // 
            this.tsbtnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExport.Image")));
            this.tsbtnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExport.Name = "tsbtnExport";
            this.tsbtnExport.Size = new System.Drawing.Size(78, 26);
            this.tsbtnExport.Text = "导出表格";
            this.tsbtnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 29);
            // 
            // tsbtnQuit
            // 
            this.tsbtnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnQuit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnQuit.Image")));
            this.tsbtnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnQuit.Name = "tsbtnQuit";
            this.tsbtnQuit.Size = new System.Drawing.Size(46, 26);
            this.tsbtnQuit.Text = "退出";
            this.tsbtnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // HiddenDangerInfoListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 642);
            this.Controls.Add(this.tStrip);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.gbxOperate);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "HiddenDangerInfoListFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "隐患整改信息";
            this.Load += new System.EventHandler(this.HiddenDangerInfoListFrm_Load);
            this.gbxOperate.ResumeLayout(false);
            this.gbxOperate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.tStrip.ResumeLayout(false);
            this.tStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOperate;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbxLevel;
        private System.Windows.Forms.ComboBox cbxClass;
        private System.Windows.Forms.ComboBox cbxZrbz;
        private System.Windows.Forms.ComboBox cbxZrdw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxInspUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.ToolStrip tStrip;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnModify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnQuit;
        private System.Windows.Forms.ComboBox cbxIsAchieved;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbtnModifyZrInfo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDId;
        private System.Windows.Forms.DataGridViewTextBoxColumn InspDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InspUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn HidProblem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReformMeasure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zrdw;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zrbz;
        private System.Windows.Forms.DataGridViewTextBoxColumn AchievedDesp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReasonNotCompleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn TraceMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
    }
}