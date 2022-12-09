
namespace Quản_lý_Bán_vé_Máy_bay
{
    partial class NhapDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapDichVu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxMaDichVu = new System.Windows.Forms.TextBox();
            this.txtBoxTenDichVu = new System.Windows.Forms.TextBox();
            this.txtBoxTriGiaThucAn = new System.Windows.Forms.TextBox();
            this.txtBoxTriGiaThucUong = new System.Windows.Forms.TextBox();
            this.txtBoxTriGiaDichVuKhac = new System.Windows.Forms.TextBox();
            this.dichVuData = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClear = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã dịch vụ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên dịch vụ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(18, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trị giá thức ăn (Nghìn đồng)";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(18, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trị giá thức uống (Nghìn đồng)";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(18, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Trị giá dịch vụ khác (Nghìn đồng)";
            // 
            // txtBoxMaDichVu
            // 
            this.txtBoxMaDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxMaDichVu.BackColor = System.Drawing.Color.Black;
            this.txtBoxMaDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMaDichVu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxMaDichVu.Location = new System.Drawing.Point(313, 72);
            this.txtBoxMaDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxMaDichVu.Name = "txtBoxMaDichVu";
            this.txtBoxMaDichVu.ReadOnly = true;
            this.txtBoxMaDichVu.Size = new System.Drawing.Size(200, 19);
            this.txtBoxMaDichVu.TabIndex = 1;
            this.txtBoxMaDichVu.TabStop = false;
            // 
            // txtBoxTenDichVu
            // 
            this.txtBoxTenDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxTenDichVu.BackColor = System.Drawing.Color.Black;
            this.txtBoxTenDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTenDichVu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxTenDichVu.Location = new System.Drawing.Point(313, 140);
            this.txtBoxTenDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxTenDichVu.Name = "txtBoxTenDichVu";
            this.txtBoxTenDichVu.Size = new System.Drawing.Size(200, 19);
            this.txtBoxTenDichVu.TabIndex = 2;
            // 
            // txtBoxTriGiaThucAn
            // 
            this.txtBoxTriGiaThucAn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxTriGiaThucAn.BackColor = System.Drawing.Color.Black;
            this.txtBoxTriGiaThucAn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTriGiaThucAn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxTriGiaThucAn.Location = new System.Drawing.Point(313, 214);
            this.txtBoxTriGiaThucAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxTriGiaThucAn.Name = "txtBoxTriGiaThucAn";
            this.txtBoxTriGiaThucAn.Size = new System.Drawing.Size(200, 19);
            this.txtBoxTriGiaThucAn.TabIndex = 3;
            this.txtBoxTriGiaThucAn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTriGiaThucAn_KeyPress);
            // 
            // txtBoxTriGiaThucUong
            // 
            this.txtBoxTriGiaThucUong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxTriGiaThucUong.BackColor = System.Drawing.Color.Black;
            this.txtBoxTriGiaThucUong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTriGiaThucUong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxTriGiaThucUong.Location = new System.Drawing.Point(313, 286);
            this.txtBoxTriGiaThucUong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxTriGiaThucUong.Name = "txtBoxTriGiaThucUong";
            this.txtBoxTriGiaThucUong.Size = new System.Drawing.Size(200, 19);
            this.txtBoxTriGiaThucUong.TabIndex = 4;
            this.txtBoxTriGiaThucUong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTriGiaThucUong_KeyPress);
            // 
            // txtBoxTriGiaDichVuKhac
            // 
            this.txtBoxTriGiaDichVuKhac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxTriGiaDichVuKhac.BackColor = System.Drawing.Color.Black;
            this.txtBoxTriGiaDichVuKhac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTriGiaDichVuKhac.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxTriGiaDichVuKhac.Location = new System.Drawing.Point(313, 354);
            this.txtBoxTriGiaDichVuKhac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxTriGiaDichVuKhac.Name = "txtBoxTriGiaDichVuKhac";
            this.txtBoxTriGiaDichVuKhac.Size = new System.Drawing.Size(200, 19);
            this.txtBoxTriGiaDichVuKhac.TabIndex = 5;
            this.txtBoxTriGiaDichVuKhac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTriGiaDichVuKhac_KeyPress);
            // 
            // dichVuData
            // 
            this.dichVuData.BackgroundColor = System.Drawing.Color.Black;
            this.dichVuData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dichVuData.Dock = System.Windows.Forms.DockStyle.Right;
            this.dichVuData.Location = new System.Drawing.Point(532, 33);
            this.dichVuData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dichVuData.Name = "dichVuData";
            this.dichVuData.ReadOnly = true;
            this.dichVuData.RowHeadersWidth = 62;
            this.dichVuData.RowTemplate.Height = 33;
            this.dichVuData.Size = new System.Drawing.Size(691, 471);
            this.dichVuData.TabIndex = 6;
            this.dichVuData.TabStop = false;
            this.dichVuData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dichVuData_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSave,
            this.menuItemDelete,
            this.menuItemClear});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1223, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemSave
            // 
            this.menuItemSave.Image = ((System.Drawing.Image)(resources.GetObject("menuItemSave.Image")));
            this.menuItemSave.Name = "menuItemSave";
            this.menuItemSave.Size = new System.Drawing.Size(89, 29);
            this.menuItemSave.Text = "Save";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("menuItemDelete.Image")));
            this.menuItemDelete.Name = "menuItemDelete";
            this.menuItemDelete.Size = new System.Drawing.Size(102, 29);
            this.menuItemDelete.Text = "Delete";
            this.menuItemDelete.Click += new System.EventHandler(this.menuItemDelete_Click);
            // 
            // menuItemClear
            // 
            this.menuItemClear.Image = ((System.Drawing.Image)(resources.GetObject("menuItemClear.Image")));
            this.menuItemClear.Name = "menuItemClear";
            this.menuItemClear.Size = new System.Drawing.Size(91, 29);
            this.menuItemClear.Text = "Clear";
            this.menuItemClear.Click += new System.EventHandler(this.menuItemClear_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(172)))), ((int)(((byte)(226)))));
            this.panel2.Location = new System.Drawing.Point(313, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(172)))), ((int)(((byte)(226)))));
            this.panel1.Location = new System.Drawing.Point(313, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(172)))), ((int)(((byte)(226)))));
            this.panel3.Location = new System.Drawing.Point(313, 239);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(172)))), ((int)(((byte)(226)))));
            this.panel4.Location = new System.Drawing.Point(313, 311);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 1);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(172)))), ((int)(((byte)(226)))));
            this.panel5.Location = new System.Drawing.Point(313, 379);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 1);
            this.panel5.TabIndex = 7;
            // 
            // NhapDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1223, 504);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dichVuData);
            this.Controls.Add(this.txtBoxTriGiaDichVuKhac);
            this.Controls.Add(this.txtBoxTriGiaThucUong);
            this.Controls.Add(this.txtBoxTriGiaThucAn);
            this.Controls.Add(this.txtBoxTenDichVu);
            this.Controls.Add(this.txtBoxMaDichVu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NhapDichVu";
            this.Text = "Nhập Dịch Vụ";
            this.Load += new System.EventHandler(this.NhapDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dichVuData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxMaDichVu;
        private System.Windows.Forms.TextBox txtBoxTenDichVu;
        private System.Windows.Forms.TextBox txtBoxTriGiaThucAn;
        private System.Windows.Forms.TextBox txtBoxTriGiaThucUong;
        private System.Windows.Forms.TextBox txtBoxTriGiaDichVuKhac;
        private System.Windows.Forms.DataGridView dichVuData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemClear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}