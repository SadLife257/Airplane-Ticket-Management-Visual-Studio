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
    public partial class NhapSanBay : Form
    {
        //Entity Framework
        //QuanLyVeMayBayEntities entities = new QuanLyVeMayBayEntities();
        //Toggle Action Insert(true)-Update(false)
        private bool toggleAction = true;

        public NhapSanBay()
        {
            InitializeComponent();
        }

        private void NhapSanBay_Load(object sender, EventArgs e)
        {
            txtBoxMaSanBay.Text = IdentificationGeneration();
            comBoxTinhThanhPho.Items.Clear();
            string path = @"D:\TDTU - Y3 - HK1\Software Engineering\Final Report\Projects\Update\Quản lý Bán vé máy bay\Quản lý Bán vé Máy bay\ds_tinhthanh.txt";
            List<string> lines = System.IO.File.ReadLines(path).ToList();
            foreach (string line in lines)
            {
                comBoxTinhThanhPho.Items.Add(line);
            }

            menuItemDelete.Enabled = false;
            ShowData("");
        }

        private string IdentificationGeneration()
        {
            string id = "SBID";

            using (var context = new QuanLyVeMayBayEntities())
            {
                do
                {
                    Random rnd = new Random();
                    int random_number = rnd.Next(100000, 999999);

                    id += random_number;
                } while (context.Sân_bay.Any(e => e.Mã_sân_bay.Equals(id)));
            }

            return id;
        }

        private void ShowData(string id)
        {
            using (var context = new QuanLyVeMayBayEntities())
            {
                sanBayData.DataSource = context.Sân_bay.ToList();

                sanBayData.Columns["Chuyến_bay"].Visible = false;
                sanBayData.Columns["Chuyến_bay1"].Visible = false;
            }
        }

        private void ClearInput()
        {
            txtBoxMaSanBay.Clear();
            txtBoxTenSanBay.Clear();
            comBoxTinhThanhPho.SelectedIndex = -1;
        }

        private void sanBayData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (sanBayData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    sanBayData.CurrentRow.Selected = true;
                    txtBoxMaSanBay.Text = sanBayData.Rows[e.RowIndex].Cells["Mã_sân_bay"].FormattedValue.ToString().Trim();
                    txtBoxTenSanBay.Text = sanBayData.Rows[e.RowIndex].Cells["Tên_sân_bay"].FormattedValue.ToString().Trim();
                    comBoxTinhThanhPho.SelectedIndex = comBoxTinhThanhPho.Items.IndexOf(sanBayData.Rows[e.RowIndex].Cells["Tỉnh_Thành_phố"].FormattedValue.ToString());

                    menuItemDelete.Enabled = true;
                    toggleAction = false;
                }
            }
        }

        private void ShowError()
        {
            MessageBox.Show("Some Field are not Filled", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool CheckField()
        {
            if (String.IsNullOrEmpty(txtBoxMaSanBay.Text) || String.IsNullOrWhiteSpace(txtBoxMaSanBay.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(txtBoxTenSanBay.Text) || String.IsNullOrWhiteSpace(txtBoxTenSanBay.Text))
            {
                return false;
            }
            if(comBoxTinhThanhPho.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void InsertData()
        {
            using (var context = new QuanLyVeMayBayEntities())
            {
                var sanBay = new Sân_bay()
                {
                    Mã_sân_bay = txtBoxMaSanBay.Text.Trim(),
                    Tên_sân_bay = txtBoxTenSanBay.Text.Trim(),
                    Tỉnh_Thành_phố = comBoxTinhThanhPho.SelectedItem.ToString()
                };
                context.Sân_bay.Add(sanBay);

                context.SaveChanges();
            };
        }

        private void UpdateData()
        {
            using (var context = new QuanLyVeMayBayEntities())
            {
                var sanBay = context.Sân_bay
                                    .Where(e => e.Mã_sân_bay.Equals(txtBoxMaSanBay.Text))
                                    .First();
                if (sanBay != null)
                {
                    sanBay.Tên_sân_bay = txtBoxTenSanBay.Text.Trim();
                    sanBay.Tỉnh_Thành_phố = comBoxTinhThanhPho.SelectedItem.ToString();
                }

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
            NhapSanBay_Load(sender, e);
            txtBoxTenSanBay.Focus();
        }

        private void menuItemSearch_Click(object sender, EventArgs e)
        {
            ShowData(txtBoxMaSanBay.Text);
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
                    var sanBay = new Sân_bay()
                    {
                        Mã_sân_bay = txtBoxMaSanBay.Text,
                        Tên_sân_bay = txtBoxTenSanBay.Text,
                        Tỉnh_Thành_phố = comBoxTinhThanhPho.SelectedItem.ToString()
                    };
                    try
                    {
                        context.Sân_bay.Attach(sanBay);
                        context.Sân_bay.Remove(sanBay);

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
                NhapSanBay_Load(sender, e);
                txtBoxTenSanBay.Focus();
            }
        }

        private void menuItemClear_Click(object sender, EventArgs e)
        {
            ClearInput();
            menuItemDelete.Enabled = false;
            toggleAction = true;
            NhapSanBay_Load(sender, e);
            txtBoxTenSanBay.Focus();
        }
    }
}
