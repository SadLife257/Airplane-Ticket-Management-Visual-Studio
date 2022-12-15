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
    public partial class DE_Khach_ReportForm_2 : DevExpress.XtraEditors.XtraForm
    {
        public DE_Khach_ReportForm_2()
        {
            InitializeComponent();
        }

        private void DE_Khach_ReportForm_2_Load(object sender, EventArgs e)
        {
            QuanLyVeMayBayEntities db = new QuanLyVeMayBayEntities();
            khachBindingSource.DataSource = db.Khách.ToList();
            veBindingSource.DataSource = db.Vé.ToList();
            chuyếnbayBindingSource.DataSource = db.Chuyến_bay.ToList();
            loaiveBindingSource.DataSource = db.Loại_vé.ToList();
            sânbayBindingSource.DataSource = db.Sân_bay.ToList();
        }

        private void btnTaoReport_Click(object sender, EventArgs e)
        {
            XtraReportKhachHang report = new XtraReportKhachHang();
            report.CreateDocument();
            ReportPrintTool review = new ReportPrintTool(report);
            review.ShowPreview();
        }
    }
}