using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Quản_lý_Bán_vé_Máy_bay
{
    public partial class XtraReportChuyenBay : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportChuyenBay()
        {
            InitializeComponent();
        }

        public void InitData(string tên_sân_bay, string tên_sân_bay1)
        {
            Tên_sân_bay_đi.Value = tên_sân_bay;
            Tên_sân_bay_đến.Value = tên_sân_bay1;
            //quanLyVeMayBayDataSet1.DataS
        }
    }
}
