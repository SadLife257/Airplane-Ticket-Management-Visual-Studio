
namespace Quản_lý_Bán_vé_Máy_bay
{
    partial class DE_Khach_ReportForm_2
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.veBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.khachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSố_vé = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgày_đặt_vé = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgày_nhận_vé = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMã_chuyến_bay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMã_loại_vé = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.chuyếnbayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnTaoReport = new System.Windows.Forms.Button();
            this.loaiveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sânbayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyếnbayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sânbayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.veBindingSource;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(32);
            this.gridControl1.Location = new System.Drawing.Point(0, -3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(32);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemGridLookUpEdit2});
            this.gridControl1.Size = new System.Drawing.Size(963, 430);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // veBindingSource
            // 
            this.veBindingSource.DataSource = typeof(Quản_lý_Bán_vé_Máy_bay.Vé);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.colSố_vé,
            this.colNgày_đặt_vé,
            this.colNgày_nhận_vé,
            this.colMã_chuyến_bay,
            this.gridColumn1,
            this.colMã_loại_vé});
            this.gridView1.DetailHeight = 3982;
            this.gridView1.FixedLineWidth = 12;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "TÊN KHÁCH HÀNG";
            this.gridColumn2.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.gridColumn2.FieldName = "Mã_khách";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 120;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.khachBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "Tên_khách";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.gridView2;
            this.repositoryItemGridLookUpEdit1.ValueMember = "Mã_khách";
            // 
            // khachBindingSource
            // 
            this.khachBindingSource.DataSource = typeof(Quản_lý_Bán_vé_Máy_bay.Khách);
            // 
            // gridView2
            // 
            this.gridView2.DetailHeight = 1770;
            this.gridView2.FixedLineWidth = 9;
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colSố_vé
            // 
            this.colSố_vé.AppearanceHeader.Options.UseTextOptions = true;
            this.colSố_vé.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSố_vé.Caption = "SỐ VÉ";
            this.colSố_vé.FieldName = "Số_vé";
            this.colSố_vé.MinWidth = 150;
            this.colSố_vé.Name = "colSố_vé";
            this.colSố_vé.Visible = true;
            this.colSố_vé.VisibleIndex = 1;
            this.colSố_vé.Width = 150;
            // 
            // colNgày_đặt_vé
            // 
            this.colNgày_đặt_vé.AppearanceHeader.Options.UseTextOptions = true;
            this.colNgày_đặt_vé.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgày_đặt_vé.Caption = "NGÀY ĐẶT VÉ";
            this.colNgày_đặt_vé.FieldName = "Ngày_đặt_vé";
            this.colNgày_đặt_vé.MinWidth = 150;
            this.colNgày_đặt_vé.Name = "colNgày_đặt_vé";
            this.colNgày_đặt_vé.Visible = true;
            this.colNgày_đặt_vé.VisibleIndex = 2;
            this.colNgày_đặt_vé.Width = 162;
            // 
            // colNgày_nhận_vé
            // 
            this.colNgày_nhận_vé.AppearanceHeader.Options.UseTextOptions = true;
            this.colNgày_nhận_vé.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgày_nhận_vé.Caption = "NGÀY NHẬN VÉ";
            this.colNgày_nhận_vé.FieldName = "Ngày_nhận_vé";
            this.colNgày_nhận_vé.MinWidth = 150;
            this.colNgày_nhận_vé.Name = "colNgày_nhận_vé";
            this.colNgày_nhận_vé.Visible = true;
            this.colNgày_nhận_vé.VisibleIndex = 3;
            this.colNgày_nhận_vé.Width = 162;
            // 
            // colMã_chuyến_bay
            // 
            this.colMã_chuyến_bay.AppearanceHeader.Options.UseTextOptions = true;
            this.colMã_chuyến_bay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMã_chuyến_bay.Caption = "SÂN BAY ĐẾN";
            this.colMã_chuyến_bay.FieldName = "Chuyến_bay.Sân_bay1.Tên_sân_bay";
            this.colMã_chuyến_bay.MinWidth = 150;
            this.colMã_chuyến_bay.Name = "colMã_chuyến_bay";
            this.colMã_chuyến_bay.Visible = true;
            this.colMã_chuyến_bay.VisibleIndex = 5;
            this.colMã_chuyến_bay.Width = 162;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "SÂN BAY ĐI";
            this.gridColumn1.FieldName = "Chuyến_bay.Sân_bay.Tên_sân_bay";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 121;
            // 
            // colMã_loại_vé
            // 
            this.colMã_loại_vé.AppearanceHeader.Options.UseTextOptions = true;
            this.colMã_loại_vé.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMã_loại_vé.Caption = "TÊN LOẠI VÉ";
            this.colMã_loại_vé.FieldName = "Loại_vé.Tên_loại_vé";
            this.colMã_loại_vé.MinWidth = 150;
            this.colMã_loại_vé.Name = "colMã_loại_vé";
            this.colMã_loại_vé.Visible = true;
            this.colMã_loại_vé.VisibleIndex = 6;
            this.colMã_loại_vé.Width = 168;
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.DataSource = this.chuyếnbayBindingSource;
            this.repositoryItemGridLookUpEdit2.DisplayMember = "Mã_sân_bay_đi";
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.PopupView = this.repositoryItemGridLookUpEdit2View;
            this.repositoryItemGridLookUpEdit2.ValueMember = "Mã_chuyến_bay";
            // 
            // chuyếnbayBindingSource
            // 
            this.chuyếnbayBindingSource.DataSource = typeof(Quản_lý_Bán_vé_Máy_bay.Chuyến_bay);
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // btnTaoReport
            // 
            this.btnTaoReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaoReport.BackColor = System.Drawing.SystemColors.Window;
            this.btnTaoReport.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnTaoReport.Location = new System.Drawing.Point(267, 452);
            this.btnTaoReport.Name = "btnTaoReport";
            this.btnTaoReport.Size = new System.Drawing.Size(387, 35);
            this.btnTaoReport.TabIndex = 4;
            this.btnTaoReport.Text = "TẠO REPORT";
            this.btnTaoReport.UseVisualStyleBackColor = false;
            this.btnTaoReport.Click += new System.EventHandler(this.btnTaoReport_Click);
            // 
            // loaiveBindingSource
            // 
            this.loaiveBindingSource.DataSource = typeof(Quản_lý_Bán_vé_Máy_bay.Loại_vé);
            // 
            // sânbayBindingSource
            // 
            this.sânbayBindingSource.DataSource = typeof(Quản_lý_Bán_vé_Máy_bay.Sân_bay);
            // 
            // DE_Khach_ReportForm_2
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 513);
            this.Controls.Add(this.btnTaoReport);
            this.Controls.Add(this.gridControl1);
            this.Name = "DE_Khach_ReportForm_2";
            this.Text = "DE_Khach_ReportForm_2";
            this.Load += new System.EventHandler(this.DE_Khach_ReportForm_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyếnbayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sânbayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSố_vé;
        private DevExpress.XtraGrid.Columns.GridColumn colNgày_đặt_vé;
        private DevExpress.XtraGrid.Columns.GridColumn colNgày_nhận_vé;
        private DevExpress.XtraGrid.Columns.GridColumn colMã_chuyến_bay;
        private DevExpress.XtraGrid.Columns.GridColumn colMã_loại_vé;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource khachBindingSource;
        private System.Windows.Forms.BindingSource veBindingSource;
        private System.Windows.Forms.Button btnTaoReport;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.BindingSource chuyếnbayBindingSource;
        private System.Windows.Forms.BindingSource loaiveBindingSource;
        private System.Windows.Forms.BindingSource sânbayBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}