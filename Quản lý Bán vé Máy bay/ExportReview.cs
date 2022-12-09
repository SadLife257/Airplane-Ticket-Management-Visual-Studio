using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace Quản_lý_Bán_vé_Máy_bay
{
    public partial class ExportReview : Form
    {
        public static ExportReview formInstance;
        public DataGridView gridView;

        public ExportReview()
        {
            InitializeComponent();
            formInstance = this;
            gridView = reviewData;
        }

        private void ExportExcel(String path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            //Table Header
            int rowCount = reviewData.Rows.Count;
            int columnCount = reviewData.Columns.Count;
            for (int i = 0; i < columnCount; i++)
            {
                if(reviewData.Columns[i].Visible)
                {
                    application.Cells[1, i + 1] = reviewData.Columns[i].HeaderText;
                }
                else
                {
                    i--;
                    columnCount--;
                }
            }
            //Table Body
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (reviewData.Columns[i].Visible)
                    {
                        application.Cells[i + 2, j + 1] = reviewData.Rows[i].Cells[j].Value;
                    }
                    else
                    {
                        j--;
                    }
                    
                }
            }

            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Export to Excel file";
            dialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(dialog.FileName);
                    MessageBox.Show("Export Complete");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Export Failed\n" + ex.Message);
                }
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
