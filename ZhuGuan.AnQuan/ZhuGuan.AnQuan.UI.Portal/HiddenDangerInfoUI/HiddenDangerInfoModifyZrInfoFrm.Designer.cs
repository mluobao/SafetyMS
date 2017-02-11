namespace ZhuGuan.AnQuan.UI.Portal.HiddenDangerInfoUI
{
    partial class HiddenDangerInfoModifyZrInfoFrm
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
            this.mStrip = new System.Windows.Forms.MenuStrip();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miSplit = new System.Windows.Forms.ToolStripMenuItem();
            this.miQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvModify = new System.Windows.Forms.DataGridView();
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
            this.cbxZrbz = new System.Windows.Forms.ComboBox();
            this.cbxIsAchieved = new System.Windows.Forms.ComboBox();
            this.mStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModify)).BeginInit();
            this.SuspendLayout();
            // 
            // mStrip
            // 
            this.mStrip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSave,
            this.miSplit,
            this.miQuit});
            this.mStrip.Location = new System.Drawing.Point(0, 0);
            this.mStrip.Name = "mStrip";
            this.mStrip.Size = new System.Drawing.Size(1008, 27);
            this.mStrip.TabIndex = 2;
            this.mStrip.Text = "menuStrip1";
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.Size = new System.Drawing.Size(49, 23);
            this.miSave.Text = "保存";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // miSplit
            // 
            this.miSplit.Name = "miSplit";
            this.miSplit.Size = new System.Drawing.Size(34, 23);
            this.miSplit.Text = " | ";
            // 
            // miQuit
            // 
            this.miQuit.Name = "miQuit";
            this.miQuit.Size = new System.Drawing.Size(49, 23);
            this.miQuit.Text = "退出";
            this.miQuit.Click += new System.EventHandler(this.miQuit_Click);
            // 
            // dgvModify
            // 
            this.dgvModify.AllowUserToAddRows = false;
            this.dgvModify.AllowUserToDeleteRows = false;
            this.dgvModify.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvModify.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvModify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModify.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvModify.GridColor = System.Drawing.Color.Black;
            this.dgvModify.Location = new System.Drawing.Point(10, 30);
            this.dgvModify.Name = "dgvModify";
            this.dgvModify.RowHeadersVisible = false;
            this.dgvModify.RowTemplate.Height = 23;
            this.dgvModify.Size = new System.Drawing.Size(988, 603);
            this.dgvModify.TabIndex = 3;
            this.dgvModify.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModify_CellEnter);
            this.dgvModify.CurrentCellChanged += new System.EventHandler(this.dgvModify_CurrentCellChanged);
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
            this.InspDate.ReadOnly = true;
            this.InspDate.Width = 80;
            // 
            // InspUnit
            // 
            this.InspUnit.DataPropertyName = "InspUnit";
            this.InspUnit.HeaderText = "检查单位";
            this.InspUnit.Name = "InspUnit";
            this.InspUnit.ReadOnly = true;
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
            this.ReformMeasure.ReadOnly = true;
            this.ReformMeasure.Width = 120;
            // 
            // Class2
            // 
            this.Class2.DataPropertyName = "Class2";
            this.Class2.HeaderText = "问题分类";
            this.Class2.Name = "Class2";
            this.Class2.ReadOnly = true;
            this.Class2.Width = 120;
            // 
            // Level2
            // 
            this.Level2.DataPropertyName = "Level2";
            this.Level2.HeaderText = "风险等级";
            this.Level2.Name = "Level2";
            this.Level2.ReadOnly = true;
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
            // cbxZrbz
            // 
            this.cbxZrbz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxZrbz.FormattingEnabled = true;
            this.cbxZrbz.Location = new System.Drawing.Point(827, 311);
            this.cbxZrbz.Name = "cbxZrbz";
            this.cbxZrbz.Size = new System.Drawing.Size(80, 20);
            this.cbxZrbz.TabIndex = 9;
            this.cbxZrbz.Visible = false;
            this.cbxZrbz.SelectedIndexChanged += new System.EventHandler(this.cbxZrbz_SelectedIndexChanged);
            this.cbxZrbz.TextChanged += new System.EventHandler(this.cbxZrbz_SelectedIndexChanged);
            this.cbxZrbz.Enter += new System.EventHandler(this.cbxZrbz_Enter);
            // 
            // cbxIsAchieved
            // 
            this.cbxIsAchieved.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIsAchieved.FormattingEnabled = true;
            this.cbxIsAchieved.Items.AddRange(new object[] {
            "未整改",
            "已整改"});
            this.cbxIsAchieved.Location = new System.Drawing.Point(913, 311);
            this.cbxIsAchieved.Name = "cbxIsAchieved";
            this.cbxIsAchieved.Size = new System.Drawing.Size(80, 20);
            this.cbxIsAchieved.TabIndex = 8;
            this.cbxIsAchieved.Visible = false;
            this.cbxIsAchieved.SelectedIndexChanged += new System.EventHandler(this.cbxZrbz_SelectedIndexChanged);
            this.cbxIsAchieved.TextChanged += new System.EventHandler(this.cbxZrbz_SelectedIndexChanged);
            // 
            // HiddenDangerInfoModifyZrInfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 642);
            this.Controls.Add(this.cbxIsAchieved);
            this.Controls.Add(this.cbxZrbz);
            this.Controls.Add(this.mStrip);
            this.Controls.Add(this.dgvModify);
            this.MainMenuStrip = this.mStrip;
            this.Name = "HiddenDangerInfoModifyZrInfoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "隐患整改信息【责任信息修改】";
            this.Load += new System.EventHandler(this.HiddenDangerInfoModifyZrInfoFrm_Load);
            this.mStrip.ResumeLayout(false);
            this.mStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModify)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mStrip;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripMenuItem miSplit;
        private System.Windows.Forms.ToolStripMenuItem miQuit;
        private System.Windows.Forms.DataGridView dgvModify;
        private System.Windows.Forms.ComboBox cbxZrbz;
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