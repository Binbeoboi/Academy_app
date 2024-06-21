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
    public partial class BaoCaoLuong : Form
    {
        LopHoc DBLop = new LopHoc();
        ChiTietLopHoc db = new ChiTietLopHoc();
        public BaoCaoLuong()
        {
            InitializeComponent();
        }
        private void ExportExcel(string path)
        {
            Excel.Application app = new Excel.Application();
            app.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgvDiem.Columns.Count - 1; i++)
            {
                app.Cells[1, i + 1] = dgvDiem.Columns[i].HeaderText;
            }

            for (int i = 0; i < dgvDiem.Rows.Count; i++)
            {
                for (int j = 0; j < dgvDiem.Columns.Count - 1; j++)
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

        private void BaoCaoLuong_Load(object sender, EventArgs e)
        {
            cbbLop.DataSource = DBLop.lstLopHoc();
            dgvDiem.Columns["TenLop"].Visible = false;
            dgvDiem.Columns["Ma"].Visible = false;
        }

        private void cbbLop_TextChanged(object sender, EventArgs e)
        {
            if(cbbLop.Text == string.Empty)
            {
                dgvDiem.Rows.Clear();
                return;
            }

            dgvDiem.DataSource = db.lstChiTietLopHoc().Where(n => n.TenLop.ToLower().Trim().CompareTo(cbbLop.Text.ToLower().Trim()) == 0).ToList();
        }

        private void cbbThongKe_TextChanged(object sender, EventArgs e)
        {
            //dgvDiem.DataSource = db.lstChiTietLopHoc().Where(n => n.TenLop.ToLower().Trim().CompareTo(cbbLop.Text.ToLower().Trim()) == 0).Where(n => n.).ToList();
        }

        private void cbbThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbThongKe.SelectedIndex == 0)
            {
                dgvDiem.DataSource = db.lstChiTietLopHoc().Where(n => n.TenLop.ToLower().Trim().CompareTo(cbbLop.Text.ToLower().Trim()) == 0).Where(n => n.CongNo > 0).ToList();
            }
            else if(cbbThongKe.SelectedIndex == 1)
            {
                dgvDiem.DataSource = db.lstChiTietLopHoc().Where(n => n.TenLop.ToLower().Trim().CompareTo(cbbLop.Text.ToLower().Trim()) == 0).Where(n => n.BuoiNghi > 0).ToList();
            }
        }
    }
}
