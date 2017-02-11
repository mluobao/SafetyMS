namespace ZhuGuan.AnQuan.UI.Portal.UserInfoUI
{
    partial class UserInfoAddFrm
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
            this.dgvAdd = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsVerified = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cbxUnit2 = new System.Windows.Forms.ComboBox();
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
            this.gbxOperate.Location = new System.Drawing.Point(13, 13);
            this.gbxOperate.Name = "gbxOperate";
            this.gbxOperate.Size = new System.Drawing.Size(983, 81);
            this.gbxOperate.TabIndex = 0;
            this.gbxOperate.TabStop = false;
            this.gbxOperate.Text = "数据操作";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(469, 48);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(45, 23);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(400, 48);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(296, 48);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除当前行";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(192, 48);
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
            this.cbxUnit.Location = new System.Drawing.Point(18, 49);
            this.cbxUnit.Name = "cbxUnit";
            this.cbxUnit.Size = new System.Drawing.Size(120, 20);
            this.cbxUnit.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "单位：";
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
            this.UserName,
            this.Pwd,
            this.Remark,
            this.IsVerified});
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
            this.UnitName.HeaderText = "单位";
            this.UnitName.Name = "UnitName";
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "用户名";
            this.UserName.Name = "UserName";
            // 
            // Pwd
            // 
            this.Pwd.DataPropertyName = "Pwd";
            this.Pwd.HeaderText = "密码";
            this.Pwd.Name = "Pwd";
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            // 
            // IsVerified
            // 
            this.IsVerified.DataPropertyName = "IsVerified";
            this.IsVerified.FalseValue = "0";
            this.IsVerified.HeaderText = "是否通过";
            this.IsVerified.IndeterminateValue = "1";
            this.IsVerified.Name = "IsVerified";
            this.IsVerified.TrueValue = "1";
            this.IsVerified.Width = 75;
            // 
            // cbxUnit2
            // 
            this.cbxUnit2.FormattingEnabled = true;
            this.cbxUnit2.Location = new System.Drawing.Point(31, 138);
            this.cbxUnit2.Name = "cbxUnit2";
            this.cbxUnit2.Size = new System.Drawing.Size(80, 20);
            this.cbxUnit2.TabIndex = 5;
            this.cbxUnit2.Visible = false;
            this.cbxUnit2.SelectedIndexChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            this.cbxUnit2.TextChanged += new System.EventHandler(this.cbxInspUnit2_SelectedIndexChanged);
            // 
            // UserInfoAddFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 642);
            this.Controls.Add(this.cbxUnit2);
            this.Controls.Add(this.gbxOperate);
            this.Controls.Add(this.dgvAdd);
            this.Name = "UserInfoAddFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加用户信息";
            this.Load += new System.EventHandler(this.UserInfoAddFrm_Load);
            this.gbxOperate.ResumeLayout(false);
            this.gbxOperate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOperate;
        private System.Windows.Forms.ComboBox cbxUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvAdd;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ComboBox cbxUnit2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsVerified;
    }
}