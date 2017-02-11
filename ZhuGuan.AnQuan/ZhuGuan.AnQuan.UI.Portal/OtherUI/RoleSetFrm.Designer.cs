namespace ZhuGuan.AnQuan.UI.Portal.OtherUI
{
    partial class RoleSetFrm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.chkZrdw = new System.Windows.Forms.CheckBox();
            this.chkAqb = new System.Windows.Forms.CheckBox();
            this.chkAqLeader = new System.Windows.Forms.CheckBox();
            this.chkSybLeader = new System.Windows.Forms.CheckBox();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.labUser = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.Location = new System.Drawing.Point(55, 209);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(233, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Controls.Add(this.chkZrdw);
            this.pnlContainer.Controls.Add(this.chkAqb);
            this.pnlContainer.Controls.Add(this.chkAqLeader);
            this.pnlContainer.Controls.Add(this.chkSybLeader);
            this.pnlContainer.Controls.Add(this.chkAdmin);
            this.pnlContainer.Location = new System.Drawing.Point(33, 61);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(312, 119);
            this.pnlContainer.TabIndex = 3;
            // 
            // chkZrdw
            // 
            this.chkZrdw.AutoSize = true;
            this.chkZrdw.Location = new System.Drawing.Point(31, 85);
            this.chkZrdw.Name = "chkZrdw";
            this.chkZrdw.Size = new System.Drawing.Size(86, 18);
            this.chkZrdw.TabIndex = 1;
            this.chkZrdw.Text = "责任单位";
            this.chkZrdw.UseVisualStyleBackColor = true;
            // 
            // chkAqb
            // 
            this.chkAqb.AutoSize = true;
            this.chkAqb.Location = new System.Drawing.Point(169, 43);
            this.chkAqb.Name = "chkAqb";
            this.chkAqb.Size = new System.Drawing.Size(71, 18);
            this.chkAqb.TabIndex = 2;
            this.chkAqb.Text = "安全办";
            this.chkAqb.UseVisualStyleBackColor = true;
            // 
            // chkAqLeader
            // 
            this.chkAqLeader.AutoSize = true;
            this.chkAqLeader.Location = new System.Drawing.Point(31, 43);
            this.chkAqLeader.Name = "chkAqLeader";
            this.chkAqLeader.Size = new System.Drawing.Size(86, 18);
            this.chkAqLeader.TabIndex = 3;
            this.chkAqLeader.Text = "安全主管";
            this.chkAqLeader.UseVisualStyleBackColor = true;
            // 
            // chkSybLeader
            // 
            this.chkSybLeader.AutoSize = true;
            this.chkSybLeader.Location = new System.Drawing.Point(169, 9);
            this.chkSybLeader.Name = "chkSybLeader";
            this.chkSybLeader.Size = new System.Drawing.Size(101, 18);
            this.chkSybLeader.TabIndex = 4;
            this.chkSybLeader.Text = "事业部领导";
            this.chkSybLeader.UseVisualStyleBackColor = true;
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Location = new System.Drawing.Point(31, 9);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(71, 18);
            this.chkAdmin.TabIndex = 5;
            this.chkAdmin.Text = "管理员";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Location = new System.Drawing.Point(30, 26);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(190, 14);
            this.labUser.TabIndex = 4;
            this.labUser.Text = "请为【luobao】设置权限：";
            // 
            // RoleSetFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 265);
            this.Controls.Add(this.labUser);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RoleSetFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户角色设置";
            this.Load += new System.EventHandler(this.RoleSetFrm_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.CheckBox chkZrdw;
        private System.Windows.Forms.CheckBox chkAqb;
        private System.Windows.Forms.CheckBox chkAqLeader;
        private System.Windows.Forms.CheckBox chkSybLeader;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.Label labUser;
    }
}