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
    public partial class Login : Form
    {
        private const string USERNAME = "admin";
        private const string PASSWORD = "123456";
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtBoxUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtBoxUsername.Text.Equals(USERNAME) && txtBoxPassword.Text.Equals(PASSWORD))
            {
                new MainScreen().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Your username or password is not correct!");
                txtBoxUsername.Focus();
            }
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

        private void labelRegister_Click(object sender, EventArgs e)
        {
            txtBoxUsername.Clear();
            txtBoxPassword.Clear();
            txtBoxUsername.Focus();

            Register form = new Register();
            form.LoginRef = this;
            Hide();
            form.Show();
        }
    }
}
