using DevExpress.XtraEditors;
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
    public partial class DE_Khach_ReportForm : DevExpress.XtraEditors.XtraForm
    {
        public DE_Khach_ReportForm()
        {
            InitializeComponent();
        }

        private void DE_Khach_ReportForm_Load(object sender, EventArgs e)
        {
            QuanLyVeMayBayEntities db = new QuanLyVeMayBayEntities();
            veBindingSource.DataSource = db.Vé.ToList();
            khachBindingSource.DataSource = db.Khách.ToList();
        }
    }
}