
namespace Quản_lý_Bán_vé_Máy_bay
{
    partial class DE_Khach_ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DE_Khach_ReportForm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.veBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSố_vé = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgày_đặt_vé = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgày_nhận_vé = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMã_chuyến_bay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMã_loại_vé = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMã_khách = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.khachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.veBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(940, 539);
            this.gridControl1.TabIndex = 0;
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
            this.colSố_vé,
            this.colNgày_đặt_vé,
            this.colNgày_nhận_vé,
            this.colMã_chuyến_bay,
            this.colMã_loại_vé,
            this.colMã_khách});
            this.gridView1.DetailHeight = 1770;
            this.gridView1.FixedLineWidth = 9;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colSố_vé
            // 
            this.colSố_vé.FieldName = "Số_vé";
            this.colSố_vé.MinWidth = 67;
            this.colSố_vé.Name = "colSố_vé";
            this.colSố_vé.Visible = true;
            this.colSố_vé.VisibleIndex = 1;
            this.colSố_vé.Width = 252;
            // 
            // colNgày_đặt_vé
            // 
            this.colNgày_đặt_vé.FieldName = "Ngày_đặt_vé";
            this.colNgày_đặt_vé.MinWidth = 67;
            this.colNgày_đặt_vé.Name = "colNgày_đặt_vé";
            this.colNgày_đặt_vé.Visible = true;
            this.colNgày_đặt_vé.VisibleIndex = 2;
            this.colNgày_đặt_vé.Width = 252;
            // 
            // colNgày_nhận_vé
            // 
            this.colNgày_nhận_vé.FieldName = "Ngày_nhận_vé";
            this.colNgày_nhận_vé.MinWidth = 67;
            this.colNgày_nhận_vé.Name = "colNgày_nhận_vé";
            this.colNgày_nhận_vé.Visible = true;
            this.colNgày_nhận_vé.VisibleIndex = 3;
            this.colNgày_nhận_vé.Width = 252;
            // 
            // colMã_chuyến_bay
            // 
            this.colMã_chuyến_bay.FieldName = "Mã_chuyến_bay";
            this.colMã_chuyến_bay.MinWidth = 67;
            this.colMã_chuyến_bay.Name = "colMã_chuyến_bay";
            this.colMã_chuyến_bay.Visible = true;
            this.colMã_chuyến_bay.VisibleIndex = 4;
            this.colMã_chuyến_bay.Width = 252;
            // 
            // colMã_loại_vé
            // 
            this.colMã_loại_vé.FieldName = "Mã_loại_vé";
            this.colMã_loại_vé.MinWidth = 67;
            this.colMã_loại_vé.Name = "colMã_loại_vé";
            this.colMã_loại_vé.Visible = true;
            this.colMã_loại_vé.VisibleIndex = 5;
            this.colMã_loại_vé.Width = 252;
            // 
            // colMã_khách
            // 
            this.colMã_khách.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colMã_khách.FieldName = "Mã_khách";
            this.colMã_khách.MinWidth = 67;
            this.colMã_khách.Name = "colMã_khách";
            this.colMã_khách.Visible = true;
            this.colMã_khách.VisibleIndex = 0;
            this.colMã_khách.Width = 252;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.khachBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "Tên_khách";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.repositoryItemGridLookUpEdit1.ValueMember = "Mã_khách";
            // 
            // khachBindingSource
            // 
            this.khachBindingSource.DataSource = typeof(Quản_lý_Bán_vé_Máy_bay.Khách);
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.DetailHeight = 787;
            this.repositoryItemGridLookUpEdit1View.FixedLineWidth = 4;
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // DE_Khach_ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 539);
            this.Controls.Add(this.gridControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("DE_Khach_ReportForm.IconOptions.Image")));
            this.Name = "DE_Khach_ReportForm";
            this.Text = "Khách Report";
            this.Load += new System.EventHandler(this.DE_Khach_ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource veBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSố_vé;
        private DevExpress.XtraGrid.Columns.GridColumn colNgày_đặt_vé;
        private DevExpress.XtraGrid.Columns.GridColumn colNgày_nhận_vé;
        private DevExpress.XtraGrid.Columns.GridColumn colMã_chuyến_bay;
        private DevExpress.XtraGrid.Columns.GridColumn colMã_loại_vé;
        private DevExpress.XtraGrid.Columns.GridColumn colMã_khách;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private System.Windows.Forms.BindingSource khachBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
    }
}