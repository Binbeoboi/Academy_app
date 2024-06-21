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
    public partial class FormGiaoVien : Form
    {
        GiaoVien DBGiaoVien = new GiaoVien();
        MonHoc DBMonhoc = new MonHoc();
        public FormGiaoVien()
        {
            InitializeComponent();
        }

        private void FormGiaoVien_Load(object sender, EventArgs e)
        {
            dgvGiaoVien.DataSource = DBGiaoVien.lstGiaoVien();
            cbbMonHoc.DataSource = DBMonhoc.lstMonHoc();
        }
        private void DatLai()
        {
            gbNhapThongTinSV.Controls.OfType<TextBox>().ToList().ForEach(n => n.Text = string.Empty);
            gbNhapThongTinSV.Controls.OfType<ComboBox>().ToList().ForEach(n => n.SelectedIndex = -1);
            gbNhapThongTinSV.Controls.OfType<DateTimePicker>().ToList().ForEach(n => n.Value = DateTime.Now);
        }
        private bool KiemTraRong()
        {
            if (txtMa.Text == string.Empty)
            {
                MessageBox.Show("Ô mã không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTen.Text == string.Empty)
            {
                MessageBox.Show("Ô tên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtSDT.Text == string.Empty)
            {
                MessageBox.Show("Ô mã không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(cbbMonHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Ô môn học không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private GiaoVien LayGiaoVien()
        {
            return new GiaoVien()
            {
                Ma = txtMa.Text,
                Ten = txtTen.Text,
                NgaySinh = dtpNgaySinh.Value,
                DiaChi = txtDiaChi.Text,
                SDT = txtSDT.Text,
                Email = txtMail.Text,
                MaMonHoc = cbbMonHoc.SelectedValue.ToString(),
            };
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraRong()) return;
            if (MessageBox.Show("Bạn có muốn thêm mới giáo viên không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            GiaoVien item = LayGiaoVien();
            if (DBGiaoVien.lstGiaoVien().Any(N => N.Ma.ToLower().Trim() == item.Ma.ToLower().Trim()))
            {
                MessageBox.Show("Mã không được trùng nhau. Nhâp lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DBGiaoVien.ThemGiaoVien(item))
            {
                MessageBox.Show($"Thêm thành công giáo viên {item.Ten}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormGiaoVien_Load(sender, e);
                DatLai();
            }
            else
            {
                MessageBox.Show("Thêm giáo viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (MessageBox.Show("Bạn có muốn xóa giáo viên không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!DBGiaoVien.lstGiaoVien().Any(N => N.Ma.ToLower().Trim() == txtMa.Text.ToLower().Trim()))
            {
                MessageBox.Show("Mã này không tồn tại. Nhâp lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DBGiaoVien.XoaGiaoVien(txtMa.Text))
            {
                MessageBox.Show($"Xóa thành công giáo viên {txtMa.Text}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormGiaoVien_Load(sender, e);
                DatLai();
            }
            else
            {
                MessageBox.Show("Xóa giáo viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KiemTraRong()) return;
            if (MessageBox.Show("Bạn có muốn sửa giáo viên không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            GiaoVien item = LayGiaoVien();
            if (!DBGiaoVien.lstGiaoVien().Any(N => N.Ma.ToLower().Trim() == item.Ma.ToLower().Trim()))
            {
                MessageBox.Show("Mã này không tồn tại. Nhâp lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DBGiaoVien.SuaGiaoVien(item))
            {
                MessageBox.Show($"Sửa thành công giáo viên {item.Ten}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormGiaoVien_Load(sender, e);
                DatLai();
            }
            else
            {
                MessageBox.Show("Sửa giáo viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1) return;

            txtMa.Text = dgvGiaoVien.SelectedRows[0].Cells[0].Value.ToString();
            txtTen.Text = dgvGiaoVien.SelectedRows[0].Cells[1].Value.ToString();
            dtpNgaySinh.Value = DateTime.Parse(dgvGiaoVien.SelectedRows[0].Cells[2].Value.ToString());
            txtDiaChi.Text = dgvGiaoVien.SelectedRows[0].Cells[3].Value.ToString();
            cbbMonHoc.Text = dgvGiaoVien.SelectedRows[0].Cells[4].Value.ToString();
            txtSDT.Text  = dgvGiaoVien.SelectedRows[0].Cells[5].Value.ToString();
            txtMail.Text = dgvGiaoVien.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.CompareTo(string.Empty) == 0)
            {
                dgvGiaoVien.DataSource = DBGiaoVien.lstGiaoVien();
            }
            else
            {
                dgvGiaoVien.DataSource = DBGiaoVien.lstGiaoVien().Where(n => n.Ten.ToLower().Trim().Contains(txtTimKiem.Text.ToLower().Trim()) ||
                n.Ma.ToLower().Trim().Contains(txtTimKiem.Text.ToLower().Trim())).ToList();
            }
        }
        private void ExportExcel(string path)
        {
            Excel.Application app = new Excel.Application();
            app.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgvGiaoVien.Columns.Count; i++)
            {
                app.Cells[1, i + 1] = dgvGiaoVien.Columns[i].HeaderText;
            }

            for (int i = 0; i < dgvGiaoVien.Rows.Count; i++)
            {
                for (int j = 0; j < dgvGiaoVien.Columns.Count; j++)
                {
                    app.Cells[i + 2, j + 1] = dgvGiaoVien.Rows[i].Cells[j].Value;
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
    }
}
