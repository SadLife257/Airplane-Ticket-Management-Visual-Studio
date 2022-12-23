using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;

namespace Quản_lý_Bán_vé_Máy_bay
{
    public partial class NhapVe : Form
    {
        //Entity Framework
        //QuanLyVeMayBayEntities entities = new QuanLyVeMayBayEntities();
        //Toggle Action Insert(true)-Update(false)
        private bool toggleAction = true;

        public NhapVe()
        {
            InitializeComponent();
        }

        private void NhapVe_Load(object sender, EventArgs e)
        {
            txtBoxSoVe.Text = IdentificationGeneration();
            btnDelete.Enabled = false;

            comBoxMaChuyenBay.Items.Clear();
            comBoxMaLoaiVe.Items.Clear();
            comBoxMaKhach.Items.Clear();

            using (var context = new QuanLyVeMayBayEntities())
            {
                var query = context.Chuyến_bay
                                   .Select(chuyenBay => new
                                   {
                                       MaChuyenBay = chuyenBay.Mã_chuyến_bay
                                   })
                                   .ToList();

                foreach (var chuyenBay in query)
                {
                    comBoxMaChuyenBay.Items.Add(chuyenBay.MaChuyenBay);
                }
            };

            using (var context = new QuanLyVeMayBayEntities())
            {
                var query = context.Loại_vé
                                   .Select(loaiVe => new
                                   {
                                       MaLoaiVe = loaiVe.Mã_loại_vé
                                   })
                                   .ToList();

                foreach (var loaiVe in query)
                {
                    comBoxMaLoaiVe.Items.Add(loaiVe.MaLoaiVe);
                }
            };

            using (var context = new QuanLyVeMayBayEntities())
            {
                var query = context.Khách
                                   .Select(khach => new
                                   {
                                       MaKhach = khach.Mã_khách
                                   })
                                   .ToList();

                foreach (var khach in query)
                {
                    comBoxMaKhach.Items.Add(khach.MaKhach);
                }
            };

            ShowData("");
        }

        private string IdentificationGeneration()
        {
            string id = "VID";

            using (var context = new QuanLyVeMayBayEntities())
            {
                do
                {
                    Random rnd = new Random();
                    int random_number = rnd.Next(1000000, 9999999);

                    id += random_number;
                } while (context.Vé.Any(e => e.Số_vé.Equals(id)));
            }

            return id;
        }

        private void ShowData(string id)
        {
            using (var context = new QuanLyVeMayBayEntities())
            {
                veData.DataSource = context.Vé
                                           .Select(e => new
                                           {
                                               Số_vé = e.Số_vé,
                                               Ngày_đặt_vé = e.Ngày_đặt_vé,
                                               Ngày_nhận_vé = e.Ngày_nhận_vé,
                                               Mã_chuyến_bay = e.Mã_chuyến_bay,
                                               Mã_loại_vé = e.Loại_vé.Tên_loại_vé,
                                               Mã_khách = e.Khách.Tên_khách
                                           })
                                           .OrderBy(e => e.Ngày_đặt_vé)
                                           .ToList();

                veData.Columns["Số_vé"].HeaderText = "Số vé";

                veData.Columns["Ngày_đặt_vé"].HeaderText = "Ngày đặt vé";
                veData.Columns["Ngày_đặt_vé"].DefaultCellStyle.Format = "dd/MM/yyyy";

                veData.Columns["Ngày_nhận_vé"].HeaderText = "Ngày nhận vé";
                veData.Columns["Ngày_nhận_vé"].DefaultCellStyle.Format = "dd/MM/yyyy";

                veData.Columns["Mã_chuyến_bay"].HeaderText = "Mã chuyến bay";
                veData.Columns["Mã_loại_vé"].HeaderText = "Tên loại vé";
                veData.Columns["Mã_khách"].HeaderText = "Tên khách";

                //veData.Columns["Chuyến_bay"].Visible = false;
                //veData.Columns["Khách"].Visible = false;
                //veData.Columns["Loại_vé"].Visible = false;

                //veData.Sort(veData.Columns["Ngày_đặt_vé"], ListSortDirection.Ascending);
            }
        }

        private void ClearInput()
        {
            txtBoxSoVe.Clear();
            comBoxMaChuyenBay.SelectedIndex = -1;
            comBoxMaLoaiVe.SelectedIndex = -1;
            comBoxMaKhach.SelectedIndex = -1;
        }

