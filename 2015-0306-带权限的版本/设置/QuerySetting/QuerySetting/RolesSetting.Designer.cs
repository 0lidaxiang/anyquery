namespace QuerySetting
{
    partial class RolesSetting
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
            this.labelRoleName = new System.Windows.Forms.Label();
            this.labelRoleDescribe = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonRefill = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxRoleName = new System.Windows.Forms.TextBox();
            this.textBoxRoleDescribe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelRoleName
            // 
            this.labelRoleName.AutoSize = true;
            this.labelRoleName.BackColor = System.Drawing.Color.Transparent;
            this.labelRoleName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelRoleName.ForeColor = System.Drawing.Color.White;
            this.labelRoleName.Location = new System.Drawing.Point(31, 37);
            this.labelRoleName.Name = "labelRoleName";
            this.labelRoleName.Size = new System.Drawing.Size(79, 19);
            this.labelRoleName.TabIndex = 5;
            this.labelRoleName.Text = "角色名称：";
            // 
            // labelRoleDescribe
            // 
            this.labelRoleDescribe.AutoSize = true;
            this.labelRoleDescribe.BackColor = System.Drawing.Color.Transparent;
            this.labelRoleDescribe.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelRoleDescribe.ForeColor = System.Drawing.Color.White;
            this.labelRoleDescribe.Location = new System.Drawing.Point(31, 79);
            this.labelRoleDescribe.Name = "labelRoleDescribe";
            this.labelRoleDescribe.Size = new System.Drawing.Size(79, 19);
            this.labelRoleDescribe.TabIndex = 6;
            this.labelRoleDescribe.Text = "角色描述：";
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonOK.Location = new System.Drawing.Point(35, 157);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(65, 32);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonRefill
            // 
            this.buttonRefill.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonRefill.Location = new System.Drawing.Point(154, 157);
            this.buttonRefill.Name = "buttonRefill";
            this.buttonRefill.Size = new System.Drawing.Size(75, 32);
            this.buttonRefill.TabIndex = 3;
            this.buttonRefill.Text = "全部清空";
            this.buttonRefill.UseVisualStyleBackColor = true;
            this.buttonRefill.Click += new System.EventHandler(this.buttonRefill_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonClose.Location = new System.Drawing.Point(282, 157);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(61, 32);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "返回";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxRoleName
            // 
            this.textBoxRoleName.Location = new System.Drawing.Point(110, 34);
            this.textBoxRoleName.Name = "textBoxRoleName";
            this.textBoxRoleName.Size = new System.Drawing.Size(233, 21);
            this.textBoxRoleName.TabIndex = 0;
            // 
            // textBoxRoleDescribe
            // 
            this.textBoxRoleDescribe.Location = new System.Drawing.Point(113, 78);
            this.textBoxRoleDescribe.Name = "textBoxRoleDescribe";
            this.textBoxRoleDescribe.Size = new System.Drawing.Size(230, 21);
            this.textBoxRoleDescribe.TabIndex = 1;
            // 
            // RolesSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuerySetting.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(381, 211);
            this.Controls.Add(this.textBoxRoleDescribe);
            this.Controls.Add(this.textBoxRoleName);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonRefill);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelRoleDescribe);
            this.Controls.Add(this.labelRoleName);
            this.MaximumSize = new System.Drawing.Size(397, 249);
            this.MinimumSize = new System.Drawing.Size(397, 249);
            this.Name = "RolesSetting";
            this.Text = "角色设定";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RolesSetting_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRoleName;
        private System.Windows.Forms.Label labelRoleDescribe;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonRefill;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxRoleName;
        private System.Windows.Forms.TextBox textBoxRoleDescribe;
    }
}