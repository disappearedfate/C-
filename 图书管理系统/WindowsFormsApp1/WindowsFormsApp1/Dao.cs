﻿using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Dao
    {
        SqlConnection sc;
        public SqlConnection connect()
        {
            string str = @"Data Source=LAPTOP-7CK6G355;Initial Catalog=BookDB;Integrated Security=True";//数据库连接
            sc = new SqlConnection(str);//创建数据库连接对象
            sc.Open();//打开数据库
            return sc;//返回数据库连接对象
        }
        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }
        public int Execute(string sql)//更新操作
        {
            return command(sql).ExecuteNonQuery();
        }
        public SqlDataReader read(string sql)//读取操作
        {
            return command(sql).ExecuteReader();
        }
        public void DaoClose()//关闭数据库连接
        {
            sc.Close();
        }
    }
}
