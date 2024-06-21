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
    public partial class FormNopTienHoc : Form
    {
        SinhVien DBSinhVien = new SinhVien();
        LopHoc DBLopHoc = new LopHoc();
        ChiTietLopHoc DBChiTietLopHoc = new ChiTietLopHoc();
        public FormNopTienHoc()
        {
            InitializeComponent();
        }

        private void FormNopTienHoc_Load(object sender, EventArgs e)
        {
            cbbLop.DataSource = DBLopHoc.lstLopHoc();

            cbbSinhVien.DataSource = DBSinhVien.lstSinhVien();
            cbbLop.SelectedIndex = -1;
            
        }

        private void cbbLop_TextChanged(object sender, EventArgs e)
        {
            if (cbbLop.Text.CompareTo(string.Empty) == 0)
            {
                cbbSinhVien.Enabled = false;
                cbbSinhVien.SelectedIndex = -1;
            }
            else
            {
                cbbSinhVien.Enabled = true;
            }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (cbbSinhVien.Text.CompareTo(string.Empty) == 0)
            {
                lblSoTienCanNop.Text = "Cần nôp: 0 đồng";
                lblTongCongNo.Text = "Công nợ: 0 đồng";
                return;
            }

            var data = DBChiTietLopHoc.lstChiTietLopHoc().SingleOrDefault(n => n.TenLop.ToLower().Trim() == cbbLop.Text.ToLower().Trim() && n.TenSV.ToLower().Trim() == cbbSinhVien.Text.ToLower().Trim());
            if(data == null)
            {
                MessageBox.Show($"Không tồn tại học viên {cbbSinhVien.Text} trong lớp {cbbLop.Text}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                lblTongCongNo.Text = $"Công nợ: {data.CongNo} đồng";
                lblSoTienCanNop.Text = $"Số tiền cần nộp: {TinhTienCongNoCongNo()} đồng";
            }
            
        }

        private void cbbSinhVien_TextChanged(object sender, EventArgs e)
        {
            //if (cbbSinhVien.Text.CompareTo(string.Empty) == 0)
            //{
            //    lblSoTienCanNop.Text = "Cần nôp: 0 đồng";
            //    lblTongCongNo.Text = "Công nợ: 0 đồng";
            //}
            //else
            //{
            //    var data = DBChiTietLopHoc.lstChiTietLopHoc().SingleOrDefault(n => n.TenLop.ToLower().Trim() == cbbLop.Text.ToLower().Trim() && n.TenSV.ToLower().Trim() == cbbSinhVien.Text.ToLower().Trim());
            //    lblTongCongNo.Text = $"Công nợ: {data.CongNo} đồng";
            //}
        }

        private int TinhTienCongNoCongNo()
        {
            var data = DBLopHoc.lstLopHoc().SingleOrDefault(n => n.Ma.ToLower().Trim() == cbbLop.SelectedValue.ToString().ToLower().Trim());
            var thoiHan = data.NgayKetThuc;
            int tongCongNo = DBChiTietLopHoc.lstChiTietLopHoc().SingleOrDefault(n => n.TenLop.ToLower().Trim() == cbbLop.Text.ToLower().Trim() && n.TenSV.ToLower().Trim() == cbbSinhVien.Text.ToLower().Trim()).CongNo;
            var ketQua = 0;
            //thoiHan.Month
            if(thoiHan.Month - DateTime.Now.Month >= 3)
            {
                ketQua =  tongCongNo - (tongCongNo * 3) / 10;
            }
            else if(thoiHan.Month - DateTime.Now.Month >= 2)
            {
                ketQua =  tongCongNo - (tongCongNo * 2) / 10;
            }
            else if(thoiHan.Month - DateTime.Now.Month >= 1)
            {
                ketQua = tongCongNo - (tongCongNo) / 10;
            }
            else if(thoiHan.Month - DateTime.Now.Month < 1)
            {
                ketQua = tongCongNo;
            }
            return ketQua;
        }

        private void btnNop_Click(object sender, EventArgs e)
        {
            var data = DBChiTietLopHoc.lstChiTietLopHoc().SingleOrDefault(n => n.TenLop.ToLower().Trim() == cbbLop.Text.ToLower().Trim() && n.TenSV.ToLower().Trim() == cbbSinhVien.Text.ToLower().Trim());
            int soDu =  TinhTienCongNoCongNo() - int.Parse(txtSoTienNop.Text);
            if (soDu < 0)
            {
                MessageBox.Show("Số tiền vượt quá mức phải trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTienNop.Text = string.Empty;
            }
            else
            {
                ChiTietLopHoc item = data;
                item.CongNo = soDu;
                if (DBChiTietLopHoc.SuaLopHoc(item))
                {
                    MessageBox.Show($"Học viên {item.TenSV} đã nộp học phí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Học viên {item.TenSV} đã nộp học phí không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DatLai();
            }
            

        }
        private void DatLai()
        {
            panelBody.Controls.OfType<ComboBox>().ToList().ForEach(n => n.SelectedIndex = -1);
            lblSoTienCanNop.Text = "Phải trả";
            lblTongCongNo.Text = "Tổng công nợ";
            txtSoTienNop.Text = string.Empty;
            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
