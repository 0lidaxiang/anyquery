namespace AnyQuery
{
    partial class SearchMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchMain));
            this.labeltname = new System.Windows.Forms.Label();
            this.selecttable = new System.Windows.Forms.ComboBox();
            this.labelsettings = new System.Windows.Forms.Label();
            this.selectsetting = new System.Windows.Forms.ComboBox();
            this.labeltip = new System.Windows.Forms.Label();
            this.btnall = new System.Windows.Forms.Button();
            this.btnallnot = new System.Windows.Forms.Button();
            this.btndelsetting = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.selectlist = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnexport = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.label_Qname = new System.Windows.Forms.Label();
            this.label_QC1 = new System.Windows.Forms.Label();
            this.label_QC2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labeltname
            // 
            this.labeltname.AutoSize = true;
            this.labeltname.BackColor = System.Drawing.Color.Transparent;
            this.labeltname.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltname.ForeColor = System.Drawing.Color.White;
            this.labeltname.Location = new System.Drawing.Point(20, 35);
            this.labeltname.Name = "labeltname";
            this.labeltname.Size = new System.Drawing.Size(106, 22);
            this.labeltname.TabIndex = 1;
            this.labeltname.Text = "选择查询项：";
            // 
            // selecttable
            // 
            this.selecttable.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selecttable.FormattingEnabled = true;
            this.selecttable.Location = new System.Drawing.Point(132, 33);
            this.selecttable.Name = "selecttable";
            this.selecttable.Size = new System.Drawing.Size(203, 25);
            this.selecttable.TabIndex = 3;
            this.selecttable.SelectedIndexChanged += new System.EventHandler(this.selecttable_SelectedIndexChanged);
            // 
            // labelsettings
            // 
            this.labelsettings.AutoSize = true;
            this.labelsettings.BackColor = System.Drawing.Color.Transparent;
            this.labelsettings.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelsettings.ForeColor = System.Drawing.Color.White;
            this.labelsettings.Location = new System.Drawing.Point(347, 35);
            this.labelsettings.Name = "labelsettings";
            this.labelsettings.Size = new System.Drawing.Size(138, 22);
            this.labelsettings.TabIndex = 4;
            this.labelsettings.Text = "选择已有的设置：";
            // 
            // selectsetting
            // 
            this.selectsetting.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectsetting.FormattingEnabled = true;
            this.selectsetting.Location = new System.Drawing.Point(491, 33);
            this.selectsetting.Name = "selectsetting";
            this.selectsetting.Size = new System.Drawing.Size(175, 25);
            this.selectsetting.TabIndex = 5;
            this.selectsetting.SelectedIndexChanged += new System.EventHandler(this.selectsetting_SelectedIndexChanged);
            // 
            // labeltip
            // 
            this.labeltip.AutoSize = true;
            this.labeltip.BackColor = System.Drawing.Color.Transparent;
            this.labeltip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltip.ForeColor = System.Drawing.Color.White;
            this.labeltip.Location = new System.Drawing.Point(20, 81);
            this.labeltip.Name = "labeltip";
            this.labeltip.Size = new System.Drawing.Size(177, 19);
            this.labeltip.TabIndex = 6;
            this.labeltip.Text = "选择显示项和设置查询条件";
            // 
            // btnall
            // 
            this.btnall.FlatAppearance.BorderSize = 0;
            this.btnall.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnall.Location = new System.Drawing.Point(203, 76);
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(75, 29);
            this.btnall.TabIndex = 7;
            this.btnall.Text = "全  选";
            this.btnall.UseVisualStyleBackColor = true;
            this.btnall.Click += new System.EventHandler(this.btnall_Click);
            // 
            // btnallnot
            // 
            this.btnallnot.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnallnot.Location = new System.Drawing.Point(284, 76);
            this.btnallnot.Name = "btnallnot";
            this.btnallnot.Size = new System.Drawing.Size(75, 29);
            this.btnallnot.TabIndex = 8;
            this.btnallnot.Text = "全不选";
            this.btnallnot.UseVisualStyleBackColor = true;
            this.btnallnot.Click += new System.EventHandler(this.btnallnot_Click);
            // 
            // btndelsetting
            // 
            this.btndelsetting.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btndelsetting.Location = new System.Drawing.Point(591, 76);
            this.btndelsetting.Name = "btndelsetting";
            this.btndelsetting.Size = new System.Drawing.Size(75, 29);
            this.btndelsetting.TabIndex = 9;
            this.btndelsetting.Text = "删除设置";
            this.btndelsetting.UseVisualStyleBackColor = true;
            this.btndelsetting.Click += new System.EventHandler(this.btndelsetting_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnsave.Location = new System.Drawing.Point(510, 76);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 29);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "保存设置";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // selectlist
            // 
            this.selectlist.AutoScroll = true;
            this.selectlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectlist.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectlist.Location = new System.Drawing.Point(22, 153);
            this.selectlist.Name = "selectlist";
            this.selectlist.Size = new System.Drawing.Size(642, 427);
            this.selectlist.TabIndex = 12;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Image = global::AnyQuery.Properties.Resources.query;
            this.btnOK.Location = new System.Drawing.Point(50, 599);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 34);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "   确  定";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnexport
            // 
            this.btnexport.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnexport.Image = global::AnyQuery.Properties.Resources.Export;
            this.btnexport.Location = new System.Drawing.Point(298, 599);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(91, 34);
            this.btnexport.TabIndex = 15;
            this.btnexport.Text = "   输  出";
            this.btnexport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexport.UseVisualStyleBackColor = true;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btncancel.Image = global::AnyQuery.Properties.Resources.cancel;
            this.btncancel.Location = new System.Drawing.Point(546, 599);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(91, 34);
            this.btncancel.TabIndex = 16;
            this.btncancel.Text = "   退  出";
            this.btncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // label_Qname
            // 
            this.label_Qname.AutoSize = true;
            this.label_Qname.BackColor = System.Drawing.Color.Transparent;
            this.label_Qname.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Qname.ForeColor = System.Drawing.Color.White;
            this.label_Qname.Location = new System.Drawing.Point(78, 131);
            this.label_Qname.Name = "label_Qname";
            this.label_Qname.Size = new System.Drawing.Size(51, 19);
            this.label_Qname.TabIndex = 17;
            this.label_Qname.Text = "字段名";
            // 
            // label_QC1
            // 
            this.label_QC1.AutoSize = true;
            this.label_QC1.BackColor = System.Drawing.Color.Transparent;
            this.label_QC1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_QC1.ForeColor = System.Drawing.Color.White;
            this.label_QC1.Location = new System.Drawing.Point(268, 131);
            this.label_QC1.Name = "label_QC1";
            this.label_QC1.Size = new System.Drawing.Size(74, 19);
            this.label_QC1.TabIndex = 18;
            this.label_QC1.Text = "查询条件1";
            // 
            // label_QC2
            // 
            this.label_QC2.AutoSize = true;
            this.label_QC2.BackColor = System.Drawing.Color.Transparent;
            this.label_QC2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_QC2.ForeColor = System.Drawing.Color.White;
            this.label_QC2.Location = new System.Drawing.Point(462, 131);
            this.label_QC2.Name = "label_QC2";
            this.label_QC2.Size = new System.Drawing.Size(74, 19);
            this.label_QC2.TabIndex = 19;
            this.label_QC2.Text = "查询条件2";
            // 
            // SearchMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(687, 645);
            this.Controls.Add(this.label_QC2);
            this.Controls.Add(this.label_QC1);
            this.Controls.Add(this.label_Qname);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.selectlist);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btndelsetting);
            this.Controls.Add(this.btnallnot);
            this.Controls.Add(this.btnall);
            this.Controls.Add(this.labeltip);
            this.Controls.Add(this.selectsetting);
            this.Controls.Add(this.labelsettings);
            this.Controls.Add(this.selecttable);
            this.Controls.Add(this.labeltname);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(703, 683);
            this.MinimumSize = new System.Drawing.Size(703, 683);
            this.Name = "SearchMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchMain_FormClosing);
            this.Load += new System.EventHandler(this.SearchMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltname;
        private System.Windows.Forms.ComboBox selecttable;
        private System.Windows.Forms.Label labelsettings;
        private System.Windows.Forms.ComboBox selectsetting;
        private System.Windows.Forms.Label labeltip;
        private System.Windows.Forms.Button btnall;
        private System.Windows.Forms.Button btnallnot;
        private System.Windows.Forms.Button btndelsetting;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Panel selectlist;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label_Qname;
        private System.Windows.Forms.Label label_QC1;
        private System.Windows.Forms.Label label_QC2;
    }
}