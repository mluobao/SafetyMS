namespace ZhuGuan.AnQuan.UI.Portal.UnitInfoUI
{
    partial class UnitInfoAddFrm
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
            this.dgvAdd = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsInspUnit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsZrdw = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UnitProperty = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gbxOperate.Location = new System.Drawing.Point(13, 13);
            this.gbxOperate.Name = "gbxOperate";
            this.gbxOperate.Size = new System.Drawing.Size(983, 81);
            this.gbxOperate.TabIndex = 0;
            this.gbxOperate.TabStop = false;
            this.gbxOperate.Text = "数据操作";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(293, 38);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(45, 23);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(224, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(120, 38);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除当前行";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "增加一行";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.Id,
            this.UnitName,
            this.IsInspUnit,
            this.IsZrdw,
            this.UnitProperty,
            this.Remark});
            this.dgvAdd.GridColor = System.Drawing.Color.Black;
            this.dgvAdd.Location = new System.Drawing.Point(13, 100);
            this.dgvAdd.Name = "dgvAdd";
            this.dgvAdd.RowHeadersVisible = false;
            this.dgvAdd.RowTemplate.Height = 23;
            this.dgvAdd.Size = new System.Drawing.Size(983, 529);
            this.dgvAdd.TabIndex = 1;
            this.dgvAdd.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdd_CellEnter);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "AId";
            this.Id.HeaderText = "编号";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // UnitName
            // 
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "单位名称";
            this.UnitName.Name = "UnitName";
            // 
            // IsInspUnit
            // 
            this.IsInspUnit.DataPropertyName = "IsInspUnit";
            this.IsInspUnit.FalseValue = "0";
            this.IsInspUnit.HeaderText = "是否检查单位";
            this.IsInspUnit.IndeterminateValue = "0";
            this.IsInspUnit.Name = "IsInspUnit";
            this.IsInspUnit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsInspUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsInspUnit.TrueValue = "1";
            // 
            // IsZrdw
            // 
            this.IsZrdw.DataPropertyName = "IsZrdw";
            this.IsZrdw.FalseValue = "0";
            this.IsZrdw.HeaderText = "是否责任单位";
            this.IsZrdw.IndeterminateValue = "0";
            this.IsZrdw.Name = "IsZrdw";
            this.IsZrdw.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsZrdw.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsZrdw.TrueValue = "1";
            // 
            // UnitProperty
            // 
            this.UnitProperty.DataPropertyName = "UnitProperty";
            this.UnitProperty.HeaderText = "单位性质";
            this.UnitProperty.Items.AddRange(new object[] {
            "公司级",
            "事业部级",
            "外协单位"});
            this.UnitProperty.Name = "UnitProperty";
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            // 
            // UnitInfoAddFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 642);
            this.Controls.Add(this.gbxOperate);
            this.Controls.Add(this.dgvAdd);
            this.Name = "UnitInfoAddFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加单位信息";
            this.Load += new System.EventHandler(this.UnitInfoAddFrm_Load);
            this.gbxOperate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOperate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvAdd;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsInspUnit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsZrdw;
        private System.Windows.Forms.DataGridViewComboBoxColumn UnitProperty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
    }
}