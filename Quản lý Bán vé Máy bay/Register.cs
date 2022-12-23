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

        private bool CheckField()
        {
            if(String.IsNullOrEmpty(txtBoxEmail.Text) || String.IsNullOrWhiteSpace(txtBoxEmail.Text))
            {
                MessageBox.Show("Email Already Exist");
                return false;
            }
            else if (String.IsNullOrEmpty(txtBoxPassword.Text) || String.IsNullOrWhiteSpace(txtBoxPassword.Text))
            {
                return false;
            }
            else if (String.IsNullOrEmpty(txtBoxConfirmPassword.Text) || String.IsNullOrWhiteSpace(txtBoxConfirmPassword.Text))
            {
                return false;
            }
            else if(!txtBoxPassword.Text.Equals(txtBoxConfirmPassword.Text))
            {
                MessageBox.Show("Password Incorrect");
                return false;
            }
            return true;
        }

        private void ClearField()
        {
            txtBoxEmail.Clear();
            txtBoxPassword.Clear();
            txtBoxConfirmPassword.Clear();
            txtBoxEmail.Focus();
        }

        private void labelToLogin_Click(object sender, EventArgs e)
        {
            this.LoginRef.Show();
            Close();
        }

        private void labelClearField_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(CheckField())
            {
                using (var context = new QuanLyVeMayBayEntities())
                {
                    var taiKhoan = new Tài_khoản()
                    {
                        email = txtBoxEmail.Text.Trim(),
                        password = txtBoxPassword.Text
                    };
                    context.Tài_khoản.Add(taiKhoan);

                    context.SaveChanges();

                    this.LoginRef.Show();
                    Close();
                };
            }

            else
            {
                ClearField();
            }
        }
    }
}
