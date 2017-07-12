using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuerySetting
{
    public partial class PermissionsSetting : Form
    {
        private int column = 0;//计数roles表的记录条数。
        CheckBox[] ckTableName = new CheckBox[100];

        public PermissionsSetting()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            selectTable();
        }

        //程序启动后，立即读取roles表中的表名的中文名填入下拉框。
        private void selectTable()
        {
            string strSelectTable = "select * from roles";
            SqlDataReader drSelectTable;

            try
            {
                drSelectTable = dbHelp.SQLReadQuery(strSelectTable);
                while (drSelectTable.Read())
                {
                    if (drSelectTable["role_name"].ToString() != "")
                    {
                        comboBoxSelectTableName.Items.Add(drSelectTable["role_name"].ToString().Trim());
                    }
                }
                drSelectTable.Close();
            }
            catch
            {
                MessageBox.Show("读取roles表失败！", "提示");
            }
        }

        //选中表之后，查询tablename表，并填充面板。
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strSelectRole = "select * from tablename where flag = '1'";
            SqlDataReader drSelectRole;
            int i = 0;
            column = 0;

            panelShowRoles.Controls.Clear();
            try
            {
                drSelectRole = dbHelp.SQLReadQuery(strSelectRole);
                while (drSelectRole.Read())
                {
                    showCheckBox(drSelectRole["chinese"].ToString().Trim(), i);
                    i++;
                    column++;
                }
                drSelectRole.Close();
                this.ckTableName[0].Focus();
            }
            catch
            {
                MessageBox.Show("数据库连接失败！查询tablename表失败！", "提示");
            }
        }

        //在面板上显示复选框和文本。
        private void showCheckBox(string text, int i)
        {
            ckTableName[i] = new CheckBox();
            ckTableName[i].Text = text;
            ckTableName[i].Top = 10 + i * 25;
            ckTableName[i].Left = 10;
            ckTableName[i].Height = 20;
            ckTableName[i].Checked = false;
            panelShowRoles.Controls.Add(ckTableName[i]);
        }

        //取消按钮，关闭程序。
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //重选按钮，清空面板。
        private void buttonReselect_Click(object sender, EventArgs e)
        {
            panelShowRoles.Controls.Clear();
            MessageBox.Show("请重新选中表！", "提示");
        }

        //确定按钮，将用户选择的信息写入rights表，实现对该表的权限设定。检查rights表是否有该表的设置，若有则更新，若没有则插入。
        private void buttonOK_Click(object sender, EventArgs e)
        {
            string roleName = comboBoxSelectTableName.Text.Trim();
            string strCheckRights = "select * from rights where role_id = (select role_id from roles where role_name = '" + roleName + "')";
            SqlDataReader dr;

            dr = dbHelp.SQLReadQuery(strCheckRights);
            if (dr.Read())
            {
                string strDelete = "delete * from rights where role_id = (select role_id from roles where role_name = '" + roleName + "')";
                dbHelp.SQLReadQuery(strDelete);
                MessageBox.Show("更新读取权限成功！", "提示");

            }
            else
            {
                insert(getRoleId(roleName));
                MessageBox.Show("创建读取权限成功！", "提示");
            }
            this.comboBoxSelectTableName.Focus();
        }

        //更新权限表数据,插入数据。
        private string insert(string role_id)
        {
            SqlDataReader dr;
            string strRoleId = null;

            for (int i = 0; i < column; i++)
            {
                if (ckTableName[i].Checked == true)
                {
                    string strInsertRights = "insert into rights values('" + (getNumRights() + 1) + "','" + ckTableName[i].Text + "','" + role_id + "')";

                    dr = dbHelp.SQLReadQuery(strInsertRights);
                }
            }
            return strRoleId;
        }

        //获取对应roles表的role_id。
        public string getRoleId(string roleName)
        {
            string strSql = "select role_id from roles where role_name = '" + roleName + "'";
            string roleId = null;
            SqlDataReader dr;

            dr = dbHelp.SQLReadQuery(strSql);
            while (dr.Read())
            {
                roleId = dr["role_id"].ToString().Trim();
            }
            return roleId;
        }

        //获取rights表中的记录条数。
        private int getNumRights()
        {
            SqlDataReader drNumRights;
            string strSelectNumRights = "select * from rights";
            int i = 0;

            try
            {
                drNumRights = dbHelp.SQLReadQuery(strSelectNumRights);
                while (drNumRights.Read())
                {
                    i++;
                }
                return i;
            }
            catch
            {
                MessageBox.Show("rights表中的记录条数读取失败！" + Environment.NewLine + "请联系系统管理员！", "提示");
                return 0;
            }
        }

        //关闭中，将隐藏子窗口，显示主窗口。
        private void PermissionsSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PermissionsSetting_Load(object sender, EventArgs e)
        {

        }
    }
}
