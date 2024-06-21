using doAn2.Model;
using Microsoft.Reporting.WinForms;
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
    public partial class FormReport : Form
    {
        List<ChiTietLopHoc> lst = new List<ChiTietLopHoc> ();
        List<Diem> lstDiem = new List<Diem> ();
        string tenlop;
        EnumState type;
        public FormReport()
        {
            InitializeComponent();
        }
        public FormReport(List<ChiTietLopHoc> lst, string tenlop, EnumState type)
        {
            InitializeComponent();
            this.lst = lst;
            this.tenlop = tenlop;
            this.type = type;
        }
        public FormReport(List<Diem> lstDiem, string tenlop, EnumState type)
        {
            InitializeComponent();
            this.lstDiem = lstDiem;
            this.tenlop = tenlop;
            this.type = type;
        }
        private void FormReport_Load(object sender, EventArgs e)
        {

            this.reportViewer.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            switch (type)
            {
                case EnumState.ChiTietLopHoc:
                    reportViewer.LocalReport.ReportEmbeddedResource = "doAn2.Report.ReportChiTietLopHoc.rdlc";
                    ReportDataSource reportDataSource = new ReportDataSource();
                    reportDataSource.Name = "DataSetChiTietLopHoc";
                    reportDataSource.Value = lst;
                    ReportParameter[] reportParameters = new ReportParameter[]
                    {
                         new ReportParameter("Tenlop", tenlop)
                    };
                    this.reportViewer.LocalReport.SetParameters(reportParameters);
                    reportViewer.LocalReport.DataSources.Add(reportDataSource);
                    this.reportViewer.RefreshReport();
                    break;
                case EnumState.Diem:
                    reportViewer.LocalReport.ReportEmbeddedResource = "doAn2.Report.ReportDiem.rdlc";
                    ReportDataSource reportDataSourceDiem = new ReportDataSource();
                    reportDataSourceDiem.Name = "DataSetDiem";
                    reportDataSourceDiem.Value = lstDiem;
                    ReportParameter[] reportParametersDiem = new ReportParameter[]
                    {
                         new ReportParameter("Tenlop", tenlop)
                    };
                    this.reportViewer.LocalReport.SetParameters(reportParametersDiem);
                    reportViewer.LocalReport.DataSources.Add(reportDataSourceDiem);
                    this.reportViewer.RefreshReport();
                    break;
            }
            

        }
    }
}
