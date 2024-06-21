using doAn2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace doAn2.View
{
    public partial class ThongKeForm : Form
    {
        LopHoc DBLop = new LopHoc();
        Diem DBDiem = new Diem();
        public ThongKeForm()
        {
            InitializeComponent();
        }

        private void ThongKeForm_Load(object sender, EventArgs e)
        {
            cbbLop.DataSource = DBLop.lstLopHoc();
            dgvDiem.Columns["Ma"].Visible = false;
            dgvDiem.Columns["TenLop"].Visible = false;
        }

        private void cbbLop_TextChanged(object sender, EventArgs e)
        {
            if(cbbLop.Text == string.Empty)
            {
                dgvDiem.Rows.Clear();
                return;
            }
            dgvDiem.DataSource = DBDiem.lstDiem().Where(n => n.TenLop == cbbLop.Text).OrderByDescending(n => n.DiemTrungBinh).Take(5).ToList();


        }

        private void cbbLop_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
