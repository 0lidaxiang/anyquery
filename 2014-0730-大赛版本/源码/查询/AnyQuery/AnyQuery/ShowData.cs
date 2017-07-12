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
    public partial class ShowData : Form
    {
        public ShowData()
        {
            InitializeComponent();
        }

        SqlConnection con;//数据库连接
        SqlDataReader dr;//结果集

        //统计输出
        private void btnexport_Click(object sender, EventArgs e)
        {
            try
            {
                string ccol = "";//查询的字符串
                string ccon = "";//查询的字符串
                string sqlstring = "";//汇总统计语句

                if (selectsum.Text == "")
                {
                    MessageBox.Show("未选择统计项！", "提示");
                    return;
                }
                if (selectcount.Text == "")
                {
                    MessageBox.Show("未选择统计项,将只按照汇总项汇总！", "提示");
                    //return;
                }
                if (selectsum.Text != "")
                {
                    sqlstring = "select colname from columnname where chinese = '" + selectcount.Text + "'" + " and id = " + SearchMain.sid;
                    dr = dbHelp.SQLReadQuery(sqlstring);
                    while (dr.Read())
                    {
                        ccol = ccol + dr["colname"].ToString() + " as " + selectcount.Text + ",";
                        ccon = SearchMain.scon;
                        if (ccon.Length == 0)
                        {
                            ccon = ccon + " group by " + dr["colname"].ToString();
                        }
                        else
                        {
                            ccon = " where " + ccon + " group by " + dr["colname"].ToString();
                        }
                    }
                    sqlstring = "select colname from columnname where chinese = '" + selectsum.Text + "'" + " and id = " + SearchMain.sid;
                    dr = dbHelp.SQLReadQuery(sqlstring);
                    while (dr.Read())
                    {
                        ccol = ccol + "sum(" + dr["colname"].ToString() + ") as " + selectsum.Text + "累计";
                        if (selectsum.Text != "")
                        {
                            sqlstring = "select " + ccol + " from " + SearchMain.selname.ToString() + ccon;
                        }
                        else
                        {
                            sqlstring = "select " + ccol + " from " + SearchMain.selname.ToString();
                        }
                    }
                }

                ExportData edform = new ExportData(sqlstring);
                edform.ShowDialog();
            }
            catch
            {
                MessageBox.Show("统计输出异常！", "提示");
                return;
            }
        }

        //初始化界面
        private void ShowData_Load(object sender, EventArgs e)
        {
            ShowResult();
            CountData();
        }

        //展示查询结果
        public void ShowResult()
        {
            try
            {
                DataSet ds;
                con = new SqlConnection(dbHelp.Connection);
                string sql = SearchMain.showsqlstring.ToString();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                ds = new DataSet();
                da.Fill(ds);
                selectresult.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("查询数据异常！", "提示");
                return;
            }
        }

        //初始化筛选统计选项
        public void CountData()
        {
            for (int i = 0; i < SearchMain.colnum; i++)
            {
                if ((SearchMain.cb[i].Checked == true) && ((SearchMain.tp[i] == "62") || (SearchMain.tp[i] == "56") || (SearchMain.tp[i] == "108") || (SearchMain.tp[i] == "106")))
                {
                    selectsum.Items.Add(SearchMain.cb[i].Text);
                }

                if ((SearchMain.cb[i].Checked == true) && (SearchMain.tp[i] != "62") && (SearchMain.tp[i] != "56") && (SearchMain.tp[i] != "108") && (SearchMain.tp[i] != "106"))
                {
                    selectcount.Items.Add(SearchMain.cb[i].Text);
                }
            }
        }

        //统计确认
        private void btnok_Click(object sender, EventArgs e)
        {
            try
            {
                string ccol = "";//查询的字符串
                string ccon = "";//查询的字符串
                string sqlstring = "";//汇总统计语句

                if (selectsum.Text == "")
                {
                    MessageBox.Show("未选择统计项！", "提示");
                    return;
                }
                if (selectcount.Text == "")
                {
                    MessageBox.Show("未选择统计项,将只按照汇总项汇总！", "提示");
                    //return;
                }
                if (selectsum.Text != "")
                {
                    sqlstring = "select colname from columnname where chinese = '" + selectcount.Text + "'" + " and id = " + SearchMain.sid;
                    dr = dbHelp.SQLReadQuery(sqlstring);
                    while (dr.Read())
                    {
                        ccol = ccol + dr["colname"].ToString() + " as " + selectcount.Text + ",";
                        ccon = SearchMain.scon;
                        if (ccon.Length == 0)
                        {
                            ccon = ccon + " group by " + dr["colname"].ToString();
                        }
                        else
                        {
                            ccon = " where " + ccon + " group by " + dr["colname"].ToString();
                        }
                    }
                    sqlstring = "select colname from columnname where chinese = '" + selectsum.Text + "'" + " and id = " + SearchMain.sid;
                    dr = dbHelp.SQLReadQuery(sqlstring);
                    while (dr.Read())
                    {
                        ccol = ccol + "sum(" + dr["colname"].ToString() + ") as " + selectsum.Text + "累计";
                        if (selectsum.Text != "")
                        {
                            sqlstring = "select " + ccol + " from " + SearchMain.selname.ToString() + ccon;
                        }
                        else
                        {
                            sqlstring = "select " + ccol + " from " + SearchMain.selname.ToString();
                        }
                    }
                    DataSet ds;
                    con = new SqlConnection(dbHelp.Connection);
                    string sql = sqlstring;
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds);
                    selectresult.DataSource = ds.Tables[0];
                }
            }
            catch
            {
                MessageBox.Show("统计异常！", "提示");
                return;
            }
        }
    }
}
