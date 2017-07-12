namespace AnyQuery
{
    partial class SaveSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveSetting));
            this.labelsetname = new System.Windows.Forms.Label();
            this.selectname = new System.Windows.Forms.ComboBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelsetname
            // 
            this.labelsetname.AutoSize = true;
            this.labelsetname.BackColor = System.Drawing.Color.Transparent;
            this.labelsetname.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelsetname.ForeColor = System.Drawing.Color.White;
            this.labelsetname.Location = new System.Drawing.Point(56, 46);
            this.labelsetname.Name = "labelsetname";
            this.labelsetname.Size = new System.Drawing.Size(65, 19);
            this.labelsetname.TabIndex = 0;
            this.labelsetname.Text = "另存为：";
            // 
            // selectname
            // 
            this.selectname.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectname.FormattingEnabled = true;
            this.selectname.Location = new System.Drawing.Point(127, 44);
            this.selectname.Name = "selectname";
            this.selectname.Size = new System.Drawing.Size(221, 25);
            this.selectname.TabIndex = 1;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnsave.Image = global::AnyQuery.Properties.Resources.ok;
            this.btnsave.Location = new System.Drawing.Point(77, 100);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(86, 35);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "   确  定";
            this.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btncancel.Image = global::AnyQuery.Properties.Resources.cancel;
            this.btncancel.Location = new System.Drawing.Point(242, 100);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(86, 35);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "   取  消";
            this.btncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // SaveSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(404, 162);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.selectname);
            this.Controls.Add(this.labelsetname);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 200);
            this.Name = "SaveSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "保存设置";
            this.Load += new System.EventHandler(this.SaveSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelsetname;
        private System.Windows.Forms.ComboBox selectname;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
    }
}