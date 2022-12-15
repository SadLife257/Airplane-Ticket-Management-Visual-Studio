using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Quản_lý_Bán_vé_Máy_bay
{
    public partial class XtraReportLoaiVe : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportLoaiVe()
        {
            InitializeComponent();
        }
        public void InitData(string tên_dịch_vụ)
        {
            Tên_dịch_vụ.Value = tên_dịch_vụ;
            //quanLyVeMayBayDataSet1.DataS
        }
    }
}
