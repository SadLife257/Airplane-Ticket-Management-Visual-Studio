using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Quản_lý_Bán_vé_Máy_bay
{
    public partial class NhapKhach : Form
    {
        //Entity Framework
        //QuanLyVeMayBayEntities entities = new QuanLyVeMayBayEntities();
        //Toggle Action Insert(true)-Update(false)
        private bool toggleAction = true;

        public NhapKhach()
        {
            InitializeComponent();
        }

        private void NhapKhach_Load(object sender, EventArgs e)
        {
            ShowData("");
            khachID.Text = IdentificationGeneration();
            menuItemDelete.Enabled = false;
        }

        private string IdentificationGeneration()
        {
            string id = "KH";
            using (var context = new QuanLyVeMayBayEntities())
            {
                do
                {
                    Random rnd = new Random();
                    int random_number = rnd.Next(10000000, 99999999);
                    id += random_number.ToString();
                }
                while (context.Khách.Any(e => e.Mã_khách.Equals(id)));
                
            }
            return id;
        }

        private void ShowData(string id)
        {
            using (var context = new QuanLyVeMayBayEntities())
            {
                khachData.DataSource = context.Khách.ToList();

                khachData.Columns["Vé"].Visible = false;
            }
        }

        private void ClearInput()
        {
            khachID.Clear();
            khachName.Clear();
            khachCMND.Clear();
            khachPhone.Clear();
        }

        private void khachData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                khachID.Text = khachData.Rows[e.RowIndex].Cells["Mã_khách"].FormattedValue.ToString().Trim();
                khachName.Text = khachData.Rows[e.RowIndex].Cells["Tên_khách"].FormattedValue.ToString().Trim();
                khachCMND.Text = khachData.Rows[e.RowIndex].Cells["Số_CMND"].FormattedValue.ToString().Trim();
                khachPhone.Text = khachData.Rows[e.RowIndex].Cells["Số_điện_thoại"].FormattedValue.ToString().Trim();

                menuItemDelete.Enabled = true;
                toggleAction = false;
            }
        }

        private void ShowError()
        {
            MessageBox.Show("Some Field are not Filled", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool CheckField()
        {
            if (String.IsNullOrEmpty(khachID.Text) || String.IsNullOrWhiteSpace(khachID.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(khachName.Text) || String.IsNullOrWhiteSpace(khachName.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(khachCMND.Text) || String.IsNullOrWhiteSpace(khachCMND.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(khachPhone.Text) || String.IsNullOrWhiteSpace(khachPhone.Text))
            {
                return false;
            }
            return true;
        }

        private void InsertData()
        {
            using (var context = new QuanLyVeMayBayEntities())
            {
                var khach = new Khách()
                {
                    Mã_khách = khachID.Text.Trim(),
                    Tên_khách = khachName.Text.Trim(),
                    Số_CMND = khachCMND.Text.Trim(),
                    Số_điện_thoại = khachPhone.Text.Trim(),
                };
                context.Khách.Add(khach);

                context.SaveChanges();
            };
        }

        private void UpdateData()
        {
            using (var context = new QuanLyVeMayBayEntities())
            {
                var khach = context.Khách
                                   .Where(e => e.Mã_khách.Equals(khachID.Text))
                                   .First();
                if (khach != null)
                {
                    khach.Tên_khách = khachName.Text.Trim();
                    khach.Số_CMND = khachCMND.Text.Trim();
                    khach.Số_điện_thoại = khachPhone.Text.Trim();
                };

                context.SaveChanges();
            };
            menuItemDelete.Enabled = false;
            toggleAction = true;
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            if (toggleAction)
            {
                if (CheckField())
                {
                    InsertData();
                }
                else
                {
                    ShowError();
                }
            }
            else
            {
                if (CheckField())
                {
                    UpdateData();
                }
                else
                {
                    ShowError();
                }
            }
            
            ShowData("");
            ClearInput();
            NhapKhach_Load(sender, e);
            khachName.Focus();
        }

        private void menuItemSearch_Click(object sender, EventArgs e)
        {
            ShowData(khachID.Text);
            ClearInput();
        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            //Still have to check for forgein key
            DialogResult dialog = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialog == DialogResult.OK)
            {
                using (var context = new QuanLyVeMayBayEntities())
                {
                    var khach = new Khách()
                    {
                        Mã_khách = khachID.Text.Trim(),
                        Tên_khách = khachName.Text.Trim(),
                        Số_CMND = khachCMND.Text.Trim(),
                        Số_điện_thoại = khachPhone.Text.Trim(),
                    };
                    try
                    {
                        context.Khách.Attach(khach);
                        context.Khách.Remove(khach);

                        context.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Data was referenced in another table", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };
                
                ShowData("");
                ClearInput();
                menuItemDelete.Enabled = false;
                NhapKhach_Load(sender, e);
                khachName.Focus();
            }
        }

        private void menuItemClear_Click(object sender, EventArgs e)
        {
            ClearInput();
            menuItemDelete.Enabled = false;
            toggleAction = true;
            NhapKhach_Load(sender, e);
            khachName.Focus();
        }
    }
}
