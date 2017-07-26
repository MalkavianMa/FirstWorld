using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DLL
{
  public  class DBHelper
    {

        static string conStr = "server=.;database=CalculateResult;uid=sa;pwd=1989789mjw";

        #region 执行sql语句，返回受影响的行数
        /// <summary>
        /// 执行sql语句，返回受影响的行数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="typename"></param>
        /// <param name="para"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, CommandType typename, SqlParameter[] para)
        {
            int count = 0;
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = typename;
                if (para != null)
                {
                    cmd.Parameters.AddRange(para);





                }


                if (!string.IsNullOrEmpty(sql))
                {
                    try
                    {
                        conn.Open();
                        count = cmd.ExecuteNonQuery();

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            return count;
        }



        #endregion
        #region 执行SQL语句，返回Dataset
        /// <summary>
        /// 执行SQL语句，返回Dataset
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="typename"></param>
        /// <param name="para"></param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(string sql, CommandType typename, SqlParameter[] para)
        {
            DataSet ds = null;
            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = typename;
            if (para != null)
            {
                cmd.Parameters.AddRange(para);
            }

            if (!string.IsNullOrEmpty(sql))
            {
                ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }

            return ds;
        }
        #endregion

        #region 执行T-SQL语句并返回DataTable对象
        /// <summary>
        /// 执行T-SQL语句并返回DataTable对象
        /// </summary>
        /// <param name="sql">sql语句或存储过程名</param>
        /// <param name="typeName">命令字符串类型</param>
        /// <param name="parames">参数</param>
        /// <returns>DataTable对象</returns>
        public static DataTable ExecuteDataTable(string sql, CommandType typeText, SqlParameter[] parames)
        {
            SqlConnection conn = new SqlConnection(conStr);
            DataTable dt = new DataTable();
            SqlCommand comm = new SqlCommand();
            comm.CommandText = sql;
            comm.CommandType = typeText;
            comm.Connection = conn;

            if (parames != null && parames.Length > 0)
            {
                for (int i = 0; i < parames.Length; i++)
                {
                    comm.Parameters.Add(parames[i]);
                }
            }
            if (string.IsNullOrEmpty(sql))
            {
                dt = null;
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter(comm);
                da.Fill(dt);
            }
            return dt;
        }
        #endregion
    }
}
