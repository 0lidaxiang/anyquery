using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AnyQuery
{
    public partial class SearchMain : Form
    {
        public SearchMain()
        {
            InitializeComponent();
        }

        SqlDataReader dr;//结果集
        public static string sid = "";//选择的数据表的id
        public static string[] tp = new string[200];//保存字段的xusertype
        public static CheckBox[] cb = new CheckBox[200];//生成的复选框
        string[] IsChecked = new string[200];//复选框选中状态
        public static TextBox[] tb1 = new TextBox[200];//生成的条件1文本框
        public static TextBox[] tb2 = new TextBox[200];//生成的条件2文本框
        public static DateTimePicker[] dp1 = new DateTimePicker[200];//生成的条件1日期框
        public static DateTimePicker[] dp2 = new DateTimePicker[200];//生成的条件2日期框
        public static int colnum = -1;//当前表的字段数
        public static string showsqlstring = "";//展示界面的查询语句
        public static string scol = "";//查询的字符串
        public static string scon = "";//查询的字符串
        public static string selname = "";//查询的表
        public static string selnameCN = "";//查询的表的中文名

        //初始化数据表，填充表选项
        public void ConnectDBAndInitData()
        {
            try
            {
                selecttable.Items.Clear();
                dr = dbHelp.ConnectDBAndInitData(dbHelp.MInitData);
                if (dr == null)
                {
                    MessageBox.Show("数据库连接失败，请联系系统管理员！", "提示");
                    this.Close();
                }
                else
                {
                    while (dr.Read())
                    {
                        selecttable.Items.Add(dr["chinese"].ToString());
                    }

                    InitTableData();

                    GetSettings();
                }
            }
            catch
            {
                MessageBox.Show("数据库连接失败，请联系系统管理员！", "提示");
                this.Close();
            }
        }

        public void InitTableData()
        {
            try
            {
                dbHelp.SQLNonQuery(dbHelp.SInitData);
            }
            catch
            {
                MessageBox.Show("数据库错误！", "提示");
                return;
            }
        }

        //获取设置选项
        public void GetSettings()
        {
            try
            {
                selectsetting.Text = "";
                selectsetting.Items.Clear();
                dr = dbHelp.SQLReadQuery(dbHelp.OpSetting);
                while (dr.Read())
                {
                    selectsetting.Items.Add(dr["setname"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("无法连接服务器！", "提示");
                this.Close();
            }
        }

        //载入程序
        private void SearchMain_Load(object sender, EventArgs e)
        {
            ConnectDBAndInitData();
        }

        //保存查询条件
        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveSetting saveform = new SaveSetting();
            DialogResult result = saveform.ShowDialog();
            if (result == DialogResult.OK)
            {
                ConnectDBAndInitData();
            }
        }

        //删除查询条件
        private void btndelsetting_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlstring;
                sqlstring = "delete from querycondition where setname = '" + selectsetting.Text + "'";
                dbHelp.SQLNonQuery(sqlstring);
                GetSettings();
            }
            catch
            {
                MessageBox.Show("删除失败！", "提示");
                return;
            }
        }

        //确定查询
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int n = 0;//查询到的记录条数
                showsqlstring = "";//展示界面的查询语句
                scol = "";//查询的字符串
                scon = "";//查询的字符串
                selname = "";//查询的表
                string sqlstring = "";

                sqlstring = "select name from tablename where chinese = '" + selecttable.Text + "'";
                dr = dbHelp.SQLReadQuery(sqlstring);
                while (dr.Read())
                {
                    selname = dr["name"].ToString();
                }

                for (int i = 0; i < colnum; i++)
                {
                    if (cb[i].Checked == true)
                    {
                        sqlstring = "select colname from columnname where chinese = '" + cb[i].Text + "'" + " and id = " + sid;
                        dr = dbHelp.SQLReadQuery(sqlstring);
                        while (dr.Read())
                        {
                            if ((tp[i] != "61") && (tp[i] != "62") && (tp[i] != "56") && (tp[i] != "108") && (tp[i] != "106"))
                            {
                                scol = scol + " left(" + dr["colname"].ToString() + ",len(" + dr["colname"].ToString() + " ))" + " as " + cb[i].Text + ",";
                            }
                            else
                            {
                                scol = scol + dr["colname"].ToString() + " as " + cb[i].Text + ",";
                            }

                            //获取查询时间条件字段
                            if (tp[i] == "61")
                            {
                                if (dp1[i].Text.Length > 0)
                                {
                                    if (dp2[i].Text.Length == 0)
                                    {
                                        scon = scon + dr["colname"].ToString() + " = '" + dp1[i].Text + "'" + " and ";
                                    }
                                    else
                                    {
                                        scon = scon + dr["colname"].ToString() + " between '" + dp1[i].Text + "'" + " and '" + dp2[i].Text + "'" + "and ";
                                    }
                                }
                            }


                            //获取查询其他条件字段
                            else if (tp[i] == "62" || tp[i] == "56" || tp[i] == "108" || tp[i] == "106")
                            {
                                if (tb1[i].Text.Length > 0)
                                {
                                    if (tb2[i].Text.Length == 0)
                                    {
                                        scon = scon + dr["colname"].ToString() + " = " + tb1[i].Text + " and ";
                                    }
                                    else
                                    {
                                        scon = scon + dr["colname"].ToString() + " between " + tb1[i].Text + " and " + tb2[i].Text + " and ";
                                    }
                                }
                            }
                            else
                            {
                                if (tb1[i].Text.Length > 0)
                                {
                                    if (tb2[i].Text.Length == 0)
                                    {
                                        scon = scon + dr["colname"].ToString() + " like '" + tb1[i].Text + "'" + " and ";
                                    }
                                    else
                                    {
                                        scon = scon + dr["colname"].ToString() + " between '" + tb1[i].Text + "'" + " and '" + tb2[i].Text + "'" + " and ";
                                    }
                                }
                            }
                        }
                    }
                }

                if (scol.Length > 0)
                {
                    scol = scol.Substring(0, scol.Length - 1);
                }
                if (scon.Length > 0)
                {
                    scon = scon.Substring(0, scon.Length - 4);
                }

                if (scon.Length > 0)
                {
                    sqlstring = "select " + scol + " from " + selname + " where " + scon;
                }
                else
                {
                    sqlstring = "select " + scol + " from " + selname;
                }

                dr = dbHelp.SQLReadQuery(sqlstring);
                while (dr.Read())
                {
                    n++;
                }

                MessageBox.Show("有" + n + "条记录。", "提示");

                ShowData showform = new ShowData();
                showsqlstring = sqlstring;
                showform.ShowDialog();
            }
            catch
            {
                MessageBox.Show("没有选择表或字段！", "提示");
                return;
            }
        }

        //退出程序
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //输出
        private void btnexport_Click(object sender, EventArgs e)
        {
            try
            {
                scol = "";//查询的字符串
                scon = "";//查询的字符串
                selname = "";//查询的表
                string sqlstring = "";//查询语句

                sqlstring = "select name from tablename where chinese = '" + selecttable.Text + "'";
                dr = dbHelp.SQLReadQuery(sqlstring);
                while (dr.Read())
                {
                    selname = dr["name"].ToString();
                }

                for (int i = 0; i < colnum; i++)
                {
                    if (cb[i].Checked == true)
                    {
                        sqlstring = "select colname,type from columnname where chinese = '" + cb[i].Text + "'" + " and id = " + sid;
                        dr = dbHelp.SQLReadQuery(sqlstring);
                        while (dr.Read())
                        {
                            scol = scol + dr["colname"].ToString() + " as " + cb[i].Text + ",";

                            //获取查询时间字段
                            if (tp[i] == "61")
                            {
                                if (dp1[i].Text.Length > 0)
                                {
                                    if (dp2[i].Text.Length == 0)
                                    {
                                        scon = scon + dr["colname"].ToString() + " = '" + dp1[i].Text + "'" + " and ";
                                    }
                                    else
                                    {
                                        scon = scon + dr["colname"].ToString() + " between '" + dp1[i].Text + "'" + " and '" + dp2[i].Text + "'" + "and ";
                                    }
                                }
                            }

                            //获取查询其他条件字段
                            else if (tp[i] == "62" || tp[i] == "56" || tp[i] == "108" || tp[i] == "106" || tp[i] == "59")
                            {
                                if (tb1[i].Text.Length > 0)
                                {
                                    if (tb2[i].Text.Length == 0)
                                    {
                                        scon = scon + dr["colname"].ToString() + " = " + tb1[i].Text + " and ";
                                    }
                                    else
                                    {
                                        scon = scon + dr["colname"].ToString() + " between " + tb1[i].Text + " and " + tb2[i].Text + " and ";
                                    }
                                }
                            }
                            else
                            {
                                if (tb1[i].Text.Length > 0)
                                {
                                    if (tb2[i].Text.Length == 0)
                                    {
                                        scon = scon + dr["colname"].ToString() + " like '" + tb1[i].Text + "'" + " and ";
                                    }
                                    else
                                    {
                                        scon = scon + dr["colname"].ToString() + " between '" + tb1[i].Text + "'" + " and '" + tb2[i].Text + "'" + " and ";
                                    }
                                }
                            }
                        }
                    }
                }

                if (scol.Length > 0)
                {
                    scol = scol.Substring(0, scol.Length - 1);
                }
                if (scon.Length > 0)
                {
                    scon = scon.Substring(0, scon.Length - 4);
                }

                if (scon.Length > 0)
                {
                    sqlstring = "select " + scol + " from " + selname + " where " + scon;
                }
                else
                {
                    sqlstring = "select " + scol + " from " + selname;
                }

                dbHelp.SQLNonQuery(sqlstring);

                ExportData edform = new ExportData(sqlstring);
                edform.ShowDialog();
            }
            catch
            {
                MessageBox.Show("没有选择表或字段！", "提示");
                return;
            }
        }

        //全选
        private void btnall_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < colnum; i++)
            {
                cb[i].Checked = true;
            }
        }

        //全不选
        private void btnallnot_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < colnum; i++)
            {
                cb[i].Checked = false;
            }
        }

        //生成复选框
        public void CreateCheckBox(int i, string text, string check)
        {
            cb[i] = new CheckBox();
            cb[i].Text = text;
            cb[i].Left = 50;
            cb[i].Top = 15 + i * 32;
            cb[i].Height = 25;
            if (check == "true")
            {
                cb[i].Checked = true;
            }
            else
            {
                cb[i].Checked = false;
            }
            selectlist.Controls.Add(cb[i]);
        }

        //生成的条件1文本框
        public void CreateTextBox1(int i, string text)
        {
            tb1[i] = new TextBox();
            tb1[i].Text = text;
            tb1[i].Left = 180;
            tb1[i].Top = 12 + i * 32;
            tb1[i].Height = 21;
            tb1[i].Width = 200;
            selectlist.Controls.Add(tb1[i]);
        }

        //生成的条件2文本框
        public void CreateTextBox2(int i, string text)
        {
            tb2[i] = new TextBox();
            tb2[i].Text = text;
            tb2[i].Left = 380;
            tb2[i].Top = 12 + i * 32;
            tb2[i].Height = 21;
            tb2[i].Width = 200;
            selectlist.Controls.Add(tb2[i]);
        }

        //生成的条件1日期框
        public void CreateDateBox1(int i, string date)
        {
            dp1[i] = new DateTimePicker();
            dp1[i].Left = 180;
            dp1[i].Top = 13 + i * 32;
            dp1[i].Height = 21;
            dp1[i].Width = 200;
            dp1[i].Format = DateTimePickerFormat.Custom;
            dp1[i].CustomFormat = "yyyy-MM-dd hh:mm:ss";
            dp1[i].Text = date;
            selectlist.Controls.Add(dp1[i]);
        }

        //生成的条件2日期框
        public void CreateDateBox2(int i, string date)
        {
            dp2[i] = new DateTimePicker();
            dp2[i].Left = 380;
            dp2[i].Top = 13 + i * 32;
            dp2[i].Height = 21;
            dp2[i].Width = 200;
            dp2[i].Format = DateTimePickerFormat.Custom;
            dp2[i].CustomFormat = "yyyy-MM-dd hh:mm:ss";
            selectlist.Controls.Add(dp2[i]);
        }

        //选择的设置
        private void selectsetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectlist.Controls.Clear();
            int i = 0;
            string sqlstring = "";//对表进行操作的SQL的语句
            string sqlsetting = "";//查询设置
            try
            {
                sqlstring = "select id from tablename where chinese = '" + selecttable.Text + "'";

                dr = dbHelp.SQLReadQuery(sqlstring);
                while (dr.Read())
                {
                    sid = dr["id"].ToString();
                }

                sqlstring = "select colname,chinese,type from columnname where id = " + sid + " and flag = '" + "1" + "'" + " order by no";

                dr = dbHelp.SQLReadQuery(sqlstring);
                while (dr.Read())
                {
                    tp[i] = dr["type"].ToString();

                    sqlsetting = "select condition1,condition2 from querycondition where colname = '" + dr["colname"].ToString() + "'" + " and id = " + sid + " and setname = '" + selectsetting.Text + "'";

                    SqlDataReader dr2 = dbHelp.SQLReadQuery(sqlsetting);

                    while (dr2.Read())
                    {
                        IsChecked[i] = "";
                        IsChecked[i] = "true";
                        CreateCheckBox(i, dr["chinese"].ToString(), "true");

                        if (tp[i] == "61")
                        {
                            CreateDateBox1(i, dr2["condition1"].ToString());
                            CreateDateBox2(i, dr2["condition2"].ToString());
                        }
                        else
                        {
                            CreateTextBox1(i, dr2["condition1"].ToString());
                            CreateTextBox2(i, dr2["condition2"].ToString());
                        }
                    }

                    if (IsChecked[i] != "true")
                    {
                        CreateCheckBox(i, dr["chinese"].ToString(), "false");

                        if (tp[i] == "61")
                        {
                            CreateDateBox1(i, "");
                            CreateDateBox2(i, "");
                        }
                        else
                        {
                            CreateTextBox1(i, "");
                            CreateTextBox2(i, "");
                        }
                    }

                    IsChecked[i] = "";
                    i++;
                }

                selectlist.Focus();
            }
            catch
            {
                MessageBox.Show("读取设置异常！", "提示");
                return;
            }
        }

        //选择表及选择之后的操作
        private void selecttable_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selnameCN = "";
                selnameCN = selecttable.Text;
                selectlist.Controls.Clear();
                colnum = 0;
                int i = 0;
                string sqlstring = "";//对表进行操作的SQL的语句

                sqlstring = "select id from tablename where chinese = '" + selecttable.Text + "'";

                dr = dbHelp.SQLReadQuery(sqlstring);
                while (dr.Read())
                {
                    sid = dr["id"].ToString();
                }

                sqlstring = "select colname,chinese,type from columnname where id = " + sid + " and flag = '" + "1" + "'" + " order by no";

                dr = dbHelp.SQLReadQuery(sqlstring);
                while (dr.Read())
                {
                    tp[i] = dr["type"].ToString();

                    CreateCheckBox(i, dr["chinese"].ToString(), "false");

                    if (tp[i] == "61")
                    {
                        CreateDateBox1(i, "");
                        CreateDateBox2(i, "");
                    }
                    else
                    {
                        CreateTextBox1(i, "");
                        CreateTextBox2(i, "");
                    }

                    i++;
                }

                colnum = i;
                selectlist.Focus();
            }
            catch
            {
                MessageBox.Show("读取数据异常！", "提示");
                return;
            }
        }
    }
}
