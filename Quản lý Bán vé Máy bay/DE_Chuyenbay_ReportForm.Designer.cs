
namespace Quản_lý_Bán_vé_Máy_bay
{
    partial class DE_Chuyenbay_ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DE_Chuyenbay_ReportForm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.chuyếnbayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMã_chuyến_bay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoại_máy_bay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSố_lượng_chổ_ngồi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiờ_khởi_hành = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgày_khởi_hành = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Mã_sân_bay_đi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.sânbayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Mã_sân_bay_dến = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnTaoReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyếnbayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sânbayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.chuyếnbayBindingSource;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(243);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(243);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(943, 451);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // chuyếnbayBindingSource
            // 
            this.chuyếnbayBindingSource.DataSource = typeof(Quản_lý_Bán_vé_Máy_bay.Chuyến_bay);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMã_chuyến_bay,
            this.colLoại_máy_bay,
            this.colSố_lượng_chổ_ngồi,
            this.colGiờ_khởi_hành,
            this.colNgày_khởi_hành,
            this.Mã_sân_bay_đi,
            this.Mã_sân_bay_dến});
            this.gridView1.DetailHeight = 30235;
            this.gridView1.FixedLineWidth = 12;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMã_chuyến_bay
            // 
            this.colMã_chuyến_bay.AppearanceCell.Options.UseTextOptions = true;
            this.colMã_chuyến_bay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMã_chuyến_bay.AppearanceHeader.Options.UseTextOptions = true;
            this.colMã_chuyến_bay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMã_chuyến_bay.Caption = "MÃ CHUYẾN BAY";
            this.colMã_chuyến_bay.FieldName = "Mã_chuyến_bay";
            this.colMã_chuyến_bay.MinWidth = 200;
            this.colMã_chuyến_bay.Name = "colMã_chuyến_bay";
            this.colMã_chuyến_bay.Visible = true;
            this.colMã_chuyến_bay.VisibleIndex = 0;
            this.colMã_chuyến_bay.Width = 200;
            // 
            // colLoại_máy_bay
            // 
            this.colLoại_máy_bay.AppearanceCell.Options.UseTextOptions = true;
            this.colLoại_máy_bay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoại_máy_bay.AppearanceHeader.Options.UseTextOptions = true;
            this.colLoại_máy_bay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoại_máy_bay.Caption = "LOẠI MÁY BAY";
            this.colLoại_máy_bay.FieldName = "Loại_máy_bay";
            this.colLoại_máy_bay.MinWidth = 200;
            this.colLoại_máy_bay.Name = "colLoại_máy_bay";
            this.colLoại_máy_bay.Visible = true;
            this.colLoại_máy_bay.VisibleIndex = 1;
            this.colLoại_máy_bay.Width = 200;
            // 
            // colSố_lượng_chổ_ngồi
            // 
            this.colSố_lượng_chổ_ngồi.AppearanceCell.Options.UseTextOptions = true;
            this.colSố_lượng_chổ_ngồi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSố_lượng_chổ_ngồi.AppearanceHeader.Options.UseTextOptions = true;
            this.colSố_lượng_chổ_ngồi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSố_lượng_chổ_ngồi.Caption = "SỐ LƯỢNG CHỖ NGỒI";
            this.colSố_lượng_chổ_ngồi.FieldName = "Số_lượng_chỗ_ngồi";
            this.colSố_lượng_chổ_ngồi.MinWidth = 200;
            this.colSố_lượng_chổ_ngồi.Name = "colSố_lượng_chổ_ngồi";
            this.colSố_lượng_chổ_ngồi.Visible = true;
            this.colSố_lượng_chổ_ngồi.VisibleIndex = 2;
            this.colSố_lượng_chổ_ngồi.Width = 200;
            // 
            // colGiờ_khởi_hành
            // 
            this.colGiờ_khởi_hành.AppearanceCell.Options.UseTextOptions = true;
            this.colGiờ_khởi_hành.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGiờ_khởi_hành.AppearanceHeader.Options.UseTextOptions = true;
            this.colGiờ_khởi_hành.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGiờ_khởi_hành.Caption = "GIỜ KHỞI HÀNH";
            this.colGiờ_khởi_hành.FieldName = "Giờ_khởi_hành";
            this.colGiờ_khởi_hành.MinWidth = 200;
            this.colGiờ_khởi_hành.Name = "colGiờ_khởi_hành";
            this.colGiờ_khởi_hành.Visible = true;
            this.colGiờ_khởi_hành.VisibleIndex = 3;
            this.colGiờ_khởi_hành.Width = 200;
            // 
            // colNgày_khởi_hành
            // 
            this.colNgày_khởi_hành.AppearanceCell.Options.UseTextOptions = true;
            this.colNgày_khởi_hành.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgày_khởi_hành.AppearanceHeader.Options.UseTextOptions = true;
            this.colNgày_khởi_hành.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgày_khởi_hành.Caption = "NGÀY KHỞI HÀNH";
            this.colNgày_khởi_hành.FieldName = "Ngày_khởi_hành";
            this.colNgày_khởi_hành.MinWidth = 200;
            this.colNgày_khởi_hành.Name = "colNgày_khởi_hành";
            this.colNgày_khởi_hành.Visible = true;
            this.colNgày_khởi_hành.VisibleIndex = 4;
            this.colNgày_khởi_hành.Width = 200;
            // 
            // Mã_sân_bay_đi
            // 
            this.Mã_sân_bay_đi.AppearanceCell.Options.UseTextOptions = true;
            this.Mã_sân_bay_đi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Mã_sân_bay_đi.AppearanceHeader.Options.UseTextOptions = true;
            this.Mã_sân_bay_đi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Mã_sân_bay_đi.Caption = "SÂN BAY ĐI";
            this.Mã_sân_bay_đi.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.Mã_sân_bay_đi.FieldName = "Mã_sân_bay_đi";
            this.Mã_sân_bay_đi.MinWidth = 200;
            this.Mã_sân_bay_đi.Name = "Mã_sân_bay_đi";
            this.Mã_sân_bay_đi.Visible = true;
            this.Mã_sân_bay_đi.VisibleIndex = 5;
            this.Mã_sân_bay_đi.Width = 200;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.sânbayBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "Tên_sân_bay";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.repositoryItemGridLookUpEdit1.ValueMember = "Mã_sân_bay";
            // 
            // sânbayBindingSource
            // 
            this.sânbayBindingSource.DataSource = typeof(Quản_lý_Bán_vé_Máy_bay.Sân_bay);
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.DetailHeight = 30235;
            this.repositoryItemGridLookUpEdit1View.FixedLineWidth = 12;
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Mã_sân_bay_dến
            // 
            this.Mã_sân_bay_dến.AppearanceCell.Options.UseTextOptions = true;
            this.Mã_sân_bay_dến.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Mã_sân_bay_dến.AppearanceHeader.Options.UseTextOptions = true;
            this.Mã_sân_bay_dến.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Mã_sân_bay_dến.Caption = "SÂN BAY ĐẾN";
            this.Mã_sân_bay_dến.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.Mã_sân_bay_dến.FieldName = "Mã_sân_bay_đến";
            this.Mã_sân_bay_dến.MinWidth = 200;
            this.Mã_sân_bay_dến.Name = "Mã_sân_bay_dến";
            this.Mã_sân_bay_dến.Visible = true;
            this.Mã_sân_bay_dến.VisibleIndex = 6;
            this.Mã_sân_bay_dến.Width = 200;
            // 
            // btnTaoReport
            // 
            this.btnTaoReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaoReport.Location = new System.Drawing.Point(831, 475);
            this.btnTaoReport.Name = "btnTaoReport";
            this.btnTaoReport.Size = new System.Drawing.Size(100, 30);
            this.btnTaoReport.TabIndex = 1;
            this.btnTaoReport.Text = "Tạo Report";
            this.btnTaoReport.UseVisualStyleBackColor = true;
            this.btnTaoReport.Click += new System.EventHandler(this.btnTaoReport_Click);
            // 
            // DE_Chuyenbay_ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 517);
            this.Controls.Add(this.btnTaoReport);
            this.Controls.Add(this.gridControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("DE_Chuyenbay_ReportForm.IconOptions.Image")));
            this.Name = "DE_Chuyenbay_ReportForm";
            this.Text = "Chuyến bay Report";
            this.Load += new System.EventHandler(this.DE_ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyếnbayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sânbayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMã_chuyến_bay;
        private DevExpress.XtraGrid.Columns.GridColumn colLoại_máy_bay;
        private DevExpress.XtraGrid.Columns.GridColumn colSố_lượng_chổ_ngồi;
        private DevExpress.XtraGrid.Columns.GridColumn colGiờ_khởi_hành;
        private DevExpress.XtraGrid.Columns.GridColumn colNgày_khởi_hành;
        private DevExpress.XtraGrid.Columns.GridColumn Mã_sân_bay_đi;
        private DevExpress.XtraGrid.Columns.GridColumn Mã_sân_bay_dến;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.Button btnTaoReport;
        private System.Windows.Forms.BindingSource chuyếnbayBindingSource;
        private System.Windows.Forms.BindingSource sânbayBindingSource;
    }
}