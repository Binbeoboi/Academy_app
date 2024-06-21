using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doAn2.DBConfig
{
    public class Modify
    {
        private SqlCommand cmd;
        public int Excute(string query)
        {
            try
            {
                using (SqlConnection cnn = Connection.GetSqlConnection())
                {
                    cmd = new SqlCommand(query, cnn);
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
