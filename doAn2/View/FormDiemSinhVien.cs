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
using Excel = Microsoft.Office.Interop.Excel;

namespace doAn2.View
{
    public partial class FormDiemSinhVien : Form
    {
        Diem DBDiem = new Diem();
        LopHoc DBLophoc = new LopHoc();
        SinhVien DBSinhVien = new SinhVien();
        ChiTietLopHoc DBChiTietLopHoc = new ChiTietLopHoc();
        public FormDiemSinhVien()
        {
            InitializeComponent();
        }

        private void FormDiemSinhVien_Load(object sender, EventArgs e)
        {
            dgvDiem.DataSource = DBDiem.lstDiem();
            cbbSinhVien.DataSource = DBSinhVien.lstSinhVien();
            cbbLop.DataSource = DBLophoc.lstLopHoc();
            cbbTimKiemLop.DataSource = DBLophoc.lstLopHoc();
            cbbTimKiemLop.SelectedIndex = -1;
            cbbLop.SelectedIndex = -1;
            cbbSinhVien.SelectedIndex = -1;
            cbbLopThongke.DataSource = DBLophoc.lstLopHoc();
            cbbLopThongke.SelectedIndex = -1;
            cbbThongKe.SelectedIndex = -1;
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            txtMa.Text = dgvDiem.SelectedRows[0].Cells["ColMa"].Value.ToString(); 
            cbbSinhVien.Text = dgvDiem.SelectedRows[0].Cells["ColTenSV"].Value.ToString();
            cbbLop.Text = dgvDiem.SelectedRows[0].Cells["ColLop"].Value.ToString();
            txtHS10.Text = dgvDiem.SelectedRows[0].Cells["ColHS10"].Value.ToString();
            txtHS11.Text = dgvDiem.SelectedRows[0].Cells["ColHS11"].Value.ToString();
            txtHS20.Text = dgvDiem.SelectedRows[0].Cells["ColHS20"].Value.ToString();
            txtHS21.Text = dgvDiem.SelectedRows[0].Cells["ColHS21"].Value.ToString();
            txtCuoiKhoa.Text = dgvDiem.SelectedRows[0].Cells["ColHSCuoiKhoa"].Value.ToString();
        }
        private bool KiemTra()
        {
            if(cbbLop.SelectedIndex == -1)
            {
                MessageBox.Show("Ô lớp không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;   
            }
            if(cbbSinhVien.SelectedIndex == -1)
            {
                MessageBox.Show("Ô học viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtMa.Text.CompareTo(string.Empty) == 0)
            {
                MessageBox.Show("Ô mã không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private Diem GetDiem()
        {
            return new Diem()
            {
                Ma = int.Parse(txtMa.Text),
                MaSV = cbbSinhVien.SelectedValue.ToString(),
                TenSV = cbbSinhVien.Text,
                MaLop = cbbLop.SelectedValue.ToString(),
                TenLop = cbbLop.Text,
                DiemHS_10 = double.TryParse(txtHS10.Text, out var ketQuaMacDinh10) ? ketQuaMacDinh10 : 0,
                DiemHS_11 = double.TryParse(txtHS11.Text, out var ketQuaMacDinh11) ? ketQuaMacDinh11 : 0,
                DiemHS_20 = double.TryParse(txtHS20.Text, out var ketQuaMacDinh20) ? ketQuaMacDinh20 : 0,
                DiemHS_21 = double.TryParse(txtHS21.Text, out var ketQuaMacDinh21) ? ketQuaMacDinh21 : 0,
                DiemCuoiKhoa = double.TryParse(txtCuoiKhoa.Text, out var ketQuaMacDinhCuoiKhoa) ? ketQuaMacDinhCuoiKhoa : 0,

            };
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KiemTra()) return;
            if(MessageBox.Show("Bạn có muốn sửa điểm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            Diem item = GetDiem();
            if(!DBDiem.lstDiem().Any(n => n.Ma == item.Ma))
            {
                MessageBox.Show("Mã này chưa tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DBDiem.SuaDiem(item))
            {
                MessageBox.Show("Sửa điểm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormDiemSinhVien_Load(sender, e);
                DatLai();
            }
            else
            {
                MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cbbTimKiemLop_TextChanged(object sender, EventArgs e)
        {
            if (cbbTimKiemLop.Text.CompareTo(string.Empty) == 0)
            {
                dgvDiem.DataSource = DBDiem.lstDiem();
            }
            else
            {
                dgvDiem.DataSource = DBDiem.lstDiem().Where(n => n.TenLop.ToLower().Trim().CompareTo(cbbTimKiemLop.Text.ToLower().Trim()) == 0).ToList();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text.CompareTo(string.Empty) == 0 && cbbTimKiemLop.Text.CompareTo(string.Empty) == 0)
            {
                dgvDiem.DataSource = DBDiem.lstDiem();
            }
            if(cbbTimKiemLop.Text.CompareTo(string.Empty) != 0 && txtTimKiem.Text.CompareTo(string.Empty) == 0)
            {
                dgvDiem.DataSource = DBDiem.lstDiem().Where(n => n.TenLop.ToLower().Trim().CompareTo(cbbTimKiemLop.Text.ToLower().Trim()) == 0).ToList();
            }
            if(cbbTimKiemLop.Text.CompareTo(string.Empty) != 0 && txtTimKiem.Text.CompareTo(string.Empty) != 0)
            {
                dgvDiem.DataSource = DBDiem.lstDiem().Where(n => n.TenLop.ToLower().Trim().CompareTo(cbbTimKiemLop.Text.ToLower().Trim()) == 0 
                && (n.TenSV.ToLower().Trim().Contains(txtTimKiem.Text.ToLower().Trim()) 
                || n.MaSV.ToLower().Trim().Contains(txtTimKiem.Text.ToLower().Trim()))).ToList();
            }
            if(cbbTimKiemLop.Text.CompareTo(string.Empty) == 0 && txtTimKiem.Text.CompareTo(string.Empty) != 0)
            {
                var data = DBDiem.lstDiem().Where(n => n.TenSV.ToLower().Trim().Contains(txtTimKiem.Text.ToLower().Trim()) || n.MaSV.ToLower().Trim().Contains(txtTimKiem.Text.ToLower().Trim())).ToList();
                dgvDiem.DataSource = data;
            }
            
        }
        private void ExportExcel(string path)
        {
            Excel.Application app = new Excel.Application();
            app.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgvDiem.Columns.Count; i++)
            {
                app.Cells[1, i + 1] = dgvDiem.Columns[i].HeaderText;
            }

            for (int i = 0; i < dgvDiem.Rows.Count; i++)
            {
                for (int j = 0; j < dgvDiem.Columns.Count; j++)
                {
                    app.Cells[i + 2, j + 1] = dgvDiem.Rows[i].Cells[j].Value;
                }
            }

            app.Columns.AutoFit();
            app.ActiveWorkbook.SaveCopyAs(path);
            app.ActiveWorkbook.Saved = true;
        }
        private void DatLai()
        {
            gbNhapThongTinSV.Controls.OfType<TextBox>().ToList().ForEach(n => n.Text = string.Empty);
            gbNhapThongTinSV.Controls.OfType<ComboBox>().ToList().ForEach(n => n.SelectedIndex = -1);
            //gbNhapThongTinSV.Controls.OfType<DateTimePicker>().ToList().ForEach(n => n.Value = DateTime.Now);
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Export Excel";
            save.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(save.FileName);
                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Xuất file không thành công. Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbbLopThongke_TextChanged(object sender, EventArgs e)
        {
            if (cbbTimKiemLop.Text.CompareTo(string.Empty) == 0)
            {
                dgvDiem.DataSource = DBDiem.lstDiem();
            }
            else
            {
                dgvDiem.DataSource = DBDiem.lstDiem().Where(n => n.TenLop.ToLower().Trim().CompareTo(cbbTimKiemLop.Text.ToLower().Trim()) == 0).ToList();
            }
        }

        private void cbbThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbThongKe.SelectedIndex == -1 && cbbLopThongke.Text.CompareTo(string.Empty) == 0)
            {
                dgvDiem.DataSource = DBDiem.lstDiem();
            }
            else if (cbbThongKe.SelectedIndex == 0 && cbbLopThongke.Text.CompareTo(string.Empty) == 0)
            {
                dgvDiem.DataSource = DBDiem.lstDiem().OrderByDescending(n => n.DiemTrungBinh).Take(3).ToList();
            }
            else if (cbbThongKe.SelectedIndex == 1 && cbbLopThongke.Text.CompareTo(string.Empty) == 0)
            {
                dgvDiem.DataSource = DBDiem.lstDiem().OrderBy(n => n.DiemTrungBinh).Take(3).ToList();
                //dgvDiem.DataSource = DBDiem.lstDiem().Where(n => n.TenLop.ToLower().Trim().CompareTo(cbbTimKiemLop.Text.ToLower().Trim()) == 0
                //&& (n.TenSV.ToLower().Trim().Contains(txtTimKiem.Text.ToLower().Trim())
                //|| n.MaSV.ToLower().Trim().Contains(txtTimKiem.Text.ToLower().Trim()))).ToList();
            }
            else if (cbbThongKe.SelectedIndex == 0 && cbbLopThongke.Text.CompareTo(string.Empty) != 0)
            {
                var data = DBDiem.lstDiem().Where(n => n.TenLop.CompareTo(cbbLopThongke.Text) == 0).OrderByDescending(n => n.DiemTrungBinh).Take(3).ToList();
                dgvDiem.DataSource = data;
            }
            else if(cbbThongKe.SelectedIndex == 1 && cbbLopThongke.Text.CompareTo(string.Empty) != 0)
            {
                var data = DBDiem.lstDiem().Where(n => n.TenLop.CompareTo(cbbLopThongke.Text) == 0).OrderBy(n => n.DiemTrungBinh).Take(3).ToList();
                dgvDiem.DataSource = data;
            }
            else if(cbbThongKe.SelectedIndex == -1 && cbbLopThongke.Text.CompareTo(string.Empty) != 0)
            {
                var data = DBDiem.lstDiem().Where(n => n.TenLop.CompareTo(cbbLopThongke.Text) == 0).ToList();
                dgvDiem.DataSource = data;
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (cbbTimKiemLop.SelectedIndex == -1)
            {
                FormReport frm = new FormReport(DBDiem.lstDiem(), "TRUNG TÂM", EnumState.Diem);
                frm.ShowDialog();
            }
            else if (cbbTimKiemLop.Text != string.Empty)
            {
                FormReport frm = new FormReport(DBDiem.lstDiem().Where(n => n.TenLop.ToLower().Trim() == cbbTimKiemLop.Text.ToLower().Trim()).ToList(), cbbTimKiemLop.Text.ToUpper(), EnumState.Diem);
                frm.ShowDialog();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbbTimKiemLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
