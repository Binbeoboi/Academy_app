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
    public partial class FormChiTietLopHoc : Form
    {
        ChiTietLopHoc DBChitietlophoc = new ChiTietLopHoc();
        LopHoc DBLophoc = new LopHoc();
        Diem DBDiem = new Diem();   
        SinhVien DBSinhVien = new SinhVien();
        public FormChiTietLopHoc()
        {
            InitializeComponent();
        }

        private void FormChiTietLopHoc_Load(object sender, EventArgs e)
        {
            dgvChiTietLopHoc.DataSource = DBChitietlophoc.lstChiTietLopHoc();
            DefaultCombobox();
            dgvChiTietLopHoc.Columns["MaSV"].Visible = false;
        }
        private void DefaultCombobox()
        {
            cbbSinhVien.DataSource = DBSinhVien.lstSinhVien();
            cbbLop.DataSource = DBLophoc.lstLopHoc();
            cbbTimKiemLop.DataSource = DBLophoc.lstLopHoc();
            cbbTimKiemLop.SelectedIndex = -1;
            cbbLop.SelectedIndex = -1;
        }
        private bool KiemTra()
        {
            if (cbbLop.SelectedIndex == -1)
            {
                MessageBox.Show("Ô lớp không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbbSinhVien.SelectedIndex == -1)
            {
                MessageBox.Show("Ô học viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtCongNo.Text.CompareTo(string.Empty) == 0)
            {
                MessageBox.Show("Ô công nợ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private ChiTietLopHoc LayLopHoc()
        {
            return new ChiTietLopHoc()
            {
                //Ma = int.Parse(txtMa.Text),
                MaSV = cbbSinhVien.SelectedValue.ToString(),
                MaLop = cbbLop.SelectedValue.ToString(),
                CongNo = int.Parse(txtCongNo.Text),
                BuoiNghi = int.Parse(nudBuoiNghi.Value.ToString()),
                TenSV = cbbSinhVien.Text,
                TenLop = cbbLop.Text,
            };
        }

        private ChiTietLopHoc LayLopHocXoaSua()
        {
            return new ChiTietLopHoc()
            {
                Ma = int.Parse(txtMa.Text),
                MaSV = cbbSinhVien.SelectedValue.ToString(),
                MaLop = cbbLop.SelectedValue.ToString(),
                CongNo = int.Parse(txtCongNo.Text),
                BuoiNghi = int.Parse(nudBuoiNghi.Value.ToString()),
                TenSV = cbbSinhVien.Text,
                TenLop = cbbLop.Text,
            };
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTra()) return;
            if (MessageBox.Show("Bạn có muốn thêm mới học viên vào lớp học không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            ChiTietLopHoc item = LayLopHoc();
            if(DBChitietlophoc.lstChiTietLopHoc().Any(n => n.TenSV.ToLower().Trim() == cbbSinhVien.Text.ToLower().Trim() && n.TenLop.ToLower().Trim() == cbbLop.Text.ToLower().Trim()))
            {
                MessageBox.Show($"Học viên {cbbSinhVien.Text} đã có trong lớp học {cbbLop.Text}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbLop.SelectedIndex = -1;
                return;
            }
            item.Ma = DBChitietlophoc.lstChiTietLopHoc()[DBChitietlophoc.lstChiTietLopHoc().Count() - 1].Ma + 1;
            if (DBChitietlophoc.ThemChiTietLopHoc(item))
            {
                MessageBox.Show($"Thêm thành công {item.TenSV} vào lớp học {item.TenLop}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBDiem.ThemDiem(item);
                FormChiTietLopHoc_Load(sender, e);
                DatLai();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.CompareTo(string.Empty) == 0)
            {
                MessageBox.Show("Ô mã không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa học viên ra khỏi lớp không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!DBChitietlophoc.lstChiTietLopHoc().Any(N => N.Ma == int.Parse(txtMa.Text.ToLower().Trim())))
            {
                MessageBox.Show("Mã này không tồn tại. Nhâp lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (DBChitietlophoc.XoaChiTietLopHoc(int.Parse(txtMa.Text))) 
            {
                var item = DBChitietlophoc.lstChiTietLopHoc().SingleOrDefault(n => n.Ma == int.Parse(txtMa.Text.Trim()));
                DBDiem.XoaDiem(item);
                MessageBox.Show($"Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormChiTietLopHoc_Load(sender, e);
                DatLai();
            }
            else
            {
                MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KiemTra()) return;
            if (MessageBox.Show("Bạn có muốn sửa học viên trong lớp không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if(txtMa.Text.CompareTo(string.Empty) == 0)
            {
                MessageBox.Show("Mã này không phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ChiTietLopHoc item = LayLopHocXoaSua();
            if (!DBChitietlophoc.lstChiTietLopHoc().Any(N => N.Ma == item.Ma))
            {
                MessageBox.Show("Mã này không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DBChitietlophoc.SuaLopHoc(item))
            {
                MessageBox.Show($"Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormChiTietLopHoc_Load(sender, e);
                DatLai();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cbbTimKiemLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTimKiemLop.Text.CompareTo(string.Empty) == 0)
            {
                dgvChiTietLopHoc.DataSource = DBChitietlophoc.lstChiTietLopHoc() ;
            }
            else
            {
                dgvChiTietLopHoc.DataSource = DBChitietlophoc.lstChiTietLopHoc().Where(n => n.TenLop.ToLower().Trim().CompareTo(cbbTimKiemLop.Text.ToLower().Trim()) == 0).ToList();
            }


        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text.CompareTo(string.Empty) == 0)
            {
                dgvChiTietLopHoc.DataSource = DBChitietlophoc.lstChiTietLopHoc();
            }
            else
            {
                dgvChiTietLopHoc.DataSource = DBChitietlophoc.lstChiTietLopHoc().Where(n => n.TenSV.ToLower().Trim().Contains(txtTimKiem.Text.ToLower().Trim()) || 
                n.MaSV.ToLower().Trim().Contains(txtTimKiem.Text.ToLower().Trim())).ToList();
            }
        }

        private void dgvChiTietLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            txtMa.Text = dgvChiTietLopHoc.SelectedRows[0].Cells["ColMa"].Value.ToString();
            cbbSinhVien.Text = dgvChiTietLopHoc.SelectedRows[0].Cells["ColSV"].Value.ToString();
            cbbLop.Text = dgvChiTietLopHoc.SelectedRows[0].Cells["ColLop"].Value.ToString();   
            nudBuoiNghi.Value = int.Parse(dgvChiTietLopHoc.SelectedRows[0].Cells["ColBuoiNghi"].Value.ToString());
            txtCongNo.Text = dgvChiTietLopHoc.SelectedRows[0].Cells["ColCongNo"].Value.ToString();
        }
        private void ExportExcel(string path)
        {
            Excel.Application app = new Excel.Application();
            app.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgvChiTietLopHoc.Columns.Count; i++)
            {
                app.Cells[1, i + 1] = dgvChiTietLopHoc.Columns[i].HeaderText;
            }

            for (int i = 0; i < dgvChiTietLopHoc.Rows.Count; i++)
            {
                for (int j = 0; j < dgvChiTietLopHoc.Columns.Count; j++)
                {
                    app.Cells[i + 2, j + 1] = dgvChiTietLopHoc.Rows[i].Cells[j].Value;
                }
            }

            app.Columns.AutoFit();
            app.ActiveWorkbook.SaveCopyAs(path);
            app.ActiveWorkbook.Saved = true;
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
        private void DatLai()
        {
            gbNhapThongTinSV.Controls.OfType<TextBox>().ToList().ForEach(n => n.Text = string.Empty);
            gbNhapThongTinSV.Controls.OfType<ComboBox>().ToList().ForEach(n => n.SelectedIndex = -1);
            //gbNhapThongTinSV.Controls.OfType<DateTimePicker>().ToList().ForEach(n => n.Value = DateTime.Now);
            nudBuoiNghi.Value = 0;
        }
        private void cbbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbbLop.SelectedIndex == -1)
            //{
            //    txtCongNo.Text = string.Empty;
            //}
            //else
            //{
            //    var data = DBLophoc.lstLopHoc().SingleOrDefault(n => n.MaMon.ToLower().Trim() == cbbLop.SelectedValue.ToString().ToLower().Trim());
            //    txtCongNo.Text = data.TienHoc.ToString();
            //}
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            
            if (cbbTimKiemLop.SelectedIndex == -1)
            {
                FormReport frm = new FormReport(DBChitietlophoc.lstChiTietLopHoc(), "TRUNG TÂM", EnumState.ChiTietLopHoc);
                frm.ShowDialog();
            }
            else if(cbbTimKiemLop.Text != string.Empty)
            {
                FormReport frm = new FormReport(DBChitietlophoc.lstChiTietLopHoc().Where(n => n.TenLop.ToLower().Trim() == cbbTimKiemLop.Text.ToLower().Trim()).ToList(), cbbTimKiemLop.Text.ToUpper(), EnumState.ChiTietLopHoc);
                frm.ShowDialog();
            }
        }

        private void cbTuyChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbTuyChon.SelectedIndex == -1 && cbbTimKiemLop.Text == string.Empty)
            {
                dgvChiTietLopHoc.DataSource = DBChitietlophoc.lstChiTietLopHoc();
            }
            else if( cbbTuyChon.SelectedIndex == 0 && cbbTimKiemLop.Text == string.Empty)
            {
                dgvChiTietLopHoc.DataSource = DBChitietlophoc.lstChiTietLopHoc().Where(n => n.CongNo > 0).ToList();
            }
            else if(cbbTuyChon.SelectedIndex == 1 && cbbTimKiemLop.Text == string.Empty)
            {
                dgvChiTietLopHoc.DataSource = DBChitietlophoc.lstChiTietLopHoc().Where(n => n.CongNo == 0).ToList();
            }
            else if(cbbTuyChon.SelectedIndex == 2 && cbbTimKiemLop.Text == string.Empty)
            {
                dgvChiTietLopHoc.DataSource = DBChitietlophoc.lstChiTietLopHoc().Where(n => n.BuoiNghi > 0).ToList();
            }
            else if(cbbTuyChon.SelectedIndex == 3 && cbbTimKiemLop.Text == string.Empty)
            {
                dgvChiTietLopHoc.DataSource = DBChitietlophoc.lstChiTietLopHoc().Where(n => n.BuoiNghi == 0).ToList();
            }
            else if (cbbTuyChon.SelectedIndex == -1 && cbbTimKiemLop.Text != string.Empty)
            {
                dgvChiTietLopHoc.DataSource = DBChitietlophoc.lstChiTietLopHoc().Where(n => n.TenLop == cbbTimKiemLop.Text).ToList();
            }
            else if (cbbTuyChon.SelectedIndex == 0 && cbbTimKiemLop.Text != string.Empty)
            {
                dgvChiTietLopHoc.DataSource = DBChitietlophoc.lstChiTietLopHoc().Where(n => n.CongNo > 0 && n.TenLop == cbbTimKiemLop.Text).ToList();
            }
            else if (cbbTuyChon.SelectedIndex == 1 && cbbTimKiemLop.Text != string.Empty)
            {
                dgvChiTietLopHoc.DataSource = DBChitietlophoc.lstChiTietLopHoc().Where(n => n.CongNo == 0 && n.TenLop == cbbTimKiemLop.Text).ToList();
            }
            else if (cbbTuyChon.SelectedIndex == 2 && cbbTimKiemLop.Text != string.Empty)
            {
                dgvChiTietLopHoc.DataSource = DBChitietlophoc.lstChiTietLopHoc().Where(n => n.BuoiNghi > 0 && n.TenLop == cbbTimKiemLop.Text).ToList();
            }
            else if (cbbTuyChon.SelectedIndex == 3 && cbbTimKiemLop.Text != string.Empty )
            {
                dgvChiTietLopHoc.DataSource = DBChitietlophoc.lstChiTietLopHoc().Where(n => n.BuoiNghi == 0 && n.TenLop == cbbTimKiemLop.Text).ToList();
            }
        }

        private void cbbTuyChon_TextChanged(object sender, EventArgs e)
        {
            if(cbbTuyChon.Text == string.Empty)
            {
                dgvChiTietLopHoc.DataSource = DBChitietlophoc.lstChiTietLopHoc();
            }
        }
    }
}

