
namespace Quản_lý_Bán_vé_Máy_bay
{
    partial class DE_Loaive_ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DE_Loaive_ReportForm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.loaiveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMã_loại_vé = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTên_loại_vé = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiá_tiền = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMã_dịch_vụ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.dịchvụBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnTaoReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dịchvụBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.loaiveBindingSource;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(6);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(941, 462);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // loaiveBindingSource
            // 
            this.loaiveBindingSource.DataSource = typeof(Quản_lý_Bán_vé_Máy_bay.Loại_vé);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMã_loại_vé,
            this.colTên_loại_vé,
            this.colGiá_tiền,
            this.colMã_dịch_vụ});
            this.gridView1.DetailHeight = 787;
            this.gridView1.FixedLineWidth = 4;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMã_loại_vé
            // 
            this.colMã_loại_vé.AppearanceCell.Options.UseTextOptions = true;
            this.colMã_loại_vé.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMã_loại_vé.AppearanceHeader.Options.UseTextOptions = true;
            this.colMã_loại_vé.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMã_loại_vé.Caption = "MÃ LOẠI VÉ";
            this.colMã_loại_vé.FieldName = "Mã_loại_vé";
            this.colMã_loại_vé.MinWidth = 67;
            this.colMã_loại_vé.Name = "colMã_loại_vé";
            this.colMã_loại_vé.Visible = true;
            this.colMã_loại_vé.VisibleIndex = 0;
            this.colMã_loại_vé.Width = 252;
            // 
            // colTên_loại_vé
            // 
            this.colTên_loại_vé.AppearanceCell.Options.UseTextOptions = true;
            this.colTên_loại_vé.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTên_loại_vé.AppearanceHeader.Options.UseTextOptions = true;
            this.colTên_loại_vé.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTên_loại_vé.Caption = "TÊN LOẠI VÉ";
            this.colTên_loại_vé.FieldName = "Tên_loại_vé";
            this.colTên_loại_vé.MinWidth = 67;
            this.colTên_loại_vé.Name = "colTên_loại_vé";
            this.colTên_loại_vé.Visible = true;
            this.colTên_loại_vé.VisibleIndex = 1;
            this.colTên_loại_vé.Width = 252;
            // 
            // colGiá_tiền
            // 
            this.colGiá_tiền.AppearanceCell.Options.UseTextOptions = true;
            this.colGiá_tiền.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGiá_tiền.AppearanceHeader.Options.UseTextOptions = true;
            this.colGiá_tiền.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGiá_tiền.Caption = "GIÁ TIỀN";
            this.colGiá_tiền.DisplayFormat.FormatString = "{0:###,###,###.000 VNĐ}";
            this.colGiá_tiền.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGiá_tiền.FieldName = "Giá_tiền";
            this.colGiá_tiền.MinWidth = 67;
            this.colGiá_tiền.Name = "colGiá_tiền";
            this.colGiá_tiền.Visible = true;
            this.colGiá_tiền.VisibleIndex = 2;
            this.colGiá_tiền.Width = 252;
            // 
            // colMã_dịch_vụ
            // 
            this.colMã_dịch_vụ.AppearanceCell.Options.UseTextOptions = true;
            this.colMã_dịch_vụ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMã_dịch_vụ.AppearanceHeader.Options.UseTextOptions = true;
            this.colMã_dịch_vụ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMã_dịch_vụ.Caption = "TÊN DỊCH VỤ";
            this.colMã_dịch_vụ.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colMã_dịch_vụ.FieldName = "Mã_dịch_vụ";
            this.colMã_dịch_vụ.MinWidth = 67;
            this.colMã_dịch_vụ.Name = "colMã_dịch_vụ";
            this.colMã_dịch_vụ.Visible = true;
            this.colMã_dịch_vụ.VisibleIndex = 3;
            this.colMã_dịch_vụ.Width = 252;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.dịchvụBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "Tên_dịch_vụ";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.repositoryItemGridLookUpEdit1.ValueMember = "Mã_dịch_vụ";
            // 
            // dịchvụBindingSource
            // 
            this.dịchvụBindingSource.DataSource = typeof(Quản_lý_Bán_vé_Máy_bay.Dịch_vụ);
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
            // btnTaoReport
            // 
            this.btnTaoReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaoReport.BackColor = System.Drawing.SystemColors.Window;
            this.btnTaoReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTaoReport.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnTaoReport.Location = new System.Drawing.Point(277, 486);
            this.btnTaoReport.Name = "btnTaoReport";
            this.btnTaoReport.Size = new System.Drawing.Size(387, 35);
            this.btnTaoReport.TabIndex = 2;
            this.btnTaoReport.Text = "TẠO REPORT";
            this.btnTaoReport.UseVisualStyleBackColor = false;
            this.btnTaoReport.Click += new System.EventHandler(this.btnTaoReport_Click);
            // 
            // DE_Loaive_ReportForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 542);
            this.Controls.Add(this.btnTaoReport);
            this.Controls.Add(this.gridControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("DE_Loaive_ReportForm.IconOptions.Image")));
            this.Name = "DE_Loaive_ReportForm";
            this.Text = "Loại vé Report";
            this.Load += new System.EventHandler(this.DE_Loaive_ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dịchvụBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource loaiveBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMã_loại_vé;
        private DevExpress.XtraGrid.Columns.GridColumn colTên_loại_vé;
        private DevExpress.XtraGrid.Columns.GridColumn colGiá_tiền;
        private DevExpress.XtraGrid.Columns.GridColumn colMã_dịch_vụ;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private System.Windows.Forms.BindingSource dịchvụBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.Button btnTaoReport;
    }
}