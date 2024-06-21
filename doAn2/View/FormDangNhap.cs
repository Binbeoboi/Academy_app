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
    public partial class FormDangNhap : Form
    {
        string file = "Account.txt";
        List<TaiKhoanMatKhau> lst = new List<TaiKhoanMatKhau> ();
        bool IsDangNhap = false;
        public FormDangNhap()
        {
            InitializeComponent();
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

        

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(n => n.Text = string.Empty);
            txtTaiKhoan.Focus();
        }

        private void cbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if(cbHienThiMatKhau.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }
        private void KiemTraDangNhap()
        {
            int count = 0;
            foreach (var item in lst)
            {
                if (item.TaiKhoan.ToLower().Trim().CompareTo(txtTaiKhoan.Text.ToLower().Trim()) == 0 && item.MatKhau.ToLower().Trim().CompareTo(txtMatKhau.Text.ToLower().Trim()) == 0)
                {
                    IsDangNhap = true;
                }
                else
                {
                    count++;
                }
            }
            if(count == lst.Count)
            {
                IsDangNhap= false;
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            KiemTraDangNhap();
            if (IsDangNhap)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormMain frm = new FormMain();
                frm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            DocFileAccount();
        }
    }
}
