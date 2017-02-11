namespace ZhuGuan.AnQuan.UI.Portal.AccidentInfoUI
{
    partial class AccidentInfoModifyFrm
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
            this.AId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HappenDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcciType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcciDesp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcciAnalysis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.cbxAcciType = new System.Windows.Forms.ComboBox();
            this.cbxUnit2 = new System.Windows.Forms.ComboBox();
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
            this.mStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mStrip_ItemClicked);
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
            this.AId,
            this.HappenDate,
            this.Unit,
            this.AcciType,
            this.AcciDesp,
            this.AcciAnalysis,
            this.Class2,
            this.Remark});
            this.dgvModify.GridColor = System.Drawing.Color.Black;
            this.dgvModify.Location = new System.Drawing.Point(10, 33);
            this.dgvModify.Name = "dgvModify";
            this.dgvModify.RowHeadersVisible = false;
            this.dgvModify.RowTemplate.Height = 23;
            this.dgvModify.Size = new System.Drawing.Size(988, 597);
            this.dgvModify.TabIndex = 3;
            this.dgvModify.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModify_CellEnter);
            this.dgvModify.CurrentCellChanged += new System.EventHandler(this.dgvModify_CurrentCellChanged);
            // 
            // AId
            // 
            this.AId.DataPropertyName = "AId";
            this.AId.HeaderText = "编号";
            this.AId.Name = "AId";
            this.AId.Visible = false;
            // 
            // HappenDate
            // 
            this.HappenDate.DataPropertyName = "HappenDate";
            this.HappenDate.HeaderText = "日期";
            this.HappenDate.Name = "HappenDate";
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "单位";
            this.Unit.Name = "Unit";
            // 
            // AcciType
            // 
            this.AcciType.DataPropertyName = "AcciType";
            this.AcciType.HeaderText = "事故类型";
            this.AcciType.Name = "AcciType";
            // 
            // AcciDesp
            // 
            this.AcciDesp.DataPropertyName = "AcciDesp";
            this.AcciDesp.HeaderText = "事故情况";
            this.AcciDesp.Name = "AcciDesp";
            // 
            // AcciAnalysis
            // 
            this.AcciAnalysis.DataPropertyName = "AcciAnalysis";
            this.AcciAnalysis.HeaderText = "事故分析";
            this.AcciAnalysis.Name = "AcciAnalysis";
            // 
            // Class2
            // 
            this.Class2.DataPropertyName = "Class2";
            this.Class2.HeaderText = "问题分类";
            this.Class2.Name = "Class2";
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            // 
            // cbxClass
            // 
            this.cbxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Items.AddRange(new object[] {
            "A：人的不安全行为",
            "B：物的不安全状态",
            "C：安全基础管理"});
            this.cbxClass.Location = new System.Drawing.Point(511, 312);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(80, 20);
            this.cbxClass.TabIndex = 8;
            this.cbxClass.Visible = false;
            this.cbxClass.SelectedIndexChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            this.cbxClass.TextChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            // 
            // cbxAcciType
            // 
            this.cbxAcciType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAcciType.FormattingEnabled = true;
            this.cbxAcciType.Items.AddRange(new object[] {
            "A：重伤以上事故",
            "B：轻伤事故",
            "C：轻微伤事故",
            "D：险肇事故"});
            this.cbxAcciType.Location = new System.Drawing.Point(202, 312);
            this.cbxAcciType.Name = "cbxAcciType";
            this.cbxAcciType.Size = new System.Drawing.Size(80, 20);
            this.cbxAcciType.TabIndex = 10;
            this.cbxAcciType.Visible = false;
            this.cbxAcciType.SelectedIndexChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            this.cbxAcciType.TextChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            // 
            // cbxUnit2
            // 
            this.cbxUnit2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUnit2.FormattingEnabled = true;
            this.cbxUnit2.Location = new System.Drawing.Point(102, 312);
            this.cbxUnit2.Name = "cbxUnit2";
            this.cbxUnit2.Size = new System.Drawing.Size(80, 20);
            this.cbxUnit2.TabIndex = 11;
            this.cbxUnit2.Visible = false;
            this.cbxUnit2.SelectedIndexChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            this.cbxUnit2.TextChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            // 
            // AccidentInfoModifyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 642);
            this.Controls.Add(this.cbxClass);
            this.Controls.Add(this.cbxAcciType);
            this.Controls.Add(this.cbxUnit2);
            this.Controls.Add(this.mStrip);
            this.Controls.Add(this.dgvModify);
            this.MainMenuStrip = this.mStrip;
            this.Name = "AccidentInfoModifyFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改事故信息";
            this.Load += new System.EventHandler(this.AccidentInfoModifyFrm_Load);
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
        private System.Windows.Forms.ComboBox cbxClass;
        private System.Windows.Forms.ComboBox cbxAcciType;
        private System.Windows.Forms.ComboBox cbxUnit2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HappenDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcciType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcciDesp;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcciAnalysis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
    }
}