using doAn2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doAn2.View
{
    public partial class FormCaiDat : Form
    {
        MonHoc DBMonHoc = new MonHoc();
        string file = "Account.txt";
        List<TaiKhoanMatKhau> lst;
        Panel panel1 = new Panel();
        Panel panel2 = new Panel();
        public FormCaiDat()
        {
            InitializeComponent();
        }
        FormMain frmMain = new FormMain();
        public FormCaiDat(FormMain frmMain, Panel panel1, Panel panel2)
        {
            InitializeComponent();
            this.frmMain = frmMain;
            this.panel1 = panel1;
            this.panel2 = panel2;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormCaiDat_Load(object sender, EventArgs e)
        {
            dgvTheLoai.DataSource = DBMonHoc.lstMonHoc();
            KhoiDongMacDinh();
        }
        private void DocFileAccount()
        {
            using (StreamReader reader = new StreamReader(file))
            {
                string line;
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    var data = line.Split(',');
                    lst.Add(new TaiKhoanMatKhau() { TaiKhoan = data[0], MatKhau = data[1] });
                }
            }
        }
        private bool KiemtraMonHoc()
        {
            if(txtMaMonHoc.Text == string.Empty)
            {
                MessageBox.Show("Ô mã không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;   
            }
            if (txtTenMonHoc.Text == string.Empty)
            {
                MessageBox.Show("Ô tên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtLuongCB.Text == string.Empty)
            {
                MessageBox.Show("Ô lương cơ bản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private MonHoc GetMon()
        {
            return new MonHoc()
            {
                Ma = txtMaMonHoc.Text,
                Ten = txtTenMonHoc.Text,
                LuongCB = int.Parse(txtLuongCB.Text),
            };
        }
        private void btnThemMonHoc_Click(object sender, EventArgs e)
        {
            if (!KiemtraMonHoc()) return;
            if(MessageBox.Show("Bạn có muốn thêm môn học không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            } 
            MonHoc mon = GetMon();
            if(DBMonHoc.lstMonHoc().Any(n => n.Ma.ToLower().Trim() == mon.Ma.ToLower().Trim()))
            {
                MessageBox.Show("Mã môn học này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }
            if (DBMonHoc.ThemMonHoc(mon))
            {
                MessageBox.Show("Thêm môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvTheLoai.DataSource = DBMonHoc.lstMonHoc();
            }
            else
            {
                MessageBox.Show("Thêm môn học không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnXoaMonHoc_Click(object sender, EventArgs e)
        {
            if (txtMaMonHoc.Text == string.Empty)
            {
                MessageBox.Show("Ô mã không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa môn học không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!DBMonHoc.lstMonHoc().Any(n => n.Ma.ToLower().Trim() == txtMaMonHoc.Text.ToLower().Trim()))
            {
                MessageBox.Show("Mã môn học này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DBMonHoc.XoaMonHoc(txtMaMonHoc.Text))
            {
                MessageBox.Show("Xóa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvTheLoai.DataSource = DBMonHoc.lstMonHoc();
            }
            else
            {
                MessageBox.Show("Xóa môn học không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSuaMonHoc_Click(object sender, EventArgs e)
        {
            if (!KiemtraMonHoc()) return;
            if (MessageBox.Show("Bạn có muốn sửa môn học không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            MonHoc mon = GetMon();
            if (!DBMonHoc.lstMonHoc().Any(n => n.Ma.ToLower().Trim() == mon.Ma.ToLower().Trim()))
            {
                MessageBox.Show("Mã môn học này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DBMonHoc.SuaMonHoc(mon))
            {
                MessageBox.Show("Sửa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvTheLoai.DataSource = DBMonHoc.lstMonHoc();
            }
            else
            {
                MessageBox.Show("Sửa môn học không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgvTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            txtMaMonHoc.Text = dgvTheLoai.SelectedRows[0].Cells[1].Value.ToString();
            txtTenMonHoc.Text = dgvTheLoai.SelectedRows[0].Cells[2].Value.ToString();
            txtLuongCB.Text = dgvTheLoai.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void GhiTaiKhoan()
        {
            if (lst.Count <= 0) return;

            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (var item in lst)
                {
                    writer.WriteLine(item.TaiKhoan + "," + item.MatKhau);
                }
            }
        }
        private void KhoiDongMacDinh()
        {
            lst = new List<TaiKhoanMatKhau>();
            int i = 0;
            dgvTaiKhoanMatKhau.Rows.Clear();
            DocFileAccount();
            foreach (var item in lst)
            {
                dgvTaiKhoanMatKhau.Rows.Add(item.TruyenDuLieu(i));
                i++;
            }
        }
        private bool KiemTra()
        {
            if (txtTaiKhoan.Text == string.Empty)
            {
                MessageBox.Show("Ô tài khoản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txtMatKhau.Text == string.Empty)
            {
                MessageBox.Show("Ô mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            if(!KiemTra())
            {
                return;
            }
            if(MessageBox.Show("Bạn có muốn thêm tài khoản không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            lst.Add(new TaiKhoanMatKhau() { TaiKhoan = txtTaiKhoan.Text, MatKhau = txtMatKhau.Text });
            MessageBox.Show("Thêm thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GhiTaiKhoan();
            lst.Clear();
            KhoiDongMacDinh();
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            if (!KiemTra())
            {
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa tài khoản không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            var data = lst.SingleOrDefault(x => x.TaiKhoan == txtTaiKhoan.Text);
            if (lst.Remove(data))
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GhiTaiKhoan();
                lst.Clear();
                KhoiDongMacDinh();

            }
            else
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            if (!KiemTra())
            {
                return;
            }
            if (MessageBox.Show("Bạn có muốn sửa tài khoản không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            var data = lst.SingleOrDefault(x => x.TaiKhoan == txtTaiKhoan.Text);
            if (data!= null)
            {
                var index = lst.IndexOf(data);
                lst.Remove(data);
                lst.Insert(index, new TaiKhoanMatKhau() { TaiKhoan = txtTaiKhoan.Text, MatKhau = txtMatKhau.Text });
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GhiTaiKhoan();
                lst.Clear();
                KhoiDongMacDinh();
 
            }
            else
            {
                MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }

        private void dgvTaiKhoanMatKhau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            try
            {
                txtTaiKhoan.Text = dgvTaiKhoanMatKhau.SelectedRows[0].Cells[1].Value.ToString();
                txtMatKhau.Text = dgvTaiKhoanMatKhau.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Không thể chọn đối tượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ĐangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất tài khoản không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
 
            FormDangNhap frmDangNhap = new FormDangNhap();
            frmDangNhap.Show();
            frmMain.Hide();

        }

        private void ThayDoiMauSacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cdgMauVien.ShowDialog();
            panel1.BackColor = cdgMauVien.Color;
            panel2.BackColor = cdgMauVien.Color;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