        private void veData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                veData.CurrentRow.Selected = true;
                txtBoxSoVe.Text = veData.Rows[e.RowIndex].Cells["Số_vé"].FormattedValue.ToString().Trim();
                dtPickerNgayDatVe.Value = DateTime.ParseExact(veData.Rows[e.RowIndex].Cells["Ngày_đặt_vé"].FormattedValue.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                dtPickerNgayNhanVe.Value = DateTime.ParseExact(veData.Rows[e.RowIndex].Cells["Ngày_nhận_vé"].FormattedValue.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                comBoxMaChuyenBay.SelectedIndex = comBoxMaChuyenBay.Items.IndexOf(veData.Rows[e.RowIndex].Cells["Mã_chuyến_bay"].FormattedValue.ToString());
                comBoxMaLoaiVe.SelectedIndex = comBoxMaLoaiVe.Items.IndexOf(veData.Rows[e.RowIndex].Cells["Mã_loại_vé"].FormattedValue.ToString());
                comBoxMaKhach.SelectedIndex = comBoxMaKhach.Items.IndexOf(veData.Rows[e.RowIndex].Cells["Mã_khách"].FormattedValue.ToString());

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
            if (String.IsNullOrEmpty(txtBoxSoVe.Text) || String.IsNullOrWhiteSpace(txtBoxSoVe.Text))
            {
                return false;
            }
            if(comBoxMaChuyenBay.SelectedIndex == -1)
            {
                return false;
            }
            if(comBoxMaLoaiVe.SelectedIndex == -1)
            {
                return false;
            }
            if(comBoxMaKhach.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void InsertData()
        {
            using (var context = new QuanLyVeMayBayEntities())
            {
                var ve = new Vé()
                {
                    Số_vé = txtBoxSoVe.Text.Trim(),
                    Ngày_đặt_vé = dtPickerNgayDatVe.Value.Date,
                    Ngày_nhận_vé = dtPickerNgayNhanVe.Value.Date,
                    Mã_chuyến_bay = comBoxMaChuyenBay.SelectedItem.ToString(),
                    Mã_loại_vé = comBoxMaLoaiVe.SelectedItem.ToString(),
                    Mã_khách = comBoxMaKhach.SelectedItem.ToString(),
                };
                context.Vé.Add(ve);

                context.SaveChanges();
            };
        }

        private void UpdateData()
        {
            using (var context = new QuanLyVeMayBayEntities())
            {
                var ve = context.Vé
                                .Where(e => e.Số_vé.Equals(txtBoxSoVe.Text.Trim()))
                                .First();
                if (ve != null)
                {
                    ve.Ngày_đặt_vé = dtPickerNgayDatVe.Value.Date;
                    ve.Ngày_nhận_vé = dtPickerNgayNhanVe.Value.Date;
                    ve.Mã_chuyến_bay = comBoxMaChuyenBay.SelectedItem.ToString();
                    ve.Mã_loại_vé = comBoxMaLoaiVe.SelectedItem.ToString();
                    ve.Mã_khách = comBoxMaKhach.SelectedItem.ToString();
                }

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
            NhapVe_Load(sender, e);
            dtPickerNgayDatVe.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialog == DialogResult.OK)
            {
                using (var context = new QuanLyVeMayBayEntities())
                {
                    var ve = new Vé()
                    {
                        Số_vé = txtBoxSoVe.Text,
                        Ngày_đặt_vé = dtPickerNgayDatVe.Value.Date,
                        Ngày_nhận_vé = dtPickerNgayNhanVe.Value.Date,
                        Mã_chuyến_bay = comBoxMaChuyenBay.SelectedItem.ToString(),
                        Mã_loại_vé = comBoxMaLoaiVe.SelectedItem.ToString(),
                        Mã_khách = comBoxMaKhach.SelectedItem.ToString(),
                    };
                    context.Vé.Attach(ve);
                    context.Vé.Remove(ve);

                    context.SaveChanges();
                };

                ShowData("");
                ClearInput();
                btnDelete.Enabled = false;
                NhapVe_Load(sender, e);
                dtPickerNgayDatVe.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
            btnDelete.Enabled = false;
            toggleAction = true;
            NhapVe_Load(sender, e);
            dtPickerNgayDatVe.Focus();
        }
    }
}
