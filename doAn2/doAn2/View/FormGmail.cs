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
    public partial class FormGmail : Form
    {
        string url = "https://mail.google.com";
        public FormGmail()
        {
            InitializeComponent();
        }

        private void FormGmail_Load(object sender, EventArgs e)
        {
            KhoiTaoBrowser();

        }
        private async Task Initialized()
        {
            await webViewGmail.EnsureCoreWebView2Async(null);
        }
        private async void KhoiTaoBrowser()
        {
            try
            {
                await Initialized();
                webViewGmail.CoreWebView2.Navigate(url);
            }
            catch
            {
                MessageBox.Show("Đã có lỗi khi thực hiện.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
