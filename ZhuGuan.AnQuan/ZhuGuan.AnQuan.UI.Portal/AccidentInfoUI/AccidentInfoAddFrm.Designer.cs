namespace ZhuGuan.AnQuan.UI.Portal.AccidentInfoUI
{
    partial class AccidentInfoAddFrm
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
            this.gbxOperate = new System.Windows.Forms.GroupBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxUnit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInspDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAdd = new System.Windows.Forms.DataGridView();
            this.AId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HappenDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcciType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcciDesp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcciAnalysis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxUnit2 = new System.Windows.Forms.ComboBox();
            this.cbxAcciType = new System.Windows.Forms.ComboBox();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.gbxOperate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxOperate
            // 
            this.gbxOperate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxOperate.Controls.Add(this.btnQuit);
            this.gbxOperate.Controls.Add(this.btnSave);
            this.gbxOperate.Controls.Add(this.btnDelete);
            this.gbxOperate.Controls.Add(this.btnAdd);
            this.gbxOperate.Controls.Add(this.cbxUnit);
            this.gbxOperate.Controls.Add(this.label2);
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
            // cbxUnit
            // 
            this.cbxUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUnit.FormattingEnabled = true;
            this.cbxUnit.Location = new System.Drawing.Point(144, 45);
            this.cbxUnit.Name = "cbxUnit";
            this.cbxUnit.Size = new System.Drawing.Size(120, 20);
            this.cbxUnit.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "单位：";
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
            this.AId,
            this.HappenDate,
            this.Unit,
            this.AcciType,
            this.AcciDesp,
            this.AcciAnalysis,
            this.Class2,
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
            this.AcciType.HeaderText = "事故类型 ";
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
            // cbxUnit2
            // 
            this.cbxUnit2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUnit2.FormattingEnabled = true;
            this.cbxUnit2.Location = new System.Drawing.Point(106, 140);
            this.cbxUnit2.Name = "cbxUnit2";
            this.cbxUnit2.Size = new System.Drawing.Size(80, 20);
            this.cbxUnit2.TabIndex = 5;
            this.cbxUnit2.Visible = false;
            this.cbxUnit2.SelectedIndexChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            this.cbxUnit2.TextChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
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
            this.cbxAcciType.Location = new System.Drawing.Point(206, 140);
            this.cbxAcciType.Name = "cbxAcciType";
            this.cbxAcciType.Size = new System.Drawing.Size(80, 20);
            this.cbxAcciType.TabIndex = 5;
            this.cbxAcciType.Visible = false;
            this.cbxAcciType.SelectedIndexChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            this.cbxAcciType.TextChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            // 
            // cbxClass
            // 
            this.cbxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Items.AddRange(new object[] {
            "A：人的不安全行为",
            "B：物的不安全状态",
            "C：安全基础管理"});
            this.cbxClass.Location = new System.Drawing.Point(519, 140);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(80, 20);
            this.cbxClass.TabIndex = 5;
            this.cbxClass.Visible = false;
            this.cbxClass.SelectedIndexChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            this.cbxClass.TextChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            // 
            // AccidentInfoAddFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 642);
            this.Controls.Add(this.cbxClass);
            this.Controls.Add(this.cbxAcciType);
            this.Controls.Add(this.cbxUnit2);
            this.Controls.Add(this.gbxOperate);
            this.Controls.Add(this.dgvAdd);
            this.Name = "AccidentInfoAddFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加事故信息";
            this.Load += new System.EventHandler(this.AccidentInfoAddFrm_Load);
            this.gbxOperate.ResumeLayout(false);
            this.gbxOperate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOperate;
        private System.Windows.Forms.DateTimePicker dtpInspDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvAdd;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ComboBox cbxUnit2;
        private System.Windows.Forms.ComboBox cbxAcciType;
        private System.Windows.Forms.ComboBox cbxClass;
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