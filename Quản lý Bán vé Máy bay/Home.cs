using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_Bán_vé_Máy_bay
{
    public partial class Home : Form
    {
        Form activeForm = null;

        public Home()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            btnCloseFrame.Visible = false;
            panelFunctionSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible)
            {
                subMenu.Visible = false;
            }
            else
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
        }

        private void HideSubMenu()
        {
            if (panelFunctionSubMenu.Visible)
            {
                panelFunctionSubMenu.Visible = true;
            }
        }

        private void OpenForm(Form f)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = f;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;

            panelFrame.Controls.Add(f);
            panelFrame.Tag = f;

            labelFrameTitlte.Text = "QUẢN LÝ " + f.Text.ToUpper();

            btnCloseFrame.Visible = true;

            f.BringToFront();
            f.Show();
        }

        private void btnChuyenbay_Click(object sender, EventArgs e)
        {
            OpenForm(new NhapChuyenBay());
        }

        private void btnDichvu_Click(object sender, EventArgs e)
        {
            OpenForm(new NhapDichVu());
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            OpenForm(new NhapKhach());
        }

        private void btnSanbay_Click(object sender, EventArgs e)
        {
            OpenForm(new NhapSanBay());
        }

        private void btnLoaive_Click(object sender, EventArgs e)
        {
            OpenForm(new NhapLoaiVe());
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            OpenForm(new NhapVe());
        }

        private void btnReportKhachhang_Click(object sender, EventArgs e)
        {
            OpenForm(new DE_Khach_ReportForm_2());
        }

        private void btnReportLoaive_Click(object sender, EventArgs e)
        {
            OpenForm(new DE_Loaive_ReportForm());
        }

        private void btnReportChuyenbay_Click(object sender, EventArgs e)
        {
            OpenForm(new DE_Chuyenbay_ReportForm());
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelFunctionSubMenu);
        }

        private void btnCloseFrame_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            labelFrameTitlte.Text = "HOME";
            btnCloseFrame.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinizize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
