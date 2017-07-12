using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuerySetting
{
    public partial class SearchSetting : Form
    {
        public SearchSetting()
        {
            InitializeComponent();
        }

        SqlDataReader dr;//结果集
        string sid = "";//选择的数据表的id
        string[] tp = new string[200];//保存字段的xusertype
        CheckBox[] cb = new CheckBox[200];//生成的复选框
        Label[] ll = new Label[200];//生成的标签
        TextBox[] tbc = new TextBox[200];//生成的中文文本框
        TextBox[] tbn = new TextBox[200];//生成的排序文本框
        int colnum = -1;//当前表的字段数

        //用来对sysobjects进行操作
        public void InitData()
        {
            try
            {
                //数据库连接
                dr = dbHelp.ConnectDBAndInitData(dbHelp.SInitData);
                if (dr == null)
                {
                    MessageBox.Show("数据库连接失败，请联系系统管理员！", "提示");
                    this.Close();
                }
                else
                {
                    GetTableName();
                }
            }
            catch
            {
                MessageBox.Show("数据库连接失败，请联系系统管理员！", "提示");
                this.Close();
            }
        }

        //获取表名
        public void GetTableName()
        {
            try
            {
                dr = dbHelp.SQLReadQuery(dbHelp.GetTableName);
                while (dr.Read())
                {
                    selecttable.Items.Add(dr["name"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("无法连接服务器！", "提示");
                return;
            }
        }


        //载入程序
        private void SearchSetting_Load(object sender, EventArgs e)
        {
            InitData();
        }

        //生成复选框
        public void CreateCheckBox(string xusertype,int i,string text,string flag)
        {
            tp[i] = xusertype;
            cb[i] = new CheckBox();
            cb[i].Text = text;
            cb[i].Left = 40;
            cb[i].Top = 15 + i * 30;
            cb[i].Height = 20;
            if (flag == "1")
            {
                cb[i].Checked = true;
            }
            else
            {
                cb[i].Checked = false;
            }
            selectlist.Controls.Add(cb[i]);
        }

        //生成标签
        public void CreateLabel(int i)
        {
            ll[i] = new Label();
            ll[i].Text = "中文名：";
            ll[i].Left = 120;
            ll[i].Top = 15 + i * 30;
            ll[i].Height = 20;
            ll[i].Width = 80;
            selectlist.Controls.Add(ll[i]);
        }

        //生成中文名文本框
        public void CreateTextBoxChinese(int i, string text)
        {
            tbc[i] = new TextBox();
            tbc[i].Text = text;
            tbc[i].Left = 170;
            tbc[i].Top = 12 + i * 30;
            tbc[i].Height = 21;
            tbc[i].Width = 120;
            selectlist.Controls.Add(tbc[i]);
        }

        //生成排序文本框
        public void CreateTextBoxNo(int i, string text)
        {
            tbn[i] = new TextBox();
            tbn[i].Text = text;
            tbn[i].Left = 310;
            tbn[i].Top = 12 + i * 30;
            tbn[i].Height = 21;
            tbn[i].Width = 25;
            selectlist.Controls.Add(tbn[i]);
        }

        //选择表及选择之后的操作
        private void selecttable_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectlist.Controls.Clear();
            int i = 0;
            string opsysobjects = "";//对sysobjects进行操作的SQL的语句
            string optablename = "";//对tablename进行操作的SQL的语句
            string sqlstring = "";//对syscolumns和columnname进行操作的SQL的语句

            opsysobjects = "select id from sysobjects where name = '" + selecttable.Text + "'";

            dr = dbHelp.SQLReadQuery(opsysobjects);
            while (dr.Read())
            {
                sid = dr["id"].ToString();
            }

            optablename = "select chinese from tablename where id = " + sid;//获取表的中文名

            sqlstring = "select A.name,A.xusertype,B.chinese,B.flag,B.no from syscolumns as A,columnname as B where A.id = " + sid + " and B.id = " + sid + " and B.colname = A.name";//获取表的各个字段

            dr = dbHelp.SQLReadQuery(optablename);
            while (dr.Read())
            {
                tablechinese.Text = dr["chinese"].ToString();
            }

            dr = dbHelp.SQLReadQuery(sqlstring);
            while (dr.Read())
            {
                CreateCheckBox(dr["xusertype"].ToString(),i, dr["name"].ToString(),dr["flag"].ToString());

                //CreateLabel(i);

                CreateTextBoxChinese(i, dr["chinese"].ToString());

                CreateTextBoxNo(i, dr["no"].ToString());

                i++;
            }

            colnum = i;
            selectlist.Focus();
        }

        //退出程序
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //保存操作
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlstring = "";//操作表的字符串
                string flag = "";//字段的标记
                string sname = "";//选择的表名

                flag = "0";
                sqlstring = "delete from columnname where id = " + sid;
                dbHelp.SQLNonQuery(sqlstring);
                
                sname = selecttable.Text;

                for (int i = 0; i < colnum; i++)
                {
                    int a = 0;
                    if ((tbn[i].Text.Length) == 0 || int.TryParse(tbn[i].Text, out a) == false)//排序默认置0
                    {
                        tbn[i].Text = "0";
                    }
                    if(cb[i].Checked == true)
                    {
                        flag = "1";
                        sqlstring = "insert into columnname (colname,id,chinese,type,flag,no) values('" + cb[i].Text + "'" + "," + sid + ",'" + tbc[i].Text + "'" + "," + tp[i] + ",'" + "1" + "'" + "," + tbn[i].Text + ")";
                    }
                    else
                    {
                        sqlstring = "insert into columnname (colname,id,chinese,type,flag,no) values('" + cb[i].Text + "'" + "," + sid + ",'" + tbc[i].Text + "'" + "," + tp[i] + ",'" + "0" + "'" + "," + tbn[i].Text + ")";
                    }
                    dbHelp.SQLNonQuery(sqlstring);

                    sqlstring = "update tablename set chinese = '" + tablechinese.Text + "'" + ",flag = '" + flag + "'" + "where id = " + sid;
                    dbHelp.SQLNonQuery(sqlstring);
                }
                MessageBox.Show("修改已保存！");
            }
            catch
            {
                MessageBox.Show("保存失败，请检查是否操作和输入正确！");
                return;
            }
        }
    }
}
