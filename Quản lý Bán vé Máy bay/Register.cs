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
    public partial class Register : Form
    {
        public Form LoginRef { get; set; }
        
        public Register()
        {
            InitializeComponent();
        }

        private void labelToLogin_Click(object sender, EventArgs e)
        {
            this.LoginRef.Show();
            Close();
        }

        private void labelClearField_Click(object sender, EventArgs e)
        {
            txtBoxUsername.Clear();
            txtBoxPassword.Clear();
            txtBoxUsername.Focus();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
