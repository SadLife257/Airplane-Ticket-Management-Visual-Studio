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

namespace Quản_lý_Bán_vé_Máy_bay
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
        
        public void LoadDVLV()
        {
            DataTable dt = DVLVAdapter.GetData();
            MessageBox.Show(dt.Rows[0][0].ToString());
            reportViewer1.LocalReport.ReportPath = "Report_DVLV.rdlc";
            ReportDataSource src = new ReportDataSource("DVLV", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(src);
            this.reportViewer1.RefreshReport();
        }

        public void LoadSBCB()
        {
            DataTable dt = SBCBAdapter.GetData();

            reportViewer1.LocalReport.ReportPath = "Report_SBCB.rdlc";
            ReportDataSource src = new ReportDataSource("SBCB", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(src);
            this.reportViewer1.RefreshReport();
        }
        
    }
}
