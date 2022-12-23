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
    public partial class NhapLoaiVe : Form
    {
        //Entity Framework
        //QuanLyVeMayBayEntities entities = new QuanLyVeMayBayEntities();
        //Toggle Action Insert(true)-Update(false)
        private bool toggleAction = true;

        public NhapLoaiVe()
        {
            InitializeComponent();
        }

        private void NhapLoaiVe_Load(object sender, EventArgs e)
        {
            txtBoxMaLoaiVe.Text = IdentificationGeneration();
            btnDelete.Enabled = false;

            using (var context = new QuanLyVeMayBayEntities())
            {
                var query = context.Dịch_vụ
                                   .Select(dichVu => new
                                   {
                                       MaDichVu = dichVu.Mã_dịch_vụ
                                   })
                                   .ToList();

                comBoxMaDichVu.Items.Clear();

                foreach (var dichVu in query)
                {
                    comBoxMaDichVu.Items.Add(dichVu.MaDichVu.ToString());
                }
            };

            ShowData("");
        }

        private string IdentificationGeneration()
        {
            string id = "LVID";

            using (var context = new QuanLyVeMayBayEntities())
            {
                do
                {
                    Random rnd = new Random();
                    int random_number = rnd.Next(100000, 999999);

                    id += random_number;
                } while (context.Loại_vé.Any(e => e.Mã_loại_vé.Equals(id)));
            }

            return id;
        }

        private void ShowData(string id)
        {
            using (var context = new QuanLyVeMayBayEntities())
            {
                loaiVeData.DataSource = context.Loại_vé
                                               .Select(e => new
                                               {
                                                   Mã_loại_vé = e.Mã_loại_vé,
                                                   Tên_loại_vé = e.Tên_loại_vé,
                                                   Giá_tiền = e.Giá_tiền,
                                                   Mã_dịch_vụ = e.Dịch_vụ.Tên_dịch_vụ
                                               })
                                               .OrderBy(e => e.Tên_loại_vé)
                                               .ToList();

                loaiVeData.Columns["Mã_loại_vé"].HeaderText = "Mã loại vé";
                loaiVeData.Columns["Tên_loại_vé"].HeaderText = "Tên loại vé";
                loaiVeData.Columns["Giá_tiền"].HeaderText = "Giá tiền";
                loaiVeData.Columns["Mã_dịch_vụ"].HeaderText = "Tên dịch vụ";

                //loaiVeData.Sort(loaiVeData.Columns["Tên_loại_vé"], ListSortDirection.Descending);

                //loaiVeData.Columns["Dịch_vụ"].Visible = false;
                //loaiVeData.Columns["Vé"].Visible = false;
            }
        }

        private void ClearInput()
        {
            txtBoxTenLoaiVe.Clear();
            txtBoxGiaTien.Clear();
            txtBoxMaLoaiVe.Clear();
            comBoxMaDichVu.SelectedIndex = -1;
        }


        private void txtBoxGiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void loaiVeData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                loaiVeData.CurrentRow.Selected = true;
                txtBoxMaLoaiVe.Text = loaiVeData.Rows[e.RowIndex].Cells["Mã_loại_vé"].FormattedValue.ToString().Trim();
                txtBoxTenLoaiVe.Text = loaiVeData.Rows[e.RowIndex].Cells["Tên_loại_vé"].FormattedValue.ToString().Trim();
                txtBoxGiaTien.Text = loaiVeData.Rows[e.RowIndex].Cells["Giá_tiền"].FormattedValue.ToString().Trim();
                comBoxMaDichVu.SelectedIndex = comBoxMaDichVu.Items.IndexOf(loaiVeData.Rows[e.RowIndex].Cells["Mã_dịch_vụ"].FormattedValue.ToString());

                btnDelete.Enabled = true;
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
            if (String.IsNullOrEmpty(txtBoxMaLoaiVe.Text) || String.IsNullOrWhiteSpace(txtBoxMaLoaiVe.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(txtBoxTenLoaiVe.Text) || String.IsNullOrWhiteSpace(txtBoxTenLoaiVe.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(txtBoxGiaTien.Text) || String.IsNullOrWhiteSpace(txtBoxGiaTien.Text))
            {
                return false;
            }
            if (comBoxMaDichVu.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void InsertData()
        {
            using (var context = new QuanLyVeMayBayEntities())
            {
                var loaiVe = new Loại_vé()
                {
                    Mã_loại_vé = txtBoxMaLoaiVe.Text.Trim(),
                    Tên_loại_vé = txtBoxTenLoaiVe.Text.Trim(),
                    Giá_tiền = int.Parse(txtBoxGiaTien.Text.Trim()),
                    Mã_dịch_vụ = comBoxMaDichVu.SelectedItem.ToString(),
                };
                context.Loại_vé.Add(loaiVe);

                context.SaveChanges();
            };
        }

        private void UpdateData()
        {
            using (var context = new QuanLyVeMayBayEntities())
            {
                var loaiVe = context.Loại_vé
                                        .Where(e => e.Mã_loại_vé.Equals(txtBoxMaLoaiVe.Text))
                                        .First();
                if (loaiVe != null)
                {
                    loaiVe.Tên_loại_vé = txtBoxTenLoaiVe.Text.Trim();
                    loaiVe.Giá_tiền = int.Parse(txtBoxGiaTien.Text.Trim());
                    loaiVe.Mã_dịch_vụ = comBoxMaDichVu.SelectedItem.ToString();
                };

                context.SaveChanges();
            };
            btnDelete.Enabled = false;
            toggleAction = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
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
            NhapLoaiVe_Load(sender, e);
            txtBoxTenLoaiVe.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialog == DialogResult.OK)
            {
                using (var context = new QuanLyVeMayBayEntities())
                {
                    var loaiVe = new Loại_vé
                    {
                        Mã_loại_vé = txtBoxMaLoaiVe.Text,
                        Tên_loại_vé = txtBoxTenLoaiVe.Text,
                        Giá_tiền = int.Parse(txtBoxGiaTien.Text),
                        Mã_dịch_vụ = comBoxMaDichVu.SelectedItem.ToString(),
                    };
                    try
                    {
                        context.Loại_vé.Attach(loaiVe);
                        context.Loại_vé.Remove(loaiVe);

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
                btnDelete.Enabled = false;
                NhapLoaiVe_Load(sender, e);
                txtBoxTenLoaiVe.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
            btnDelete.Enabled = false;
            toggleAction = true;
            NhapLoaiVe_Load(sender, e);
            txtBoxTenLoaiVe.Focus();
        }
    }
}
