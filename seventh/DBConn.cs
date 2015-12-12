using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace sixth
{
    class DBConn
    {
        //连接字符串
        public static string connStr = "Data Source=ZHANGYU;Initial Catalog=repair;Integrated Security=True;Pooling=False";
        public static SqlConnection conn = new SqlConnection(connStr);
        //读取数据
        public static DataSet getData(string sqlStr)
        {
            conn.Open();
            SqlDataAdapter ada = new SqlDataAdapter(sqlStr, conn);
            DataSet ds = new DataSet();
            ds.Clear();
            ada.Fill(ds); 
            conn.Close();
            return ds;
        }
        //更新数据
        public static DataSet upData(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sqlStr, conn);
                comm.CommandType = CommandType.Text;
                comm.ExecuteNonQuery();//执行sql语句
                conn.Close();
            }
            catch
            {
                conn.Close();
            }
            return null;
        }
        //判断是否更新记录
        public static bool PDData(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sqlStr, conn);
                comm.CommandType = CommandType.Text;
                comm.ExecuteNonQuery();//执行sql语句
                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }
    }
}
