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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            selectRole();
        }

        //程序启动后，立即读取roles表中的角色名填入下拉框。
        private void selectRole() 
        {
            string strSelectRole = "select * from roles";
            SqlDataReader drSelectRole;
            string str = null;

            drSelectRole = dbHelp.SQLReadQuery(strSelectRole);
            while (drSelectRole.Read())
            {
                //下一步主要是为了去除两个字符串的空格。
                str = drSelectRole["role_id"].ToString().Trim() + ": " +  drSelectRole["role_name"].ToString().Trim();
                comboBoxRole.Items.Add(str.Trim()); 
            }
            drSelectRole.Close();
        }

        //取消按钮，将关闭程序。
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //重写按钮，将清空用户名和密码的两个文本框。
        private void buttonRefill_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }
        //清空用户名和密码的两个文本框。
        public void clearTextBox()
        {
            textBoxUserName.Text = null;
            textBoxPassword.Text = null;
            textBoxUserName.Focus();
        }

        //确定按钮，将会把设置的用户名等信息写入users表，完成注册。
        private void buttonOK_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            string roleId = comboBoxRole.Text;

            SqlDataReader dr;
            string strSelectTable = "select * from users where user_name = '" + userName + "'";
            string strUpdatePassword = "update users set user_password" + " = '" + password + "' where user_name = '" + userName　+ "'";
            string strUpdateRoleId = "update users set role_id" + " = '" + roleId.Substring(0, 1) + "' where user_name = '" + userName + "'";
            string strInsert = "insert into users (user_id,user_name,user_password,role_id) values('" + (getNumUsers() + 1) + "','" + userName + "','" + password + "','" + roleId.Substring(0, 1) + "')";

            try
            {
                dr = dbHelp.SQLReadQuery(strSelectTable);
                if (dr.Read())
                {
                    dr = dbHelp.SQLReadQuery(strUpdatePassword + strUpdateRoleId);
                    MessageBox.Show("更新成功！", "提示");
                }
                else
                {
                    dbHelp.SQLReadQuery(strInsert);
                    MessageBox.Show("创建用户成功！", "提示");
                }
            }
            catch
            {
                MessageBox.Show("更新或创建用户！", "提示");
            }
            this.textBoxUserName.Focus();
        }

        //获取users表中的记录条数。
        private int getNumUsers()
        {
            SqlDataReader drNumUsers;
            string strSelectNumUsers = "select * from users";
            int i = 0;

            drNumUsers = dbHelp.SQLReadQuery(strSelectNumUsers);
            while(drNumUsers.Read())
            {
                i++;
            }
            return i;
        }

        //关闭中，将隐藏子窗口，显示主窗口。
        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
