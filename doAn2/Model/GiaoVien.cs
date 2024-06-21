using doAn2.DBConfig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doAn2.Model
{
    public class GiaoVien
    {
        public string Ma {get;set;}
        public string Ten{get;set;}
        public DateTime NgaySinh{get;set;}
        public string DiaChi{get;set;}
        [Browsable(false)]
        public string MaMonHoc{get;set;}
        public string TenMonHoc{get;set;}
        public string SDT{get;set;}
        public string Email{get;set;}
        public int luongCB{ get; set; }

        public List<GiaoVien> lstGiaoVien()
        {
            List<GiaoVien> lst = new List<GiaoVien>();
            string query = "SELECT GiaoVien.*, MonHoc.luongCB, MonHoc.tenMon FROM GiaoVien JOIN MonHoc ON GiaoVien.MaMon = MonHoc.maMon;";

            try
            {
                using (SqlConnection cnn = Connection.GetSqlConnection())
                {
                    SqlCommand sqlCommand = new SqlCommand(query, cnn);
                    SqlDataReader sqlData = sqlCommand.ExecuteReader();
                    while (sqlData.Read())
                    {
                        lst.Add(new GiaoVien
                        {
                            Ma = sqlData.GetString(0),
                            Ten = sqlData.GetString(1),
                            NgaySinh = DateTime.Parse(sqlData.GetString(2)),
                            DiaChi = sqlData.GetString(3),
                            MaMonHoc = sqlData.GetString(4),
                            SDT = sqlData.GetString(5),
                            Email = sqlData.GetString(6),
                            luongCB = sqlData.GetInt32(7),
                            TenMonHoc = sqlData.GetString(8),
                        });
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
        public bool ThemGiaoVien(GiaoVien giaoVien)
        {
            string query = $"INSERT INTO GiaoVien VALUES (N'{giaoVien.Ma.ToUpper().Trim()}',N'{giaoVien.Ten}',N'{giaoVien.NgaySinh.ToString("dd/MM/yyyy")}',N'{giaoVien.DiaChi}', N'{giaoVien.MaMonHoc}',N'{giaoVien.SDT}', N'{giaoVien.Email}');";

            int affected = db.Excute(query);
            return affected == 1;
        }

        public bool XoaGiaoVien(string ID)
        {
            string query = $"DELETE FROM GiaoVien WHERE maGV = N'{ID}'";

            int affected = db.Excute(query);
            return affected == 1;
        }

        public bool SuaGiaoVien(GiaoVien giaoVien)
        {
            string query = $"UPDATE GiaoVien SET " +
                $"maGv = N'{giaoVien.Ma}'," +
                $"tenGV = N'{giaoVien.Ten}'," +
                $"ngaySinh = N'{giaoVien.NgaySinh.ToString("dd/MM/yyyy")}'," +
                $"diaChi = N'{giaoVien.DiaChi}'," +
                $"MaMon = N'{giaoVien.MaMonHoc}', " +
                $"sdt = N'{giaoVien.SDT}', " +
                $"email = N'{giaoVien.Email}' " +
                $"WHERE maGV = N'{giaoVien.Ma}'";

            int affected = db.Excute(query);
            return affected == 1;
        }
    }
}
