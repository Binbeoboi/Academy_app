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
    public class ChiTietLopHoc
    {
        public int Ma { get; set; }
        public string MaSV{get;set;}
        [Browsable(false)]
        public string MaLop{get;set;}
        public int CongNo{get;set;}
        public int BuoiNghi{ get; set; }
        public string TenSV { get; set; }
        public string TenLop { get; set; }

        public List<ChiTietLopHoc> lstChiTietLopHoc()
        {
            List<ChiTietLopHoc> lst = new List<ChiTietLopHoc>();
            string query = "SELECT ChiTietLopHoc.*, LopHoc.tenLH, SinhVien.tenSV FROM ChiTietLopHoc " +
                "JOIN LopHoc ON ChiTietLopHoc.maLop = LopHoc.maLH " +
                "JOIN SinhVien ON ChiTietLopHoc.maSV = SinhVien.maSV;";

            try
            {
                using (SqlConnection cnn = Connection.GetSqlConnection())
                {
                    SqlCommand sqlCommand = new SqlCommand(query, cnn);
                    SqlDataReader sqlData = sqlCommand.ExecuteReader();
                    while (sqlData.Read())
                    {
                        lst.Add(new ChiTietLopHoc
                        {
                            Ma = sqlData.GetInt32(0),
                            MaSV = sqlData.GetString(1),
                            MaLop = sqlData.GetString(2),
                            CongNo = sqlData.GetInt32(3),
                            BuoiNghi = sqlData.GetInt32(4),
                            TenLop = sqlData.GetString(5),
                            TenSV = sqlData.GetString(6),
                            
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
        public bool ThemChiTietLopHoc(ChiTietLopHoc lopHoc)
        {
            string query = $"INSERT INTO ChiTietLopHoc VALUES (N'{lopHoc.MaSV}',N'{lopHoc.MaLop}',{lopHoc.CongNo},{lopHoc.BuoiNghi});";

            int affected = db.Excute(query);
            return affected == 1;
        }

        public bool XoaChiTietLopHoc(int ID)
        {
            string query = $"DELETE FROM ChiTietLopHoc WHERE ma = {ID}";

            int affected = db.Excute(query);
            return affected == 1;
        }

        public bool SuaLopHoc(ChiTietLopHoc lopHoc)
        {
            string query = $"UPDATE ChiTietLopHoc SET " +
                $"maSV = N'{lopHoc.MaSV}'," +
                $"maLop = N'{lopHoc.MaLop}'," +
                $"congNo = {lopHoc.CongNo}," +
                $"buoiNghi = {lopHoc.BuoiNghi} " +
                $"WHERE ma = {lopHoc.Ma}";

            int affected = db.Excute(query);
            return affected == 1;
        }
    }
}

