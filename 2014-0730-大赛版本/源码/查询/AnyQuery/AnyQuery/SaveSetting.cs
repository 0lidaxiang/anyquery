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
    public partial class SaveSetting : Form
    {
        public SaveSetting()
        {
            InitializeComponent();
        }

        SqlDataReader dr;//结果集

        //取消
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //获取设置选项
        public void GetSetting()
        {
            try
            {
                selectname.Text = "";
                selectname.Items.Clear();
                dr = dbHelp.SQLReadQuery(dbHelp.OpSetting);
                while (dr.Read())
                {
                    selectname.Items.Add(dr["setname"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("无法连接服务器！", "提示");
                this.Close();
            }
        }

        //初始化窗体数据
        private void SaveSetting_Load(object sender, EventArgs e)
        {
            GetSetting();
        }

        //确定
        private void btnsave_Click(object sender, EventArgs e)
        {
            string sqlstring = "";
            string str = "";

            if (selectname.Text.Length == 0)
            {
                MessageBox.Show("请输入设置名！","提示");
                return;
            }
            else
            {
                try
                {
                    sqlstring = "delete from querycondition where setname = '" + selectname.Text + "'";
                    dbHelp.SQLNonQuery(sqlstring);

                    sqlstring = "delete from querycondition where id = " + SearchMain.sid + " and setname = '" + selectname.Text + "'";
                    dbHelp.SQLNonQuery(sqlstring);

                    for (int i = 0; i < SearchMain.colnum; i++)
                    {
                        if (SearchMain.cb[i].Checked == true)
                        {
                            sqlstring = "select colname from columnname where chinese = '" + SearchMain.cb[i].Text + "'" + " and id = " + SearchMain.sid;
                            dr = dbHelp.SQLReadQuery(sqlstring);
                            while (dr.Read())
                            {
                                if (SearchMain.tp[i] == "61")
                                {
                                    str = "insert into querycondition(colname,id,condition1,condition2,setname) values ( '" + dr["colname"].ToString() + "'" + "," + SearchMain.sid + ",'" + SearchMain.dp1[i].Text.ToString() + "'" + ",'" + SearchMain.dp2[i].Text.ToString() + "'" + ",'" + selectname.Text + "'" + " )";
                                }
                                else
                                {
                                    str = "insert into querycondition(colname,id,condition1,condition2,setname) values ( '" + dr["colname"].ToString() + "'" + "," + SearchMain.sid + ",'" + SearchMain.tb1[i].Text.ToString() + "'" + ",'" + SearchMain.tb2[i].Text.ToString() + "'" + ",'" + selectname.Text + "'" + " )";
                                }
                            }
                        }
                        else
                        {
                            str = "";
                        }

                        if(str != "")
                        {
                            dbHelp.SQLNonQuery(str);
                        }
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    this.Dispose();
                }
                catch
                {
                    MessageBox.Show("请选择表、字段或表名不正确！", "提示");
                    return;
                }
            }
        }
    }
}
