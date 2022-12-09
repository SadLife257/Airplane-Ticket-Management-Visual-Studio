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
    public partial class NhapChuyenBay : Form
    {
        //Option --> Designer --> Prevent..., sau đó vào .edmx --> Update Model...
        //Insert and Update into one, change when click on DataGrid
        //Mã không thay đổi với demo của thầy, nhưng phải đổi lúc update trong demo của tao
        //Import - Export file excel
        //https://www.c-sharpcorner.com/UploadFile/ankurmee/import-data-from-excel-to-datagridview-in-C-Sharp/
        //==true ? Nam : Nữ
        //Search with infomation (new Form)
        //In report (2 loại Report View (làm cái này) vs Crystal Report)
        //Chuyển sang dùng Dev Express (tìm bản crack)
        //Entity Framework
        //QuanLyVeMayBayEntities entities = new QuanLyVeMayBayEntities();
        //Toggle Action Insert(true)-Update(false)
        private bool toggleAction = true;
        public NhapChuyenBay()
        {
            InitializeComponent();
        }

        private void NhapChuyenBay_Load(object sender, EventArgs e)
        {
            txtBoxMaChuyenBay.Text = IdentificationGeneration();
            menuItemDelete.Enabled = false;
            
            using (var context = new QuanLyVeMayBayEntities())
            {
                var query = context.Sân_bay
                                   .Select(sanBay => new 
                                   {
                                       MaSanBay = sanBay.Mã_sân_bay
                                   })
                                   .ToList();

                comBoxMaSanBayDi.Items.Clear();
                comBoxMaSanBayDen.Items.Clear();

                foreach (var sanBay in query)
                {
                    comBoxMaSanBayDi.Items.Add(sanBay.MaSanBay.ToString());
                    comBoxMaSanBayDen.Items.Add(sanBay.MaSanBay.ToString());
                }
            };

            labelTenSanbayDi.Visible = false;
            labelTenSanbayDen.Visible = false;

            ShowData("");
        }

        private string IdentificationGeneration()
        {
            string id = "CBID";

            using (var context = new QuanLyVeMayBayEntities())
            {
                do
                {
                    Random rnd = new Random();
                    int random_number = rnd.Next(100000, 999999);

                    id += random_number;
                } while (context.Chuyến_bay.Any(e => e.Mã_chuyến_bay.Equals(id)));
            }
            
            return id;
        }

        private void ShowData(string id)
        {
            using (var context = new QuanLyVeMayBayEntities())
            {
                chuyenBayData.DataSource = context.Chuyến_bay.ToList();

                chuyenBayData.Columns["Sân_bay"].Visible = false;
                chuyenBayData.Columns["Sân_bay1"].Visible = false;
                chuyenBayData.Columns["Vé"].Visible = false;
            }
        }

        private void ClearInput()
        {
            txtBoxMaChuyenBay.Clear();
            txtBoxLoaiMayBay.Clear();
            txtBoxSoChoNgoi.Clear();
            comBoxMaSanBayDi.SelectedIndex = -1;
            comBoxMaSanBayDen.SelectedIndex = -1;
            dtPickerGioKhoiHanh.Value = DateTime.Now;
            dtPickerNgayKhoiHanh.Value = DateTime.Now;
        }

        private void comBoxMaSanBayDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comBoxMaSanBayDi.SelectedIndex < 0)
            {
                labelTenSanbayDi.Visible = false;
            }
            else
            {
                labelTenSanbayDi.Visible = true;
                using (var context = new QuanLyVeMayBayEntities())
                {
                    var query = context.Sân_bay
                                       .First(sanBay => sanBay.Mã_sân_bay == comBoxMaSanBayDi.SelectedItem.ToString());

                    labelTenSanbayDi.Text = query.Tên_sân_bay.ToString();
                };
            }
        }

        private void comBoxMaSanBayDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBoxMaSanBayDen.SelectedIndex < 0)
            {
                labelTenSanbayDen.Visible = false;
            }
            else
            {
                labelTenSanbayDen.Visible = true;
                using (var context = new QuanLyVeMayBayEntities())
                {
                    var query = context.Sân_bay
                                       .First(sanBay => sanBay.Mã_sân_bay == comBoxMaSanBayDen.SelectedItem.ToString());

                    labelTenSanbayDen.Text = query.Tên_sân_bay.ToString();
                };
            }
        }

        private void txtBoxSoChoNgoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void chuyenBayData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                chuyenBayData.CurrentRow.Selected = true;
                txtBoxMaChuyenBay.Text = chuyenBayData.Rows[e.RowIndex].Cells["Mã_chuyến_bay"].FormattedValue.ToString().Trim();
                txtBoxLoaiMayBay.Text = chuyenBayData.Rows[e.RowIndex].Cells["Loại_máy_bay"].FormattedValue.ToString().Trim();
                txtBoxSoChoNgoi.Text = chuyenBayData.Rows[e.RowIndex].Cells["Số_lượng_chỗ_ngồi"].FormattedValue.ToString().Trim();
                dtPickerGioKhoiHanh.Value = DateTime.Parse(chuyenBayData.Rows[e.RowIndex].Cells["Giờ_khởi_hành"].FormattedValue.ToString().Trim());
                dtPickerNgayKhoiHanh.Value = DateTime.Parse(chuyenBayData.Rows[e.RowIndex].Cells["Ngày_khởi_hành"].FormattedValue.ToString().Trim());
                comBoxMaSanBayDi.SelectedIndex = comBoxMaSanBayDi.Items.IndexOf(chuyenBayData.Rows[e.RowIndex].Cells["Mã_sân_bay_đi"].FormattedValue.ToString());
                comBoxMaSanBayDen.SelectedIndex = comBoxMaSanBayDen.Items.IndexOf(chuyenBayData.Rows[e.RowIndex].Cells["Mã_sân_bay_đến"].FormattedValue.ToString());

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
            if(String.IsNullOrEmpty(txtBoxMaChuyenBay.Text) || String.IsNullOrWhiteSpace(txtBoxMaChuyenBay.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(txtBoxLoaiMayBay.Text) || String.IsNullOrWhiteSpace(txtBoxLoaiMayBay.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(txtBoxSoChoNgoi.Text) || String.IsNullOrWhiteSpace(txtBoxSoChoNgoi.Text))
            {
                return false;
            }
            if (comBoxMaSanBayDi.SelectedIndex == -1)
            {
                return false;
            }
            if (comBoxMaSanBayDen.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void InsertData()
        {
            using (var context = new QuanLyVeMayBayEntities())
            {
                var chuyenBay = new Chuyến_bay()
                {
                    Mã_chuyến_bay = txtBoxMaChuyenBay.Text.Trim(),
                    Loại_máy_bay = txtBoxLoaiMayBay.Text.Trim(),
                    Số_lượng_chỗ_ngồi = int.Parse(txtBoxSoChoNgoi.Text.Trim()),
                    Giờ_khởi_hành = dtPickerGioKhoiHanh.Value.TimeOfDay,
                    Ngày_khởi_hành = dtPickerNgayKhoiHanh.Value.Date,
                    Mã_sân_bay_đi = comBoxMaSanBayDi.SelectedItem.ToString(),
                    Mã_sân_bay_đến = comBoxMaSanBayDen.SelectedItem.ToString()
                };
                context.Chuyến_bay.Add(chuyenBay);

                context.SaveChanges();
            };
        }

        private void UpdateData()
        {
            using (var context = new QuanLyVeMayBayEntities())
            {
                var chuyenBay = context.Chuyến_bay
                                        .Where(e => e.Mã_chuyến_bay.Equals(txtBoxMaChuyenBay.Text))
                                        .First();
                if (chuyenBay != null)
                {
                    chuyenBay.Loại_máy_bay = txtBoxLoaiMayBay.Text;
                    chuyenBay.Số_lượng_chỗ_ngồi = int.Parse(txtBoxSoChoNgoi.Text);
                    chuyenBay.Giờ_khởi_hành = dtPickerGioKhoiHanh.Value.TimeOfDay;
                    chuyenBay.Ngày_khởi_hành = dtPickerNgayKhoiHanh.Value.Date;
                    chuyenBay.Mã_sân_bay_đi = comBoxMaSanBayDi.SelectedItem.ToString();
                    chuyenBay.Mã_sân_bay_đến = comBoxMaSanBayDen.SelectedItem.ToString();
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
                if(CheckField())
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
            NhapChuyenBay_Load(sender, e);
            txtBoxLoaiMayBay.Focus();
        }

        private void menuItemSearch_Click(object sender, EventArgs e)
        {
            ShowData(txtBoxMaChuyenBay.Text);
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
                    var chuyenBay = new Chuyến_bay()
                    {
                        Mã_chuyến_bay = txtBoxMaChuyenBay.Text,
                        Loại_máy_bay = txtBoxLoaiMayBay.Text,
                        Số_lượng_chỗ_ngồi = int.Parse(txtBoxSoChoNgoi.Text),
                        Giờ_khởi_hành = dtPickerGioKhoiHanh.Value.TimeOfDay,
                        Ngày_khởi_hành = dtPickerNgayKhoiHanh.Value.Date,
                        Mã_sân_bay_đi = comBoxMaSanBayDi.SelectedItem.ToString(),
                        Mã_sân_bay_đến = comBoxMaSanBayDen.SelectedItem.ToString()
                    };
                    try
                    {
                        context.Chuyến_bay.Attach(chuyenBay);
                        context.Chuyến_bay.Remove(chuyenBay);

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
                NhapChuyenBay_Load(sender, e);
                txtBoxLoaiMayBay.Focus();
            }
        }

        private void menuItemClear_Click(object sender, EventArgs e)
        {
            ClearInput();
            menuItemDelete.Enabled = false;
            toggleAction = true;
            NhapChuyenBay_Load(sender, e);
            txtBoxLoaiMayBay.Focus();
        }
    }
}
