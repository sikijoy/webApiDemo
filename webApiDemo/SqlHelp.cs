using Microsoft.Data.SqlClient;
using System.Data;

namespace webApiDemo
{
    public class SqlHelp
    {
        public static  string ConnectionString = "server=127.0.0.1;database=TestDemo;uid=sa;pwd=123456";
        public DataRow Command(string sql)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    DataTable res = ds.Tables[0];
                    DataRow dr = res.Rows[0];
                    conn.Close();
                    conn.Dispose();
                    return dr;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public DataTable ExecuteTable(string cmdText, SqlParameter [] sqlParameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd); 
                sda.Fill(dt);   
                cmd.CommandText = cmdText;
                return ds.Tables[0];
            }

        }

        public int ExecuteNonQuery(string cmdText, SqlParameter[] sqlParameters)
        {
            return ExecuteNonQuery(cmdText, sqlParameters,);
        }


    }
}
