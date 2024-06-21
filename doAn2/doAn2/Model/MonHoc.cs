using doAn2.DBConfig;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doAn2.Model
{
    public class MonHoc
    {
        public int STT {  get; set; } 
        public string Ma {get;set;}
        public string Ten{get;set;}
        public int LuongCB{ get; set; }

        public List<MonHoc> lstMonHoc()
        {
            List<MonHoc> lst = new List<MonHoc>();
            string query = "SELECT * FROM MonHoc;";

            try
            {
                using (SqlConnection cnn = Connection.GetSqlConnection())
                {
                    SqlCommand sqlCommand = new SqlCommand(query, cnn);
                    SqlDataReader sqlData = sqlCommand.ExecuteReader();
                    int i = 0;
                    while (sqlData.Read())
                    {
                        lst.Add(new MonHoc
                        {
                            STT = i++,
                            Ma = sqlData.GetString(0),
                            Ten = sqlData.GetString(1),
                            LuongCB = sqlData.GetInt32(2),
                        }) ;
                    }
                }
                return lst;
            }
            catch
            {
                return null;
            }
        }

        Modify db = new Modify();
        public bool ThemMonHoc(MonHoc monHoc)
        {
            string query = $"INSERT INTO MonHoc VALUES (N'{monHoc.Ma.ToUpper().Trim()}',N'{monHoc.Ten}', {monHoc.LuongCB});";

            int affected = db.Excute(query);
            return affected == 1;
        }

        public bool XoaMonHoc(string ID)
        {
            string query = $"DELETE FROM MonHoc WHERE maMon = N'{ID}'";

            int affected = db.Excute(query);
            return affected == 1;
        }

        public bool SuaMonHoc(MonHoc monHoc)
        {
            string query = $"UPDATE MonHoc SET " +
                $"maMon = N'{monHoc.Ma}'," +
                $"tenMon = N'{monHoc.Ten}'," +
                $"luongCB = {monHoc.LuongCB} " +
                $"WHERE maMon = N'{monHoc.Ma}'";

            int affected = db.Excute(query);
            return affected == 1;
        }
    }
}
