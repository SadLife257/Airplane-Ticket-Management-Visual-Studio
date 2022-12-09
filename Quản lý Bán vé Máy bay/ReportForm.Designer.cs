
namespace Quản_lý_Bán_vé_Máy_bay
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.SBCBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyVeMayBayDataSet = new Quản_lý_Bán_vé_Máy_bay.QuanLyVeMayBayDataSet();
            this.DVLVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SBCBAdapter = new Quản_lý_Bán_vé_Máy_bay.QuanLyVeMayBayDataSetTableAdapters.SBCBAdapter();
            this.DVLVAdapter = new Quản_lý_Bán_vé_Máy_bay.QuanLyVeMayBayDataSetTableAdapters.DVLVAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SBCBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyVeMayBayDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVLVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SBCBBindingSource
            // 
            this.SBCBBindingSource.DataMember = "SBCB";
            this.SBCBBindingSource.DataSource = this.QuanLyVeMayBayDataSet;
            // 
            // QuanLyVeMayBayDataSet
            // 
            this.QuanLyVeMayBayDataSet.DataSetName = "QuanLyVeMayBayDataSet";
            this.QuanLyVeMayBayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DVLVBindingSource
            // 
            this.DVLVBindingSource.DataMember = "DVLV";
            this.DVLVBindingSource.DataSource = this.QuanLyVeMayBayDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SBCB";
            reportDataSource1.Value = this.SBCBBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // SBCBAdapter
            // 
            this.SBCBAdapter.ClearBeforeFill = true;
            // 
            // DVLVAdapter
            // 
            this.DVLVAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.Text = "Phiếu báo cáo chuyến bay";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SBCBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyVeMayBayDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVLVBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QuanLyVeMayBayDataSet QuanLyVeMayBayDataSet;
        private System.Windows.Forms.BindingSource SBCBBindingSource;
        private QuanLyVeMayBayDataSetTableAdapters.SBCBAdapter SBCBAdapter;
        private System.Windows.Forms.BindingSource DVLVBindingSource;
        private QuanLyVeMayBayDataSetTableAdapters.DVLVAdapter DVLVAdapter;
    }
}