using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;

namespace Quản_lý_Bán_vé_Máy_bay
{
    public partial class NhapDichVu : Form
    {
        //QuanLyVeMayBayEntities entities = new QuanLyVeMayBayEntities(); 
        //Toggle Action Insert(true)-Update(false)
        private bool toggleAction = true;
        public NhapDichVu()
        {
            InitializeComponent();
        }

        private void NhapDichVu_Load(object sender, EventArgs e)
        {
            ShowData("");
            txtBoxMaDichVu.Text = IdentificationGeneration();
            btnDelete.Enabled = false;

        }

        private string IdentificationGeneration()
        {
            string id = "DVID";
            int count = dichVuData.Rows.Count;

            using (var context = new QuanLyVeMayBayEntities())
            {
                do
                {
                    count++;
                    id += count.ToString().PadLeft(6, '0');
                } while (context.Dịch_vụ.Any(e => e.Mã_dịch_vụ.Equals(id)));
            }

            return id;
        }


        private void ShowData(string id)
        {
            using (var context = new QuanLyVeMayBayEntities())
            {
                dichVuData.DataSource = context.Dịch_vụ
                                               .OrderBy(e => e.Tên_dịch_vụ)
                                                .ToList();

                dichVuData.Columns["Mã_dịch_vụ"].HeaderText = "Mã dịch vụ";
                dichVuData.Columns["Tên_dịch_vụ"].HeaderText = "Tên dịch vụ";
                dichVuData.Columns["Trị_giá_thức_ăn"].HeaderText = "Trị giá thức ăn";
                dichVuData.Columns["Trị_giá_thức_uống"].HeaderText = "Trị giá thức uống";
                dichVuData.Columns["Trị_giá_dịch_vụ_khác"].HeaderText = "Trị giá dịch vụ khác";

                dichVuData.Columns["Loại_vé"].Visible = false;

                //dichVuData.Sort(dichVuData.Columns["Tên_dịch_vụ"], ListSortDirection.Descending);
            }
        }

        private void ClearInput()
        {
            txtBoxMaDichVu.Clear();
            txtBoxTenDichVu.Clear();
            txtBoxTriGiaThucAn.Clear();
            txtBoxTriGiaThucUong.Clear();
            txtBoxTriGiaDichVuKhac.Clear();
        }

        private void txtBoxTriGiaThucAn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxTriGiaThucUong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxTriGiaDichVuKhac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dichVuData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dichVuData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dichVuData.CurrentRow.Selected = true;
                    txtBoxMaDichVu.Text = dichVuData.Rows[e.RowIndex].Cells["Mã_dịch_vụ"].FormattedValue.ToString();
                    txtBoxTenDichVu.Text = dichVuData.Rows[e.RowIndex].Cells["Tên_dịch_vụ"].FormattedValue.ToString();
                    txtBoxTriGiaThucAn.Text = dichVuData.Rows[e.RowIndex].Cells["Trị_giá_thức_ăn"].FormattedValue.ToString();
                    txtBoxTriGiaThucUong.Text = dichVuData.Rows[e.RowIndex].Cells["Trị_giá_thức_uống"].FormattedValue.ToString();
                    txtBoxTriGiaDichVuKhac.Text = dichVuData.Rows[e.RowIndex].Cells["Trị_giá_dịch_vụ_khác"].FormattedValue.ToString();

                    btnDelete.Enabled = true;
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
            if (String.IsNullOrEmpty(txtBoxMaDichVu.Text) || String.IsNullOrWhiteSpace(txtBoxMaDichVu.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(txtBoxTenDichVu.Text) || String.IsNullOrWhiteSpace(txtBoxTenDichVu.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(txtBoxTriGiaThucAn.Text) || String.IsNullOrWhiteSpace(txtBoxTriGiaThucAn.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(txtBoxTriGiaThucUong.Text) || String.IsNullOrWhiteSpace(txtBoxTriGiaThucUong.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(txtBoxTriGiaDichVuKhac.Text) || String.IsNullOrWhiteSpace(txtBoxTriGiaDichVuKhac.Text))
            {
                return false;
            }
            return true;
        }

        private void InsertData()
        {
            using (var context = new QuanLyVeMayBayEntities())
            {
                var dichVu = new Dịch_vụ()
                {
                    Mã_dịch_vụ = txtBoxMaDichVu.Text,
                    Tên_dịch_vụ = txtBoxTenDichVu.Text,
                    Trị_giá_thức_ăn = int.Parse(txtBoxTriGiaThucAn.Text),
                    Trị_giá_thức_uống = int.Parse(txtBoxTriGiaThucUong.Text),
                    Trị_giá_dịch_vụ_khác = int.Parse(txtBoxTriGiaDichVuKhac.Text),
                };
                context.Dịch_vụ.Add(dichVu);

                context.SaveChanges();
            };

            ShowData("");
            ClearInput();
        }

        private void UpdateData()
        {
            using (var context = new QuanLyVeMayBayEntities())
            {
                var dichVu = context.Dịch_vụ
                                    .Where(e => e.Mã_dịch_vụ.Equals(txtBoxMaDichVu.Text))
                                    .First();
                if (dichVu != null)
                {
                    dichVu.Tên_dịch_vụ = txtBoxTenDichVu.Text;
                    dichVu.Trị_giá_thức_ăn = int.Parse(txtBoxTriGiaThucAn.Text);
                    dichVu.Trị_giá_thức_uống = int.Parse(txtBoxTriGiaThucUong.Text);
                    dichVu.Trị_giá_dịch_vụ_khác = int.Parse(txtBoxTriGiaDichVuKhac.Text);
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
            NhapDichVu_Load(sender, e);
            txtBoxMaDichVu.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialog == DialogResult.OK)
            {
                using (var context = new QuanLyVeMayBayEntities())
                {
                    var dichVu = new Dịch_vụ()
                    {
                        Mã_dịch_vụ = txtBoxMaDichVu.Text,
                        Tên_dịch_vụ = txtBoxTenDichVu.Text,
                        Trị_giá_thức_ăn = int.Parse(txtBoxTriGiaThucAn.Text),
                        Trị_giá_thức_uống = int.Parse(txtBoxTriGiaThucUong.Text),
                        Trị_giá_dịch_vụ_khác = int.Parse(txtBoxTriGiaDichVuKhac.Text),
                    };
                    try
                    {
                        context.Dịch_vụ.Attach(dichVu);
                        context.Dịch_vụ.Remove(dichVu);

                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Data was referenced in another table", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                };

                ShowData("");
                ClearInput();
                btnDelete.Enabled = false;
                NhapDichVu_Load(sender, e);
                txtBoxMaDichVu.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
            btnDelete.Enabled = false;
            toggleAction = true;
            NhapDichVu_Load(sender, e);
            txtBoxMaDichVu.Focus();
        }
    }
}
