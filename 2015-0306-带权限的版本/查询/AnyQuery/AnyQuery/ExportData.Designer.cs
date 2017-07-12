namespace AnyQuery
{
    partial class ExportData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportData));
            this.labelfilename = new System.Windows.Forms.Label();
            this.filename = new System.Windows.Forms.TextBox();
            this.btnfilename = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.exportprogress = new System.Windows.Forms.ProgressBar();
            this.toopen = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelfilename
            // 
            this.labelfilename.AutoSize = true;
            this.labelfilename.BackColor = System.Drawing.Color.Transparent;
            this.labelfilename.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelfilename.ForeColor = System.Drawing.Color.White;
            this.labelfilename.Location = new System.Drawing.Point(33, 28);
            this.labelfilename.Name = "labelfilename";
            this.labelfilename.Size = new System.Drawing.Size(79, 19);
            this.labelfilename.TabIndex = 0;
            this.labelfilename.Text = "保存文件：";
            // 
            // filename
            // 
            this.filename.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.filename.Location = new System.Drawing.Point(119, 26);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(232, 23);
            this.filename.TabIndex = 1;
            // 
            // btnfilename
            // 
            this.btnfilename.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnfilename.Location = new System.Drawing.Point(357, 25);
            this.btnfilename.Name = "btnfilename";
            this.btnfilename.Size = new System.Drawing.Size(75, 27);
            this.btnfilename.TabIndex = 2;
            this.btnfilename.Text = "选择路径";
            this.btnfilename.UseVisualStyleBackColor = true;
            this.btnfilename.Click += new System.EventHandler(this.btnfilename_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Image = global::AnyQuery.Properties.Resources.ok;
            this.btnOK.Location = new System.Drawing.Point(90, 107);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 34);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "   确  定";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btncancel.Image = global::AnyQuery.Properties.Resources.cancel;
            this.btncancel.Location = new System.Drawing.Point(284, 107);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(91, 34);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "   取  消";
            this.btncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // exportprogress
            // 
            this.exportprogress.Location = new System.Drawing.Point(34, 168);
            this.exportprogress.Name = "exportprogress";
            this.exportprogress.Size = new System.Drawing.Size(396, 23);
            this.exportprogress.TabIndex = 5;
            // 
            // toopen
            // 
            this.toopen.AutoSize = true;
            this.toopen.BackColor = System.Drawing.Color.Transparent;
            this.toopen.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toopen.ForeColor = System.Drawing.Color.White;
            this.toopen.Location = new System.Drawing.Point(38, 71);
            this.toopen.Name = "toopen";
            this.toopen.Size = new System.Drawing.Size(130, 21);
            this.toopen.TabIndex = 6;
            this.toopen.Text = "导出后打开Excel？";
            this.toopen.UseVisualStyleBackColor = false;
            // 
            // ExportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(465, 219);
            this.Controls.Add(this.toopen);
            this.Controls.Add(this.exportprogress);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnfilename);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.labelfilename);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(481, 257);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(481, 257);
            this.Name = "ExportData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "输出";
            this.Load += new System.EventHandler(this.ExportData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelfilename;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.Button btnfilename;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.ProgressBar exportprogress;
        private System.Windows.Forms.CheckBox toopen;
    }
}