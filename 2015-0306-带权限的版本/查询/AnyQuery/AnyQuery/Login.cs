using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AnyQuery
{
    public partial class Login : Form
    {
        private string userName;//保存用户输入的用户名。
        private string password;//保存用户输入的密码。
        private SqlDataReader drSelectUsers;//保存查询users表的SqlDataReader结果。
        private int flag = 0;//检验登录次数，超过三次密码错误将会退出程序。
        private SearchMain searchMain;

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void setUserName(string userName)
        {
            this.userName = userName;
        }

        public string getUserName()
        {
            return userName;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getPassword()
        {
            return password;
        }
  
        //验证登录次数，超过三次则强制退出。
        private void isFlag()
        {
            if (flag == 4)
            {
                MessageBox.Show("密码输入错误超过三次！" + Environment.NewLine + "即将退出程序!" + Environment.NewLine + "请联系系统管理员", "提示");
                this.Close();
            }
        }
 
        //登录第一步，验证是否存在该用户名。
        private Boolean isExistUserName()
        {
            string strSelectUserName = "select * from users where user_name = '" + getUserName() + "'";

            try
            {
                drSelectUsers = dbHelp.SQLReadQuery(strSelectUserName);
                if (!drSelectUsers.Read())
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("数据库连接失败！验证用户名失败！","提示");
                return false;
            }
            
        }

        //登录第二步，取得该用户的密码。
        private string getDbPassword()
        {
            string dbPassword = null;
            string strSelectUserName = "select * from users where user_name = '" + getUserName() + "'";

            drSelectUsers = dbHelp.SQLReadQuery(strSelectUserName);
            while (drSelectUsers.Read())
            {
                dbPassword = drSelectUsers["user_password"].ToString();
            }
            return dbPassword.Trim();
        }
   
        //登录按钮，登录第三步，验证用户名和密码是否对应，若对应则展示相应权限的主界面。
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            isFlag();
            setUserName(comboBoxUserName.Text);
            setPassword(textBoxPassword.Text);
            if (isExistUserName())
            {
                if (getDbPassword() == getPassword())
                {
                    updateUserFlag(getUserName());
                    MessageBox.Show("登录验证成功!");
                    searchMain = new SearchMain(getRightId());
                    this.Hide();
                    searchMain.Show();
                }
                else
                {
                    MessageBox.Show("密码错误！请重新输入", "提示");
                    new Login();
                    ++flag;
                }
            }
            else 
            {
                MessageBox.Show("不存在该用户！","提示");
            }
        }

        //更新用户登录的标识，以便下次登录时直接填入用户名的下拉框中。
        private void updateUserFlag(string userName)
        {
            string strUpdateUserFlag = "update users set flag = '1' where user_name = '" + userName + "'";

            try
            {
                dbHelp.SQLReadQuery(strUpdateUserFlag);
            }
            catch
            {
                MessageBox.Show("更新用户登录标识失败！请联系系统管理员","提示");
            }
        }

        //根据分配给用户名的角色权限查找其相应权限,返回一个去除空格的role_id。
        private string getRightId()
        {
            string role_id = null;
            string strSelectRoleId = "select role_id from users where user_name = '" + getUserName() + "'";
            SqlDataReader drSelectResourceOrder;

            try
            {
                drSelectResourceOrder = dbHelp.SQLReadQuery(strSelectRoleId);
                while (drSelectResourceOrder.Read())
                {
                    role_id = drSelectResourceOrder["role_id"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("查询users表中role_id失败！请联系系统管理员！", "提示");
            }
            return role_id.Trim();
        }

        //取消登录，即退出系统。
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //重填按钮，清空密码文本框。
        private void buttonRewrite_Click(object sender, EventArgs e)
        {
            this.textBoxPassword.Text = null;
            this.comboBoxUserName.Focus();
        }

        //取消按钮，退出登录程序。
        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //载入程序中，并将输入过的用户名填入下拉框中。
        private void Login_Load(object sender, EventArgs e)
        {
            selectOldUserName();
        }

        //读取输入过的用户名并填入下拉框中。
        private void selectOldUserName()
        {
            string strSelectOldUserName = "select user_name from users where flag = '1'";

            try
            {
                drSelectUsers = dbHelp.SQLReadQuery(strSelectOldUserName);
                while (drSelectUsers.Read())
                {
                    comboBoxUserName.Items.Add(drSelectUsers["user_name"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("读取users表中用户名失败！" + Environment.NewLine + "请联系系统管理员！", "提示");
            }
        }
    }
}
