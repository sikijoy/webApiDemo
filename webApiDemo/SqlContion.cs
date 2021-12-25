using Microsoft.Data.SqlClient;
using System.Data;

namespace webApiDemo
{
    public class SqlContion
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

    }
}
