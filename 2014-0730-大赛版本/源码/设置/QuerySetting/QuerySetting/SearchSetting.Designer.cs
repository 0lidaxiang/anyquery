namespace QuerySetting
{
    partial class SearchSetting
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchSetting));
            this.labeltname = new System.Windows.Forms.Label();
            this.labelchinese = new System.Windows.Forms.Label();
            this.selecttable = new System.Windows.Forms.ComboBox();
            this.tablechinese = new System.Windows.Forms.TextBox();
            this.selectlist = new System.Windows.Forms.Panel();
            this.labeltip = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_chinese = new System.Windows.Forms.Label();
            this.label_short = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labeltname
            // 
            this.labeltname.AutoSize = true;
            this.labeltname.BackColor = System.Drawing.Color.Transparent;
            this.labeltname.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltname.ForeColor = System.Drawing.Color.White;
            this.labeltname.Location = new System.Drawing.Point(45, 31);
            this.labeltname.Name = "labeltname";
            this.labeltname.Size = new System.Drawing.Size(106, 22);
            this.labeltname.TabIndex = 0;
            this.labeltname.Text = "选择查询项：";
            // 
            // labelchinese
            // 
            this.labelchinese.AutoSize = true;
            this.labelchinese.BackColor = System.Drawing.Color.Transparent;
            this.labelchinese.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelchinese.ForeColor = System.Drawing.Color.White;
            this.labelchinese.Location = new System.Drawing.Point(72, 80);
            this.labelchinese.Name = "labelchinese";
            this.labelchinese.Size = new System.Drawing.Size(74, 22);
            this.labelchinese.TabIndex = 1;
            this.labelchinese.Text = "中文名：";
            // 
            // selecttable
            // 
            this.selecttable.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selecttable.FormattingEnabled = true;
            this.selecttable.Location = new System.Drawing.Point(152, 31);
            this.selecttable.Name = "selecttable";
            this.selecttable.Size = new System.Drawing.Size(224, 25);
            this.selecttable.TabIndex = 2;
            this.selecttable.SelectedIndexChanged += new System.EventHandler(this.selecttable_SelectedIndexChanged);
            // 
            // tablechinese
            // 
            this.tablechinese.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tablechinese.Location = new System.Drawing.Point(152, 79);
            this.tablechinese.Name = "tablechinese";
            this.tablechinese.Size = new System.Drawing.Size(224, 23);
            this.tablechinese.TabIndex = 3;
            // 
            // selectlist
            // 
            this.selectlist.AutoScroll = true;
            this.selectlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectlist.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectlist.Location = new System.Drawing.Point(41, 182);
            this.selectlist.Name = "selectlist";
            this.selectlist.Size = new System.Drawing.Size(388, 440);
            this.selectlist.TabIndex = 4;
            // 
            // labeltip
            // 
            this.labeltip.AutoSize = true;
            this.labeltip.BackColor = System.Drawing.Color.Transparent;
            this.labeltip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltip.ForeColor = System.Drawing.Color.White;
            this.labeltip.Location = new System.Drawing.Point(46, 128);
            this.labeltip.Name = "labeltip";
            this.labeltip.Size = new System.Drawing.Size(219, 19);
            this.labeltip.TabIndex = 5;
            this.labeltip.Text = "选择显示数据项和设置查询数据项";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Image = global::QuerySetting.Properties.Resources.ok;
            this.btnOK.Location = new System.Drawing.Point(91, 639);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 34);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "   确  定";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Image = global::QuerySetting.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(288, 639);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 34);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "   取  消";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "字段名";
            // 
            // label_chinese
            // 
            this.label_chinese.AutoSize = true;
            this.label_chinese.BackColor = System.Drawing.Color.Transparent;
            this.label_chinese.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_chinese.ForeColor = System.Drawing.Color.White;
            this.label_chinese.Location = new System.Drawing.Point(244, 160);
            this.label_chinese.Name = "label_chinese";
            this.label_chinese.Size = new System.Drawing.Size(37, 19);
            this.label_chinese.TabIndex = 9;
            this.label_chinese.Text = "翻译";
            // 
            // label_short
            // 
            this.label_short.AutoSize = true;
            this.label_short.BackColor = System.Drawing.Color.Transparent;
            this.label_short.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_short.ForeColor = System.Drawing.Color.White;
            this.label_short.Location = new System.Drawing.Point(347, 160);
            this.label_short.Name = "label_short";
            this.label_short.Size = new System.Drawing.Size(37, 19);
            this.label_short.TabIndex = 10;
            this.label_short.Text = "排序";
            // 
            // SearchSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuerySetting.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(471, 685);
            this.Controls.Add(this.label_short);
            this.Controls.Add(this.label_chinese);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labeltip);
            this.Controls.Add(this.selectlist);
            this.Controls.Add(this.tablechinese);
            this.Controls.Add(this.selecttable);
            this.Controls.Add(this.labelchinese);
            this.Controls.Add(this.labeltname);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(487, 723);
            this.MinimumSize = new System.Drawing.Size(487, 723);
            this.Name = "SearchSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询设置";
            this.Load += new System.EventHandler(this.SearchSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltname;
        private System.Windows.Forms.Label labelchinese;
        private System.Windows.Forms.ComboBox selecttable;
        private System.Windows.Forms.TextBox tablechinese;
        private System.Windows.Forms.Panel selectlist;
        private System.Windows.Forms.Label labeltip;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_chinese;
        private System.Windows.Forms.Label label_short;
    }
}

