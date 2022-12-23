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
    public partial class MainScreen : Form
    {
        Form formChuyenBay = new NhapChuyenBay();
        Form formDichVu = new NhapDichVu();
        Form formKhach = new NhapKhach();
        Form formLoaiVe = new NhapLoaiVe();
        Form formSanBay = new NhapSanBay();
        Form formVe = new NhapVe();

        Form formExportReview = new ExportReview();

        Form de_formReport;
        public MainScreen()
        {
            InitializeComponent();
        }

        private void quảnLýChuyếnBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(formChuyenBay.IsDisposed)
            {
                formChuyenBay = new NhapChuyenBay();
                formChuyenBay.Show();
            }
            else
            {
                if (!formChuyenBay.Visible)
                {
                    formChuyenBay.Show();
                }
                else
                {
                    Application.OpenForms[formChuyenBay.Name].Focus();
                }
            }
        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formDichVu.IsDisposed)
            {
                formDichVu = new NhapDichVu();
                formDichVu.Show();
            }
            else
            {
                if (!formDichVu.Visible)
                {
                    formDichVu.Show();
                }
                else
                {
                    Application.OpenForms[formDichVu.Name].Focus();
                }
            }
        }

        private void quảnLýKháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formKhach.IsDisposed)
            {
                formKhach = new NhapKhach();
                formKhach.Show();
            }
            else
            {
                if (!formKhach.Visible)
                {
                    formKhach.Show();
                }
                else
                {
                    Application.OpenForms[formKhach.Name].Focus();
                }
            }
        }

        private void quảnLýLoạiVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formLoaiVe.IsDisposed)
            {
                formLoaiVe = new NhapLoaiVe();
                formLoaiVe.Show();
            }
            else
            {
                if (!formLoaiVe.Visible)
                {
                    formLoaiVe.Show();
                }
                else
                {
                    Application.OpenForms[formLoaiVe.Name].Focus();
                }
            }
        }

        private void quảnLýSânBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formSanBay.IsDisposed)
            {
                formSanBay = new NhapSanBay();
                formSanBay.Show();
            }
            else
            {
                if (!formSanBay.Visible)
                {
                    formSanBay.Show();
                }
                else
                {
                    Application.OpenForms[formSanBay.Name].Focus();
                }
            }
        }

        private void quảnLýVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formVe.IsDisposed)
            {
                formVe = new NhapVe();
                formVe.Show();
            }
            else
            {
                if (!formVe.Visible)
                {
                    formVe.Show();
                }
                else
                {
                    Application.OpenForms[formVe.Name].Focus();
                }
            }
        }

        private void OpenExportWindow()
        {
            if (formExportReview.IsDisposed)
            {
                formExportReview = new ExportReview();
                formExportReview.Show();
            }
            else
            {
                if (!formExportReview.Visible)
                {
                    formExportReview.Show();
                }
                else
                {
                    Application.OpenForms[formExportReview.Name].Focus();
                }
            }
        }

        private void menuItemExportChuyenBay_Click(object sender, EventArgs e)
        {
            OpenExportWindow();

            using (var context = new QuanLyVeMayBayEntities())
            {
                ExportReview.formInstance.gridView.DataSource = context.Chuyến_bay.ToList();

                ExportReview.formInstance.gridView.Columns["Sân_bay"].Visible = false;
                ExportReview.formInstance.gridView.Columns["Sân_bay1"].Visible = false;
                ExportReview.formInstance.gridView.Columns["Vé"].Visible = false;
            }
        }

        private void menuItemExportDichVu_Click(object sender, EventArgs e)
        {
            OpenExportWindow();

            using (var context = new QuanLyVeMayBayEntities())
            {
                ExportReview.formInstance.gridView.DataSource = context.Dịch_vụ.ToList();
                ExportReview.formInstance.gridView.Columns["Loại_vé"].Visible = false;
            }
        }

        private void menuItemExportKhach_Click(object sender, EventArgs e)
        {
            OpenExportWindow();

            using (var context = new QuanLyVeMayBayEntities())
            {
                ExportReview.formInstance.gridView.DataSource = context.Khách.ToList();

                ExportReview.formInstance.gridView.Columns["Vé"].Visible = false;
            }
        }

        private void menuItemExportLoaiVe_Click(object sender, EventArgs e)
        {
            OpenExportWindow();

            using (var context = new QuanLyVeMayBayEntities())
            {
                ExportReview.formInstance.gridView.DataSource = context.Loại_vé.ToList();

                ExportReview.formInstance.gridView.Columns["Dịch_vụ"].Visible = false;
                ExportReview.formInstance.gridView.Columns["Vé"].Visible = false;
            }
        }

        private void menuItemExportSanBay_Click(object sender, EventArgs e)
        {
            OpenExportWindow();

            using (var context = new QuanLyVeMayBayEntities())
            {
                ExportReview.formInstance.gridView.DataSource = context.Sân_bay.ToList();

                ExportReview.formInstance.gridView.Columns["Chuyến_bay"].Visible = false;
                ExportReview.formInstance.gridView.Columns["Chuyến_bay1"].Visible = false;
            }
        }

        private void menuItemExportVe_Click(object sender, EventArgs e)
        {
            OpenExportWindow();

            using (var context = new QuanLyVeMayBayEntities())
            {
                ExportReview.formInstance.gridView.DataSource = context.Vé.ToList();

                ExportReview.formInstance.gridView.Columns["Chuyến_bay"].Visible = false;
                ExportReview.formInstance.gridView.Columns["Khách"].Visible = false;
                ExportReview.formInstance.gridView.Columns["Loại_vé"].Visible = false;
            }
        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        /*
        private void chuyếnBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formReport.IsDisposed)
            {
                formReport = new ReportForm();
                formReport.LoadSBCB();
                formReport.Show();
            }
            else
            {
                if (!formReport.Visible)
                {
                    formReport.LoadSBCB();
                    formReport.Show();
                }
                else
                {
                    Application.OpenForms[formReport.Name].Focus();
                }
            }
        }

        private void loạiVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formReport.IsDisposed)
            {
                formReport = new ReportForm();
                formReport.LoadDVLV();
                formReport.Show();
            }
            else
            {
                if (!formReport.Visible)
                {
                    formReport.LoadDVLV();
                    formReport.Show();
                }
                else
                {
                    Application.OpenForms[formReport.Name].Focus();
                }
            }
        }
        */

        private void chuyếnBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (de_formReport == null || de_formReport.IsDisposed)
            {
                de_formReport = new DE_Chuyenbay_ReportForm();
                de_formReport.Show();
            }
            else
            {
                if (!de_formReport.Visible)
                {
                    de_formReport.Show();
                }
                else
                {
                    Application.OpenForms[de_formReport.Name].Focus();
                }
            }
        }

        private void loạiVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (de_formReport == null || de_formReport.IsDisposed)
            {
                de_formReport = new DE_Loaive_ReportForm();
                de_formReport.Show();
            }
            else
            {
                if (!de_formReport.Visible)
                {
                    de_formReport.Show();
                }
                else
                {
                    Application.OpenForms[de_formReport.Name].Focus();
                }
            }
        }

        private void kháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (de_formReport == null || de_formReport.IsDisposed)
            {
                de_formReport = new DE_Khach_ReportForm();
                de_formReport.Show();
            }
            else
            {
                if (!de_formReport.Visible)
                {
                    de_formReport.Show();
                }
                else
                {
                    Application.OpenForms[de_formReport.Name].Focus();
                }
            }
        }

        private void generateCustomerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (de_formReport == null || de_formReport.IsDisposed)
            {
                de_formReport = new DE_ReportForm_Main();
                de_formReport.Show();
            }
            else
            {
                if (!de_formReport.Visible)
                {
                    de_formReport.Show();
                }
                else
                {
                    Application.OpenForms[de_formReport.Name].Focus();
                }
            }
        }
    }
}
