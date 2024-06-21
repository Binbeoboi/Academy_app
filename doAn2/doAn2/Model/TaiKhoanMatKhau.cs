using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doAn2.Model
{
    public class TaiKhoanMatKhau
    {
        public string TaiKhoan {get;set; }
        public string MatKhau{get;set; }

        public object[] TruyenDuLieu(int i)
        {
            return new object[] {i, TaiKhoan, MatKhau };
        }
    }
}
