namespace ZhuGuan.AnQuan.UI.Portal.UnitInfoUI
{
    partial class UnitInfoModifyFrm
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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsInspUnit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsZrdw = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UnitProperty = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Id,
            this.UnitName,
            this.IsInspUnit,
            this.IsZrdw,
            this.UnitProperty,
            this.Remark});
            this.dgvModify.GridColor = System.Drawing.Color.Black;
            this.dgvModify.Location = new System.Drawing.Point(10, 30);
            this.dgvModify.Name = "dgvModify";
            this.dgvModify.RowHeadersVisible = false;
            this.dgvModify.RowTemplate.Height = 23;
            this.dgvModify.Size = new System.Drawing.Size(988, 603);
            this.dgvModify.TabIndex = 3;
            this.dgvModify.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModify_CellEnter);
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
            // UnitInfoModifyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 642);
            this.Controls.Add(this.mStrip);
            this.Controls.Add(this.dgvModify);
            this.MainMenuStrip = this.mStrip;
            this.Name = "UnitInfoModifyFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改单位信息";
            this.Load += new System.EventHandler(this.UnitInfoModifyFrm_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsInspUnit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsZrdw;
        private System.Windows.Forms.DataGridViewComboBoxColumn UnitProperty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
    }
}