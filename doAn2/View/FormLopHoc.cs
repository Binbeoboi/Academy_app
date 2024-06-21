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
    public partial class FormLopHoc : Form
    {
        LopHoc DBLopHoc = new LopHoc();
        GiaoVien DBGiaoVien = new GiaoVien();   
        MonHoc DBMonHoc = new MonHoc();
        public FormLopHoc()
        {
            InitializeComponent();
        }

        private void FormLopHoc_Load(object sender, EventArgs e)
        {
            dgvLopHoc.DataSource = DBLopHoc.lstLopHoc();
            cbbGiaoVien.DataSource = DBGiaoVien.lstGiaoVien();
            cbbMonHoc.DataSource = DBMonHoc.lstMonHoc();    
        }
        private bool KiemTra()
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

            if (cbbGiaoVien.Text == string.Empty)
            {
                MessageBox.Show("Ô giáo viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbbMonHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Ô môn học không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(dtpBatDau.Value >= dtpKetThuc.Value)
            {
                MessageBox.Show("Thời gian học bắt đầu không được lớn hơn hoặc bằng thời gian kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private LopHoc LayLopHoc()
        {
            return new LopHoc()
            {
                Ma = txtMa.Text,
                Ten = txtTen.Text,
                MaGV = cbbGiaoVien.SelectedValue.ToString(),
                SoLuong = int.Parse(txtSoLuong.Text),
                TienHoc = int.Parse(txtTienHoc.Text),
                NgayHoc = dtpBatDau.Value,
                NgayKetThuc = dtpKetThuc.Value,
                MaMon = cbbMonHoc.SelectedValue.ToString(),
                TenGV = cbbGiaoVien.Text,
                TenMon = cbbMonHoc.Text,
            };
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTra()) return;
            if (MessageBox.Show("Bạn có muốn thêm mới lớp học không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            LopHoc item = LayLopHoc();
            if (DBLopHoc.lstLopHoc().Any(N => N.Ma.ToLower().Trim() == item.Ma.ToLower().Trim()))
            {
                MessageBox.Show("Mã không được trùng nhau. Nhâp lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DBLopHoc.ThemLopHoc(item))
            {
                MessageBox.Show($"Thêm thành công lớp học {item.Ten}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormLopHoc_Load(sender, e);
                DatLai();
            }
            else
            {
                MessageBox.Show("Thêm lớp học không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (MessageBox.Show("Bạn có muốn xóa lớp học không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!DBLopHoc.lstLopHoc().Any(N => N.Ma.ToLower().Trim() == txtMa.Text.ToLower().Trim()))
            {
                MessageBox.Show("Mã này không tồn tại. Nhâp lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DBLopHoc.XoaLopHoc(txtMa.Text))
            {
                MessageBox.Show($"Xóa thành công lớp học {txtMa.Text}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormLopHoc_Load(sender, e);
                DatLai();
            }
            else
            {
                MessageBox.Show("Xóa lớp học không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KiemTra()) return;
            if (MessageBox.Show("Bạn có muốn sửa lớp học không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            LopHoc item = LayLopHoc();
            if (!DBLopHoc.lstLopHoc().Any(N => N.Ma.ToLower().Trim() == item.Ma.ToLower().Trim()))
            {
                MessageBox.Show("Mã này không tồn tại. Nhâp lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DBLopHoc.SuaLopHoc(item))
            {
                MessageBox.Show($"Sửa thành công lớp học {item.Ten}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormLopHoc_Load(sender, e);
                DatLai();
            }
            else
            {
                MessageBox.Show("Sửa lớp học không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            txtMa.Text = dgvLopHoc.SelectedRows[0].Cells[0].Value.ToString();
            txtTen.Text = dgvLopHoc.SelectedRows[0].Cells[1].Value.ToString();
            cbbGiaoVien.Text = dgvLopHoc.SelectedRows[0].Cells[2].Value.ToString();
            cbbMonHoc.Text = dgvLopHoc.SelectedRows[0].Cells["ColMonHoc"].Value.ToString();
            dtpBatDau.Value = DateTime.Parse(dgvLopHoc.SelectedRows[0].Cells["ColBatDau"].Value.ToString());
            dtpKetThuc.Value = DateTime.Parse(dgvLopHoc.SelectedRows[0].Cells["ColNgayKetThuc"].Value.ToString());
            txtSoLuong.Text = dgvLopHoc.SelectedRows[0].Cells[6].Value.ToString();
            txtTienHoc.Text = dgvLopHoc.SelectedRows[0].Cells[7].Value.ToString();

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.CompareTo(string.Empty) == 0)
            {
                dgvLopHoc.DataSource = DBLopHoc.lstLopHoc();
            }
            else
            {
                dgvLopHoc.DataSource = DBLopHoc.lstLopHoc().Where(n => n.Ten.ToLower().Trim().Contains(txtTimKiem.Text.ToLower().Trim()) ||
                n.Ma.ToLower().Trim().Contains(txtTimKiem.Text.ToLower().Trim())).ToList();
            }
        }
        private void ExportExcel(string path)
        {
            Excel.Application app = new Excel.Application();
            app.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgvLopHoc.Columns.Count; i++)
            {
                app.Cells[1, i + 1] = dgvLopHoc.Columns[i].HeaderText;
            }

            for (int i = 0; i < dgvLopHoc.Rows.Count; i++)
            {
                for (int j = 0; j < dgvLopHoc.Columns.Count; j++)
                {
                    app.Cells[i + 2, j + 1] = dgvLopHoc.Rows[i].Cells[j].Value;
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
            gbNhapThongTinSV.Controls.OfType<DateTimePicker>().ToList().ForEach(n => n.Value = DateTime.Now);
        }
        private void btnBaoCao_Click(object sender, EventArgs e)
        {

        }
    }
}
