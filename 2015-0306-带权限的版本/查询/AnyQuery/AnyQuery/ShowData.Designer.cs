namespace AnyQuery
{
    partial class ShowData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowData));
            this.selectresult = new System.Windows.Forms.DataGridView();
            this.labelsummary = new System.Windows.Forms.Label();
            this.labelcount = new System.Windows.Forms.Label();
            this.selectsum = new System.Windows.Forms.ComboBox();
            this.selectcount = new System.Windows.Forms.ComboBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btnexport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selectresult)).BeginInit();
            this.SuspendLayout();
            // 
            // selectresult
            // 
            this.selectresult.AllowUserToAddRows = false;
            this.selectresult.AllowUserToDeleteRows = false;
            this.selectresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectresult.Location = new System.Drawing.Point(12, 12);
            this.selectresult.Name = "selectresult";
            this.selectresult.RowTemplate.Height = 23;
            this.selectresult.Size = new System.Drawing.Size(724, 428);
            this.selectresult.TabIndex = 0;
            // 
            // labelsummary
            // 
            this.labelsummary.AutoSize = true;
            this.labelsummary.BackColor = System.Drawing.Color.Transparent;
            this.labelsummary.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelsummary.ForeColor = System.Drawing.Color.White;
            this.labelsummary.Location = new System.Drawing.Point(13, 472);
            this.labelsummary.Name = "labelsummary";
            this.labelsummary.Size = new System.Drawing.Size(121, 19);
            this.labelsummary.TabIndex = 1;
            this.labelsummary.Text = "汇总项（数值）：";
            // 
            // labelcount
            // 
            this.labelcount.AutoSize = true;
            this.labelcount.BackColor = System.Drawing.Color.Transparent;
            this.labelcount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelcount.ForeColor = System.Drawing.Color.Transparent;
            this.labelcount.Location = new System.Drawing.Point(314, 472);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(65, 19);
            this.labelcount.TabIndex = 2;
            this.labelcount.Text = "统计项：";
            // 
            // selectsum
            // 
            this.selectsum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectsum.FormattingEnabled = true;
            this.selectsum.Location = new System.Drawing.Point(137, 469);
            this.selectsum.Name = "selectsum";
            this.selectsum.Size = new System.Drawing.Size(137, 25);
            this.selectsum.TabIndex = 3;
            // 
            // selectcount
            // 
            this.selectcount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectcount.FormattingEnabled = true;
            this.selectcount.Location = new System.Drawing.Point(387, 469);
            this.selectcount.Name = "selectcount";
            this.selectcount.Size = new System.Drawing.Size(137, 25);
            this.selectcount.TabIndex = 4;
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnok.Location = new System.Drawing.Point(563, 466);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 27);
            this.btnok.TabIndex = 5;
            this.btnok.Text = "统计确认";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnexport
            // 
            this.btnexport.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnexport.Location = new System.Drawing.Point(661, 466);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(75, 27);
            this.btnexport.TabIndex = 6;
            this.btnexport.Text = "统计输出";
            this.btnexport.UseVisualStyleBackColor = true;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // ShowData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(748, 521);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.selectcount);
            this.Controls.Add(this.selectsum);
            this.Controls.Add(this.labelcount);
            this.Controls.Add(this.labelsummary);
            this.Controls.Add(this.selectresult);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(764, 559);
            this.MinimumSize = new System.Drawing.Size(764, 559);
            this.Name = "ShowData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询结果";
            this.Load += new System.EventHandler(this.ShowData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectresult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView selectresult;
        private System.Windows.Forms.Label labelsummary;
        private System.Windows.Forms.Label labelcount;
        private System.Windows.Forms.ComboBox selectsum;
        private System.Windows.Forms.ComboBox selectcount;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnexport;
    }
}