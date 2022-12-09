using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quản_lý_Bán_vé_Máy_bay
{
    public partial class MainHub : Form
    {
        private Form activeForm = null;

        public MainHub()
        {
            InitializeComponent();
            FunctionSubMenu();
        }

        private void FunctionSubMenu()
        {
            panelFunctionSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if(subMenu.Visible)
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
            if(activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = f;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;

            panelActiveForm.Controls.Add(f);
            panelActiveForm.Tag = f;

            labHeader.Text = f.Text;

            f.BringToFront();
            f.Show();
        }
        //Home Portion
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }
        //Function Portion
        private void btnFunction_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelFunctionSubMenu);
        }

        private void btnChuyenBay_Click(object sender, EventArgs e)
        {
            OpenForm(new NhapChuyenBay());
        }

        private void btnSanBay_Click(object sender, EventArgs e)
        {
            OpenForm(new NhapSanBay());
        }

        private void btnKhach_Click(object sender, EventArgs e)
        {
            OpenForm(new NhapKhach());
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            OpenForm(new NhapVe());
        }

        private void btnLoaiVe_Click(object sender, EventArgs e)
        {
            OpenForm(new NhapLoaiVe());
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            OpenForm(new NhapDichVu());
        }

        
        //Setting Portion
        //Log Out Portion
    }
}
