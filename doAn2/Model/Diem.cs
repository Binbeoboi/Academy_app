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
    public class Diem
    {
        public int Ma{get;set;}
        public string MaSV { get; set; }
        [Browsable(false)]
        public string MaLop { get; set; }
        public string TenSV { get; set; }
        public string TenLop { get; set; }
        public double DiemHS_10{get;set;}
        public double DiemHS_11 {get;set;}
        public double DiemHS_20 {get;set;}
        public double DiemHS_21 {get;set;}
        public double DiemCuoiKhoa {get;set;}
        [Browsable(false)]
        public double DiemTrungBinh
        {
            get
            {
                return (DiemHS_10 + DiemHS_11 + (DiemHS_20 + DiemHS_21) * 2 + DiemCuoiKhoa * 3) / 9;
            }
        }
        

        public List<Diem> lstDiem()
        {
            List<Diem> lst = new List<Diem>();
            string query = "SELECT Diem.*, LopHoc.tenLH, SinhVien.tenSV FROM Diem " +
                "JOIN LopHoc ON Diem.maLop = LopHoc.maLH " +
                "JOIN SinhVien ON Diem.maSV = SinhVien.maSV;";

            try
            {
                using (SqlConnection cnn = Connection.GetSqlConnection())
                {
                    SqlCommand sqlCommand = new SqlCommand(query, cnn);
                    SqlDataReader sqlData = sqlCommand.ExecuteReader();
                    while (sqlData.Read())
                    {
                        lst.Add(new Diem
                        {
                            Ma = sqlData.GetInt32(0),
                            DiemHS_10 = sqlData.GetDouble(1),
                            DiemHS_11 = sqlData.GetDouble(2),
                            DiemHS_20 = sqlData.GetDouble(3),
                            DiemHS_21 = sqlData.GetDouble(4),
                            DiemCuoiKhoa = sqlData.GetDouble(5),
                            MaSV = sqlData.GetString(6),
                            MaLop = sqlData.GetString(7),
                            TenLop = sqlData.GetString(8),
                            TenSV = sqlData.GetString(9),

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
        public bool ThemDiem (ChiTietLopHoc diem)
        {
            string query = $"INSERT INTO Diem VALUES" +
                $" ({0},{0},{0},{0}, {0}, N'{diem.MaSV}', N'{diem.MaLop}');";

        int affected = db.Excute(query);
            return affected == 1;
        }

    public bool XoaDiem(ChiTietLopHoc item)
    {
        string query = $"DELETE FROM Diem WHERE maSV = N'{item.MaSV}' AND maLop = N'{item.MaLop}'";

        int affected = db.Excute(query);
        return affected == 1;
    }

    public bool SuaDiem(Diem diem)
    {
        string query = $"UPDATE Diem SET " +
            $"diemHS10 = {diem.DiemHS_10}," +
            $"diemHS11 = {diem.DiemHS_11}," +
            $"diemHS20 = {diem.DiemHS_20}," +
            $"diemHS21 = {diem.DiemHS_21}," +
            $"diemCuoiKhoa = {diem.DiemCuoiKhoa} " +
            $"WHERE ma = {diem.Ma}";

        int affected = db.Excute(query);
        return affected == 1;
    }
}
}
