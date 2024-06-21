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
    public class LopHoc
    {
        public string Ma{get;set;}
        public string Ten{get;set;}
        [Browsable(false)]
        public string MaGV{get;set;}
        public string TenGV { get;set;} 
        public DateTime NgayHoc{get;set;}
        public DateTime NgayKetThuc{ get; set; }
        [Browsable(false)]
        public string MaMon { get;set;}
        public string TenMon { get;set;}
        public int SoLuong { get; set; }
        public int TienHoc { get; set; }
        public List<LopHoc> lstLopHoc()
        {
            List<LopHoc> lst = new List<LopHoc>();
            string query = "SELECT LopHoc.*, GiaoVien.tenGV, MonHoc.tenMon FROM LopHoc " +
                "JOIN GiaoVien ON LopHoc.maGV = GiaoVien.maGv " +
                "JOIN MonHoc ON LopHoc.maMon = MonHoc.maMon;";

            try
            {
                using (SqlConnection cnn = Connection.GetSqlConnection())
                {
                    SqlCommand sqlCommand = new SqlCommand(query, cnn);
                    SqlDataReader sqlData = sqlCommand.ExecuteReader();
                    while (sqlData.Read())
                    {
                        lst.Add(new LopHoc
                        {
                            Ma = sqlData.GetString(0),
                            Ten = sqlData.GetString(1),
                            MaGV = sqlData.GetString(2),
                            SoLuong = sqlData.GetInt32(3),
                            TienHoc = sqlData.GetInt32(4),
                            NgayHoc = DateTime.Parse(sqlData.GetString(5)),
                            NgayKetThuc = DateTime.Parse(sqlData.GetString(6)),
                            MaMon = sqlData.GetString(7),
                            TenGV = sqlData.GetString(8),
                            TenMon = sqlData.GetString(9),
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
        public bool ThemLopHoc(LopHoc lopHoc)
        {
            string query = $"INSERT INTO LopHoc VALUES (N'{lopHoc.Ma.ToUpper().Trim()}',N'{lopHoc.Ten}',N'{lopHoc.MaGV}',{lopHoc.SoLuong}, {lopHoc.TienHoc},N'{lopHoc.NgayHoc.ToString("dd/MM/yyyy")}', N'{lopHoc.NgayKetThuc.ToString("dd/MM/yyyy")}', N'{lopHoc.MaMon}');";

            int affected = db.Excute(query);
            return affected == 1;
        }

        public bool XoaLopHoc(string ID)
        {
            string query = $"DELETE FROM LopHoc WHERE maLH = N'{ID}'";

            int affected = db.Excute(query);
            return affected == 1;
        }

        public bool SuaLopHoc(LopHoc lopHoc)
        {
            string query = $"UPDATE LopHoc SET " +
                $"maLH = N'{lopHoc.Ma}'," +
                $"tenLH = N'{lopHoc.Ten}'," +
                $"maGV = N'{lopHoc.MaGV}'," +
                $"soLuong = {lopHoc.SoLuong}," +
                $"tienHoc = {lopHoc.TienHoc}, " +
                $"ngayBatDau = N'{lopHoc.NgayHoc.ToString("dd/MM/yyyy")}', " +
                $"ngayKetThuc = N'{lopHoc.NgayKetThuc.ToString("dd/MM/yyyy")}', " +
                $"maMon = N'{lopHoc.MaMon}' "+
                $"WHERE maLH = N'{lopHoc.Ma}'";

            int affected = db.Excute(query);
            return affected == 1;
        }
    }
}

