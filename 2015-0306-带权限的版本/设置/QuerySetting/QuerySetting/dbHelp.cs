using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace QuerySetting
{
    public class dbHelp
    {
        //读取注册列表获取数据库信息
        public static string Connection
        {
            get
            {
                //读取注册列表获取数据库连接字符串
                //RegistryKey hkml = Registry.LocalMachine;
                //RegistryKey software = hkml.OpenSubKey("SOFTWARE", true);
                //RegistryKey aimdir = software.OpenSubKey("dncs", true);
                //string ConnectionString = aimdir.GetValue("dbparm").ToString();

                //直接写数据库连接字符串
                //string ConnectionString = "data source = .; database = wfyb; integrated security = SSPI";

                //读取app.config的数据库连接字符串
                string ConnectionString = System.Configuration.ConfigurationManager.AppSettings["ConString"].ToString();

                return ConnectionString;
            }
        }

        //设置时初始化tablename和columnname表
        public static string SInitData
        {
            get
            {
                string CommandString = "IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = \'tablename\')\n"
                + "BEGIN\n"
                + "CREATE TABLE tablename(name varchar(128), id int, chinese varchar(50) DEFAULT \'\', flag char DEFAULT \'0\')\n"
                + "INSERT INTO tablename(name, id) SELECT name, id FROM sysobjects WHERE ((xtype = \'u\' or xtype = \'v\') AND name <> \'tablename\' AND name <> \'columnname\' AND name <> \'querycondition\')\n"
                + "ORDER BY name\n"
                + "END\n"
                + "IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = \'columnname\')\n"
                + "BEGIN\n"
                + "CREATE TABLE columnname(colname varchar(128), id int,chinese varchar(50) DEFAULT \'\',type int, flag char DEFAULT \'0\',no int)\n"
                + "INSERT INTO columnname (colname, id,type)\n"
                + "(SELECT c.name, c.id ,c.xusertype FROM syscolumns c INNER JOIN tablename o ON c.id = o.id)\n"
                + "END\n"
                + "delete from tablename where id  not in (select id from sysobjects WHERE xtype = \'u\' or xtype = \'v\')\n"
                + "delete from columnname where id  not in (select id from sysobjects WHERE xtype = \'u\' or xtype = \'v\')\n"
                + "SELECT name,id FROM sysobjects WHERE ((xtype = \'u\' or xtype = \'v\') and name <> \'tablename\' and name <> \'columnname\' and name <> \'querycondition\')\n"
                + "order by name\n";
                return CommandString;
            }
        }

        //查询时初始化数据表
        public static string MInitData
        {
            get
            {
                string CommandString = "IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = \'querycondition\')"
                + "CREATE TABLE querycondition(colname varchar(128), id int, condition1 varchar(50) DEFAULT \'\', condition2 varchar(50) DEFAULT \'\',setname varchar(50) DEFAULT \'\')"
                //+ "delete from querycondition where id  not in (select id from sysobjects WHERE xtype = \'u\')"
                + "update columnname set id = (select distinct o.id from sysobjects o,tablename t where columnname.id = t.id and t.name = o.name)"
                + "update querycondition set id = (select distinct o.id from sysobjects o,tablename t where querycondition.id = t.id and t.name=o.name)"
                + "update tablename set id = (select id from sysobjects s where tablename.name=s.name)"
                + "select chinese from tablename where flag = \'1\' order by chinese";
                return CommandString;
            }
        }

        //查询时检查是否存在users表,roles表和rights表
        public static string checkUsersRolesRights
        {
            get
            {
                string checkTable = "select * from sysobjects where name = 'users' and name ='rights' and name = 'roles'";
                return checkTable;
            }
        }

        //查询时创建users表,roles表和rights表
        public static string createUsersRolesRights
        {
            get
            {
                string createTable = "create table users(user_id char(20) not null primary key,user_name char(40) not null,user_password char(20) not null,role_id char(20) not null,flag char(10)) "
                    + " create table roles(role_id char(20) not null primary key,role_name char(40) not null,role_describe char(80) not null) "
                    + " create table rights(right_id char(20) not null primary key,table_name char(100) not null,role_id char(100) not null)";
                return createTable;
            }
        }

        public static string OpSetting
        {
            get
            {
                string CommandString = "delete from querycondition WHERE (setname is NULL)"
                + "SELECT DISTINCT setname FROM querycondition";
                return CommandString;
            }
        }

        //获取表名
        public static string GetTableName
        {
            get
            {
                string CommandString = "select name from tablename";
                return CommandString;
            }
        }

        //数据库连接
        public static SqlDataReader ConnectDBAndInitData(string sqlstring)
        {
            try
            {
                SqlConnection con;
                SqlCommand com;
                SqlDataReader dr;
                con = new SqlConnection(dbHelp.Connection);
                com = new SqlCommand(sqlstring, con);
                con.Open();
                if (con.State != ConnectionState.Open)
                {
                    return null;
                }
                else
                {
                    dr = com.ExecuteReader();
                    return dr;
                }
                //con.Close();
            }
            catch
            {
                return null;
            }
        }

        public static void SQLNonQuery(string sqlstring)
        {
            SqlConnection con;
            SqlCommand com;
            con = new SqlConnection(dbHelp.Connection);
            com = new SqlCommand(sqlstring, con);
            con.Open();
            com.ExecuteNonQuery();
            //con.Close();
        }

        public static SqlDataReader SQLReadQuery(string sqlstring)
        {
            try
            {
                SqlConnection con;
                SqlCommand com;
                SqlDataReader dr;
                con = new SqlConnection(dbHelp.Connection);
                com = new SqlCommand(sqlstring, con);
                con.Open();
                dr = com.ExecuteReader();
                return dr;
            }
            catch
            {
                return null;
            }
        }
    }
}
