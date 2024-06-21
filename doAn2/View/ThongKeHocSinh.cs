using doAn2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doAn2.View
{
    public partial class ThongKeHocSinh : Form
    {
        ChiTietLopHoc DB = new ChiTietLopHoc();
        public ThongKeHocSinh()
        {
            InitializeComponent();
        }

        private void ThongKeHocSinh_Load(object sender, EventArgs e)
        {
            var Data = DB.lstChiTietLopHoc().GroupBy(cd => new { cd.MaSV, cd.TenSV }).Select(g => new { MaSv = g.Key.MaSV, TenSv = g.Key.TenSV, SoLop = g.Count() }).ToList();
            dgvDiem.DataSource = Data;  
            
        }
    }
}
