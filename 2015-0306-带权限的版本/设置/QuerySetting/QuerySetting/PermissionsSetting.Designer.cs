namespace QuerySetting
{
    partial class PermissionsSetting
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
            this.labelTableName = new System.Windows.Forms.Label();
            this.labelSelectRole = new System.Windows.Forms.Label();
            this.panelShowRoles = new System.Windows.Forms.Panel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonReselect = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.comboBoxSelectTableName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelTableName
            // 
            this.labelTableName.AutoSize = true;
            this.labelTableName.BackColor = System.Drawing.Color.Transparent;
            this.labelTableName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelTableName.ForeColor = System.Drawing.Color.White;
            this.labelTableName.Location = new System.Drawing.Point(27, 35);
            this.labelTableName.Name = "labelTableName";
            this.labelTableName.Size = new System.Drawing.Size(79, 19);
            this.labelTableName.TabIndex = 0;
            this.labelTableName.Text = "选择角色：";
            // 
            // labelSelectRole
            // 
            this.labelSelectRole.AutoSize = true;
            this.labelSelectRole.BackColor = System.Drawing.Color.Transparent;
            this.labelSelectRole.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelSelectRole.ForeColor = System.Drawing.Color.White;
            this.labelSelectRole.Location = new System.Drawing.Point(27, 71);
            this.labelSelectRole.Name = "labelSelectRole";
            this.labelSelectRole.Size = new System.Drawing.Size(93, 19);
            this.labelSelectRole.TabIndex = 1;
            this.labelSelectRole.Text = "选择查询项：";
            // 
            // panelShowRoles
            // 
            this.panelShowRoles.AutoScroll = true;
            this.panelShowRoles.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelShowRoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShowRoles.Location = new System.Drawing.Point(31, 93);
            this.panelShowRoles.Name = "panelShowRoles";
            this.panelShowRoles.Size = new System.Drawing.Size(326, 317);
            this.panelShowRoles.TabIndex = 2;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonOK.Location = new System.Drawing.Point(31, 433);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(68, 29);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonReselect
            // 
            this.buttonReselect.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonReselect.Location = new System.Drawing.Point(157, 434);
            this.buttonReselect.Name = "buttonReselect";
            this.buttonReselect.Size = new System.Drawing.Size(82, 28);
            this.buttonReselect.TabIndex = 4;
            this.buttonReselect.Text = "重选";
            this.buttonReselect.UseVisualStyleBackColor = true;
            this.buttonReselect.Click += new System.EventHandler(this.buttonReselect_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonClose.Location = new System.Drawing.Point(279, 433);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(78, 29);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "返回";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // comboBoxSelectTableName
            // 
            this.comboBoxSelectTableName.FormattingEnabled = true;
            this.comboBoxSelectTableName.Location = new System.Drawing.Point(112, 32);
            this.comboBoxSelectTableName.Name = "comboBoxSelectTableName";
            this.comboBoxSelectTableName.Size = new System.Drawing.Size(237, 22);
            this.comboBoxSelectTableName.TabIndex = 6;
            this.comboBoxSelectTableName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PermissionsSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuerySetting.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(393, 481);
            this.Controls.Add(this.comboBoxSelectTableName);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonReselect);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.panelShowRoles);
            this.Controls.Add(this.labelSelectRole);
            this.Controls.Add(this.labelTableName);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PermissionsSetting";
            this.Text = "权限设定";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PermissionsSetting_FormClosing);
            this.Load += new System.EventHandler(this.PermissionsSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTableName;
        private System.Windows.Forms.Label labelSelectRole;
        private System.Windows.Forms.Panel panelShowRoles;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonReselect;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ComboBox comboBoxSelectTableName;
    }
}