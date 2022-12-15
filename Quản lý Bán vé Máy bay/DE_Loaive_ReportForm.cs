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
    public partial class DE_Loaive_ReportForm : DevExpress.XtraEditors.XtraForm
    {
        public DE_Loaive_ReportForm()
        {
            InitializeComponent();
        }

        private void DE_Loaive_ReportForm_Load(object sender, EventArgs e)
        {
            QuanLyVeMayBayEntities db = new QuanLyVeMayBayEntities();
            loaiveBindingSource.DataSource = db.Loại_vé.ToList();
            dịchvụBindingSource.DataSource = db.Dịch_vụ.ToList();
        }

        private void btnTaoReport_Click(object sender, EventArgs e)
        {
            XtraReportLoaiVe report = new XtraReportLoaiVe();
            report.CreateDocument();
            ReportPrintTool review = new ReportPrintTool(report);
            review.ShowPreview();
        }
    }
}