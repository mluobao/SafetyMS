namespace ZhuGuan.AnQuan.UI.Portal.HiddenDangerInfoUI
{
    partial class HiddenDangerInfoAddFrm
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
            this.dtpPreTime = new System.Windows.Forms.DateTimePicker();
            this.cbxLevel = new System.Windows.Forms.ComboBox();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.cbxZrbz = new System.Windows.Forms.ComboBox();
            this.cbxZrdw = new System.Windows.Forms.ComboBox();
            this.cbxInspUnit2 = new System.Windows.Forms.ComboBox();
            this.gbxOperate = new System.Windows.Forms.GroupBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxInspUnit = new System.Windows.Forms.ComboBox();
            this.labInspUnit = new System.Windows.Forms.Label();
            this.dtpInspDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAdd = new System.Windows.Forms.DataGridView();
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
            this.cbxIsAchieved = new System.Windows.Forms.ComboBox();
            this.gbxOperate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpPreTime
            // 
            this.dtpPreTime.Location = new System.Drawing.Point(618, 138);
            this.dtpPreTime.Name = "dtpPreTime";
            this.dtpPreTime.Size = new System.Drawing.Size(104, 21);
            this.dtpPreTime.TabIndex = 6;
            this.dtpPreTime.Visible = false;
            this.dtpPreTime.CloseUp += new System.EventHandler(this.dtpPreTime_ValueChanged);
            this.dtpPreTime.ValueChanged += new System.EventHandler(this.dtpPreTime_ValueChanged);
            // 
            // cbxLevel
            // 
            this.cbxLevel.FormattingEnabled = true;
            this.cbxLevel.Items.AddRange(new object[] {
            "A：重大安全隐患",
            "B：较大安全隐患",
            "C：一般安全隐患",
            "D：风险较低安全隐患"});
            this.cbxLevel.Location = new System.Drawing.Point(893, 139);
            this.cbxLevel.Name = "cbxLevel";
            this.cbxLevel.Size = new System.Drawing.Size(80, 20);
            this.cbxLevel.TabIndex = 5;
            this.cbxLevel.Visible = false;
            this.cbxLevel.SelectedIndexChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            this.cbxLevel.TextChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            // 
            // cbxClass
            // 
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Items.AddRange(new object[] {
            "A：人的不安全行为",
            "B：物的不安全状态",
            "C：安全基础管理"});
            this.cbxClass.Location = new System.Drawing.Point(807, 141);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(80, 20);
            this.cbxClass.TabIndex = 5;
            this.cbxClass.Visible = false;
            this.cbxClass.SelectedIndexChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            this.cbxClass.TextChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            // 
            // cbxZrbz
            // 
            this.cbxZrbz.FormattingEnabled = true;
            this.cbxZrbz.Location = new System.Drawing.Point(308, 140);
            this.cbxZrbz.Name = "cbxZrbz";
            this.cbxZrbz.Size = new System.Drawing.Size(80, 20);
            this.cbxZrbz.TabIndex = 5;
            this.cbxZrbz.Visible = false;
            this.cbxZrbz.SelectedIndexChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            this.cbxZrbz.TextChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            this.cbxZrbz.Enter += new System.EventHandler(this.cbxZrbz_Enter);
            // 
            // cbxZrdw
            // 
            this.cbxZrdw.FormattingEnabled = true;
            this.cbxZrdw.Location = new System.Drawing.Point(206, 140);
            this.cbxZrdw.Name = "cbxZrdw";
            this.cbxZrdw.Size = new System.Drawing.Size(80, 20);
            this.cbxZrdw.TabIndex = 5;
            this.cbxZrdw.Visible = false;
            this.cbxZrdw.SelectedIndexChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            this.cbxZrdw.TextChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            // 
            // cbxInspUnit2
            // 
            this.cbxInspUnit2.FormattingEnabled = true;
            this.cbxInspUnit2.Location = new System.Drawing.Point(106, 140);
            this.cbxInspUnit2.Name = "cbxInspUnit2";
            this.cbxInspUnit2.Size = new System.Drawing.Size(80, 20);
            this.cbxInspUnit2.TabIndex = 5;
            this.cbxInspUnit2.Visible = false;
            this.cbxInspUnit2.SelectedIndexChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            this.cbxInspUnit2.TextChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            // 
            // gbxOperate
            // 
            this.gbxOperate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxOperate.Controls.Add(this.btnQuit);
            this.gbxOperate.Controls.Add(this.btnSave);
            this.gbxOperate.Controls.Add(this.btnDelete);
            this.gbxOperate.Controls.Add(this.btnAdd);
            this.gbxOperate.Controls.Add(this.cbxInspUnit);
            this.gbxOperate.Controls.Add(this.labInspUnit);
            this.gbxOperate.Controls.Add(this.dtpInspDate);
            this.gbxOperate.Controls.Add(this.label1);
            this.gbxOperate.Location = new System.Drawing.Point(13, 13);
            this.gbxOperate.Name = "gbxOperate";
            this.gbxOperate.Size = new System.Drawing.Size(983, 81);
            this.gbxOperate.TabIndex = 0;
            this.gbxOperate.TabStop = false;
            this.gbxOperate.Text = "数据操作";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(595, 44);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(45, 23);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(526, 44);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(422, 44);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除当前行";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(318, 44);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "增加一行";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxInspUnit
            // 
            this.cbxInspUnit.FormattingEnabled = true;
            this.cbxInspUnit.Location = new System.Drawing.Point(144, 45);
            this.cbxInspUnit.Name = "cbxInspUnit";
            this.cbxInspUnit.Size = new System.Drawing.Size(120, 20);
            this.cbxInspUnit.TabIndex = 5;
            // 
            // labInspUnit
            // 
            this.labInspUnit.AutoSize = true;
            this.labInspUnit.Location = new System.Drawing.Point(144, 19);
            this.labInspUnit.Name = "labInspUnit";
            this.labInspUnit.Size = new System.Drawing.Size(65, 12);
            this.labInspUnit.TabIndex = 4;
            this.labInspUnit.Text = "检查单位：";
            // 
            // dtpInspDate
            // 
            this.dtpInspDate.Location = new System.Drawing.Point(25, 45);
            this.dtpInspDate.Name = "dtpInspDate";
            this.dtpInspDate.Size = new System.Drawing.Size(103, 21);
            this.dtpInspDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "检查日期：";
            // 
            // dgvAdd
            // 
            this.dgvAdd.AllowUserToAddRows = false;
            this.dgvAdd.AllowUserToDeleteRows = false;
            this.dgvAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdd.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvAdd.GridColor = System.Drawing.Color.Black;
            this.dgvAdd.Location = new System.Drawing.Point(13, 100);
            this.dgvAdd.Name = "dgvAdd";
            this.dgvAdd.RowHeadersVisible = false;
            this.dgvAdd.RowTemplate.Height = 23;
            this.dgvAdd.Size = new System.Drawing.Size(983, 529);
            this.dgvAdd.TabIndex = 1;
            this.dgvAdd.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdd_CellEnter);
            this.dgvAdd.CurrentCellChanged += new System.EventHandler(this.dgvAdd_CurrentCellChanged);
            // 
            // HDId
            // 
            this.HDId.DataPropertyName = "HDId";
            this.HDId.HeaderText = "编号";
            this.HDId.Name = "HDId";
            this.HDId.Visible = false;
            // 
            // InspDate
            // 
            this.InspDate.DataPropertyName = "InspDate";
            this.InspDate.HeaderText = "检查日期";
            this.InspDate.Name = "InspDate";
            this.InspDate.Width = 80;
            // 
            // InspUnit
            // 
            this.InspUnit.DataPropertyName = "InspUnit";
            this.InspUnit.HeaderText = "检查单位";
            this.InspUnit.Name = "InspUnit";
            // 
            // HidProblem
            // 
            this.HidProblem.DataPropertyName = "HidProblem";
            this.HidProblem.HeaderText = "隐患问题";
            this.HidProblem.Name = "HidProblem";
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
            this.PreTime.Width = 75;
            // 
            // Zrdw
            // 
            this.Zrdw.DataPropertyName = "Zrdw";
            this.Zrdw.HeaderText = "责任单位";
            this.Zrdw.Name = "Zrdw";
            // 
            // Zrbz
            // 
            this.Zrbz.DataPropertyName = "Zrbz";
            this.Zrbz.HeaderText = "责任班组";
            this.Zrbz.Name = "Zrbz";
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
            this.TraceMan.ReadOnly = true;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            // 
            // cbxIsAchieved
            // 
            this.cbxIsAchieved.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIsAchieved.FormattingEnabled = true;
            this.cbxIsAchieved.Items.AddRange(new object[] {
            "未整改",
            "已整改"});
            this.cbxIsAchieved.Location = new System.Drawing.Point(728, 139);
            this.cbxIsAchieved.Name = "cbxIsAchieved";
            this.cbxIsAchieved.Size = new System.Drawing.Size(72, 20);
            this.cbxIsAchieved.TabIndex = 5;
            this.cbxIsAchieved.Visible = false;
            this.cbxIsAchieved.SelectedIndexChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            this.cbxIsAchieved.TextChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            // 
            // HiddenDangerInfoAddFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 642);
            this.Controls.Add(this.dtpPreTime);
            this.Controls.Add(this.cbxIsAchieved);
            this.Controls.Add(this.cbxLevel);
            this.Controls.Add(this.cbxClass);
            this.Controls.Add(this.cbxZrbz);
            this.Controls.Add(this.cbxZrdw);
            this.Controls.Add(this.cbxInspUnit2);
            this.Controls.Add(this.gbxOperate);
            this.Controls.Add(this.dgvAdd);
            this.Name = "HiddenDangerInfoAddFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加隐患信息";
            this.Load += new System.EventHandler(this.HiddenDangerInfoAddFrm_Load);
            this.gbxOperate.ResumeLayout(false);
            this.gbxOperate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOperate;
        private System.Windows.Forms.DateTimePicker dtpInspDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxInspUnit;
        private System.Windows.Forms.Label labInspUnit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvAdd;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ComboBox cbxInspUnit2;
        private System.Windows.Forms.ComboBox cbxZrdw;
        private System.Windows.Forms.ComboBox cbxZrbz;
        private System.Windows.Forms.DateTimePicker dtpPreTime;
        private System.Windows.Forms.ComboBox cbxClass;
        private System.Windows.Forms.ComboBox cbxLevel;
        private System.Windows.Forms.ComboBox cbxIsAchieved;
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