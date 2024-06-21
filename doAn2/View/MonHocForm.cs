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
    public partial class MonHocForm : Form
    {
        MonHoc DBMonHoc = new MonHoc();
        public MonHocForm()
        {
            InitializeComponent();
        }

        private bool KiemtraMonHoc()
        {
            if (txtMaMonHoc.Text == string.Empty)
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
            if (MessageBox.Show("Bạn có muốn thêm môn học không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            MonHoc mon = GetMon();
            if (DBMonHoc.lstMonHoc().Any(n => n.Ma.ToLower().Trim() == mon.Ma.ToLower().Trim()))
            {
                MessageBox.Show("Mã môn học này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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

        private void MonHocForm_Load(object sender, EventArgs e)
        {
            dgvTheLoai.DataSource = DBMonHoc.lstMonHoc();
        }
    }
}
