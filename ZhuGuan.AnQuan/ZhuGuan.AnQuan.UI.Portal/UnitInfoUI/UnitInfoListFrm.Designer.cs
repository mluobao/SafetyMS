namespace ZhuGuan.AnQuan.UI.Portal.UnitInfoUI
{
    partial class UnitInfoListFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitInfoListFrm));
            this.gbxOperate = new System.Windows.Forms.GroupBox();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.tStrip = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnModify = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnQuit = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxUnitProperty = new System.Windows.Forms.ComboBox();
            this.SelectStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsInspUnit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsZrdw = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UnitProperty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxOperate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.tStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxOperate
            // 
            this.gbxOperate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxOperate.Controls.Add(this.cbxUnitProperty);
            this.gbxOperate.Controls.Add(this.label1);
            this.gbxOperate.Controls.Add(this.chkSelectAll);
            this.gbxOperate.Controls.Add(this.btnSearch);
            this.gbxOperate.Location = new System.Drawing.Point(20, 34);
            this.gbxOperate.Name = "gbxOperate";
            this.gbxOperate.Size = new System.Drawing.Size(969, 52);
            this.gbxOperate.TabIndex = 0;
            this.gbxOperate.TabStop = false;
            this.gbxOperate.Text = "数据操作";
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(408, 25);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(48, 16);
            this.chkSelectAll.TabIndex = 4;
            this.chkSelectAll.Text = "全选";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(305, 23);
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
            this.Id,
            this.UnitName,
            this.IsInspUnit,
            this.IsZrdw,
            this.UnitProperty,
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
            this.dgvList.Location = new System.Drawing.Point(20, 92);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(969, 538);
            this.dgvList.TabIndex = 1;
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
            this.toolStripSeparator4,
            this.tsbtnQuit});
            this.tStrip.Location = new System.Drawing.Point(0, 0);
            this.tStrip.Name = "tStrip";
            this.tStrip.Size = new System.Drawing.Size(1008, 29);
            this.tStrip.TabIndex = 3;
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
            this.tsbtnModify.Size = new System.Drawing.Size(46, 26);
            this.tsbtnModify.Text = "修改";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "单位性质：";
            // 
            // cbxUnitProperty
            // 
            this.cbxUnitProperty.FormattingEnabled = true;
            this.cbxUnitProperty.Items.AddRange(new object[] {
            "公司级",
            "事业部级",
            "外协单位"});
            this.cbxUnitProperty.Location = new System.Drawing.Point(70, 23);
            this.cbxUnitProperty.Name = "cbxUnitProperty";
            this.cbxUnitProperty.Size = new System.Drawing.Size(100, 20);
            this.cbxUnitProperty.TabIndex = 6;
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
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "编号";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // UnitName
            // 
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "单位名称";
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            // 
            // IsInspUnit
            // 
            this.IsInspUnit.DataPropertyName = "IsInspUnit";
            this.IsInspUnit.FalseValue = "0";
            this.IsInspUnit.HeaderText = "是否检查单位";
            this.IsInspUnit.IndeterminateValue = "0";
            this.IsInspUnit.Name = "IsInspUnit";
            this.IsInspUnit.ReadOnly = true;
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
            this.IsZrdw.ReadOnly = true;
            this.IsZrdw.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsZrdw.TrueValue = "1";
            // 
            // UnitProperty
            // 
            this.UnitProperty.DataPropertyName = "UnitProperty";
            this.UnitProperty.HeaderText = "单位性质";
            this.UnitProperty.Name = "UnitProperty";
            this.UnitProperty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UnitProperty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            // 
            // UnitInfoListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 642);
            this.Controls.Add(this.tStrip);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.gbxOperate);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UnitInfoListFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "单位信息表";
            this.Load += new System.EventHandler(this.UnitInfoListFrm_Load);
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
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.ToolStrip tStrip;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnModify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnQuit;
        private System.Windows.Forms.ComboBox cbxUnitProperty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsInspUnit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsZrdw;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitProperty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
    }
}