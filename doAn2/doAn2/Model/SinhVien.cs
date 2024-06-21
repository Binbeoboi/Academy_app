using doAn2.DBConfig;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doAn2.Model
{
    public class SinhVien
    {
        public string Ma { get; set; }
        public string Ten{ get; set; }
        public DateTime NgaySinh{ get; set; }
        public string DiaChi{get;set;}
        public string SDT{get;set;}
        public string Email{get;set; }


        public List<SinhVien> lstSinhVien()
        {
            List<SinhVien> lst = new List<SinhVien>();
            string query = "SELECT * FROM SinhVien;";

            try
            {
                using (SqlConnection cnn = Connection.GetSqlConnection())
                {
                    SqlCommand sqlCommand = new SqlCommand(query, cnn);
                    SqlDataReader sqlData = sqlCommand.ExecuteReader();
                    while (sqlData.Read())
                    {
                        lst.Add(new SinhVien
                        {
                            Ma = sqlData.GetString(0),
                            Ten = sqlData.GetString(1),
                            NgaySinh = DateTime.Parse(sqlData.GetString(2)),
                            DiaChi = sqlData.GetString(3),
                            SDT = sqlData.GetString(4),
                            Email = sqlData.GetString(5)
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
        public bool ThemSinhVien(SinhVien sinhVien)
        {
            string query = $"INSERT INTO SinhVien VALUES (N'{sinhVien.Ma.ToUpper().Trim()}',N'{sinhVien.Ten}',N'{sinhVien.NgaySinh.ToString("dd/MM/yyyy")}',N'{sinhVien.DiaChi}',N'{sinhVien.SDT}', N'{sinhVien.Email}');";

            int affected = db.Excute(query);
            return affected == 1;
        }

        public bool XoaSinhVien(string ID)
        {
            string query = $"DELETE FROM SinhVien WHERE maSV = N'{ID}'";

            int affected = db.Excute(query);
            return affected == 1;
        }

        public bool SuaSinhVien(SinhVien sinhVien)
        {
            string query = $"UPDATE SinhVien SET " +
                $"maSV = N'{sinhVien.Ma}'," +
                $"tenSV = N'{sinhVien.Ten}'," +
                $"ngaySinh = N'{sinhVien.NgaySinh.ToString("dd/MM/yyyy")}'," +
                $"diaChi = N'{sinhVien.DiaChi}'," +
                $"sdt = N'{sinhVien.SDT}', " +
                $"email = N'{sinhVien.Email}' " +
                $"WHERE maSV = N'{sinhVien.Ma}'";

            int affected = db.Excute(query);
            return affected == 1;
        }
    }
}
