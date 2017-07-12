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
    public partial class RolesSetting : Form
    {
        public RolesSetting()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        
        //取消按钮，关闭程序。
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //清空按钮，清空两个文本框的内容。
        private void buttonRefill_Click(object sender, EventArgs e)
        {
            textBoxRoleName.Text = null;
            textBoxRoleDescribe.Text = null;
            textBoxRoleName.Focus();
        }

        //确定按钮，将信息写入roles表完成角色设定。
        private void buttonOK_Click(object sender, EventArgs e)
        {
            string roleName = this.textBoxRoleName.Text;
            string roleDescribe = this.textBoxRoleDescribe.Text;

            string strSelectRoles = "select * from roles where role_name = '" + roleName + "'";
            string strUpdateDescribe = "update roles set role_describe" + " = '" + roleDescribe + "' where role_name = '" + roleName + "'";
            string strInsertRoles = "insert into roles values('" + getNumRoles() + "','" + roleName + "','" + roleDescribe + "')";
            SqlDataReader dr;

            try
            {
                if (getNumRoles() < 11)
                {
                    dr = dbHelp.SQLReadQuery(strSelectRoles);
                    if (dr.Read())
                    {
                        dr = dbHelp.SQLReadQuery(strUpdateDescribe);
                        MessageBox.Show("更新角色描述成功！", "提示");

                    }
                    else
                    {
                        dbHelp.SQLReadQuery(strInsertRoles);
                        MessageBox.Show("创建角色成功！", "提示");
                    }
                }
                else 
                {
                    MessageBox.Show("角色设定超过10个！不能操作！请联系系统管理员！","提示");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("数据库连接失败！角色设定失败！", "提示");
            }
            this.textBoxRoleName.Focus();
        }

        //获取roles表中的记录条数，返回下一条数据的role_id的值。
        private int getNumRoles()
        {
            SqlDataReader drNumRoles;
            string strSelectNumRoles = "select * from roles";
            int i = 0;

            drNumRoles = dbHelp.SQLReadQuery(strSelectNumRoles);
            while (drNumRoles.Read())
            {
                i++;
            }
            i++;
            return i;
        }

        //关闭中，将隐藏子窗口，显示主窗口。
        private void RolesSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
