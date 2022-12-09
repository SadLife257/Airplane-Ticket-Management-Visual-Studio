using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class DE_Chuyenbay_ReportForm : DevExpress.XtraEditors.XtraForm
    {

        public DE_Chuyenbay_ReportForm()
        {
            InitializeComponent();
        }

        private void DE_ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyVeMayBayDataSet.SBCB' table. You can move, or remove it, as needed.
            //this.sBCBAdapter.Fill(this.quanLyVeMayBayDataSet.SBCB);
            QuanLyVeMayBayEntities db = new QuanLyVeMayBayEntities();
            chuyếnbayBindingSource.DataSource = db.Chuyến_bay.ToList();
            sânbayBindingSource.DataSource = db.Sân_bay.ToList();
            //dịchvụBindingSource.DataSource = db.Dịch_vụ.ToList();
        }

        private void btnTaoReport_Click(object sender, EventArgs e)
        {
            XtraReportChuyenBay report = new XtraReportChuyenBay();
            report.CreateDocument();
            ReportPrintTool review = new ReportPrintTool(report);
            review.ShowPreview();
        }
    }
}