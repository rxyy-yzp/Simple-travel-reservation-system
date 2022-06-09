using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace 简单旅行预订系统
{
    //数据库链接和操作
    class Dao
    {
        SqlConnection sc;
        public SqlConnection connect()
        {
            string str = @"Data Source=LAPTOP-CGU18OPD\SQLEXPRESS;Initial Catalog=TravelReservationSystem;Integrated Security=True";
            sc = new SqlConnection(str);//创建数据库链接
            sc.Open(); //打开数据库
            return sc; //返回数据库连接对象
        }
        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect()); //对数据库的操作
            return cmd;
        }
        public int Execute(string sql)
        {
            return command(sql).ExecuteNonQuery();//数据库更新操作
        }
        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();  //数据库读取操作

        }
        public void Daoclose()
        {
            sc.Close(); //关闭数据库链接
        }
    }
}
