using doAn2.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doAn2
{
    public partial class FormMain : Form
    {
        Button nutHienTai;
        bool check;
        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(bool check)
        {
            InitializeComponent();
            this.check = check;
        }
        private Form hientaiForm;
        private void MoForm(Form formcon)
        {
            pbBody.Visible = false;
            if(hientaiForm != null)
            {
                hientaiForm.Close();
            }

            hientaiForm = formcon;
            formcon.TopLevel = false;
            formcon.FormBorderStyle = FormBorderStyle.None;
            formcon.Dock = DockStyle.Fill;
            panelBody.Controls.Add(hientaiForm);
            //panelBody.Controls.Remove(pb)
            panelBody.Tag = formcon;
            formcon.BringToFront();
            formcon.Show();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            MoNut(sender, RGBMau.color1);
            FormSinhVien frm = new FormSinhVien();
            MoForm(frm);
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            MoNut(sender, RGBMau.color2);
            FormGiaoVien frm = new FormGiaoVien();  
            MoForm(frm);
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            panelBody.Controls.Clear();
            pbBody.Visible = true;
            panelBody.Controls.Add(pbBody);
        }

        private void MoNut(object sender, Color color)
        {

            if (sender != null)
            {
                HuyNut();
                nutHienTai = sender as Button;
                nutHienTai.ForeColor = color;
                nutHienTai.FlatAppearance.BorderColor = color;
                nutHienTai.FlatAppearance.BorderSize = 4;
                nutHienTai.Font = new Font("Segoe UI", 14, FontStyle.Bold);

            }
        }
        private void HuyNut()
        {
            if (nutHienTai != null)
            {
                nutHienTai.ForeColor = Color.White;
                nutHienTai.FlatAppearance.BorderColor = Color.White;
                nutHienTai.FlatAppearance.BorderSize = 2;
                nutHienTai.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            }
        }
        private struct RGBMau
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(255, 255, 105);
            public static Color color8 = Color.FromArgb(0, 227, 170);
            public static Color color9 = Color.FromArgb(67, 174, 208);
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            MoNut(sender, RGBMau.color3);
            FormLopHoc frm = new FormLopHoc();
            MoForm(frm);
        }

        private void btnChiTietLopHoc_Click(object sender, EventArgs e)
        {
            MoNut(sender, RGBMau.color4);
            FormChiTietLopHoc frm = new FormChiTietLopHoc();
            MoForm(frm);
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            MoNut(sender, RGBMau.color5);
            FormDiemSinhVien frm = new FormDiemSinhVien();
            MoForm(frm);
        }

        private void btnXuLyCongNo_Click(object sender, EventArgs e)
        {
            MoNut(sender, RGBMau.color6);
            FormNopTienHoc frm = new FormNopTienHoc();
            MoForm(frm);
        }

        private void btnGmail_Click(object sender, EventArgs e)
        {
            MoNut(sender, RGBMau.color6);
            FormGmail frm = new FormGmail();
            MoForm(frm);
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            MoNut(sender, RGBMau.color7);
            FormCaiDat frm = new FormCaiDat(this, panel1, panel2);
            MoForm(frm);
        }

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            btnSinhVien.Text = "Học viên";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            this.Hide();
            new FormDangNhap().ShowDialog();
        }
    }
}
