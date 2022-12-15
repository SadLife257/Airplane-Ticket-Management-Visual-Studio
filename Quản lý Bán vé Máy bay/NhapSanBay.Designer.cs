
namespace Quản_lý_Bán_vé_Máy_bay
{
    partial class NhapSanBay
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxMaSanBay = new System.Windows.Forms.TextBox();
            this.txtBoxTenSanBay = new System.Windows.Forms.TextBox();
            this.sanBayData = new System.Windows.Forms.DataGridView();
            this.comBoxTinhThanhPho = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sanBayData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sân bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(33, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sân bay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(33, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tỉnh/Thành phố";
            // 
            // txtBoxMaSanBay
            // 
            this.txtBoxMaSanBay.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxMaSanBay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxMaSanBay.Location = new System.Drawing.Point(133, 26);
            this.txtBoxMaSanBay.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtBoxMaSanBay.Name = "txtBoxMaSanBay";
            this.txtBoxMaSanBay.ReadOnly = true;
            this.txtBoxMaSanBay.Size = new System.Drawing.Size(133, 20);
            this.txtBoxMaSanBay.TabIndex = 1;
            this.txtBoxMaSanBay.TabStop = false;
            // 
            // txtBoxTenSanBay
            // 
            this.txtBoxTenSanBay.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxTenSanBay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxTenSanBay.Location = new System.Drawing.Point(133, 103);
            this.txtBoxTenSanBay.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtBoxTenSanBay.Name = "txtBoxTenSanBay";
            this.txtBoxTenSanBay.Size = new System.Drawing.Size(133, 20);
            this.txtBoxTenSanBay.TabIndex = 2;
            // 
            // sanBayData
            // 
            this.sanBayData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sanBayData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sanBayData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.sanBayData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sanBayData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sanBayData.GridColor = System.Drawing.Color.Black;
            this.sanBayData.Location = new System.Drawing.Point(326, 0);
            this.sanBayData.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.sanBayData.Name = "sanBayData";
            this.sanBayData.ReadOnly = true;
            this.sanBayData.RowHeadersWidth = 62;
            this.sanBayData.RowTemplate.Height = 33;
            this.sanBayData.Size = new System.Drawing.Size(223, 326);
            this.sanBayData.TabIndex = 4;
            this.sanBayData.TabStop = false;
            this.sanBayData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sanBayData_CellClick);
            // 
            // comBoxTinhThanhPho
            // 
            this.comBoxTinhThanhPho.BackColor = System.Drawing.SystemColors.Window;
            this.comBoxTinhThanhPho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comBoxTinhThanhPho.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comBoxTinhThanhPho.FormattingEnabled = true;
            this.comBoxTinhThanhPho.Location = new System.Drawing.Point(133, 181);
            this.comBoxTinhThanhPho.Margin = new System.Windows.Forms.Padding(2);
            this.comBoxTinhThanhPho.Name = "comBoxTinhThanhPho";
            this.comBoxTinhThanhPho.Size = new System.Drawing.Size(135, 21);
            this.comBoxTinhThanhPho.TabIndex = 3;
            this.comBoxTinhThanhPho.Text = "-Tỉnh/Thành phố-";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.BackColor = System.Drawing.SystemColors.Window;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(36, 292);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(230, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(193, 249);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BackColor = System.Drawing.SystemColors.Window;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(36, 249);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NhapSanBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(549, 326);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comBoxTinhThanhPho);
            this.Controls.Add(this.sanBayData);
            this.Controls.Add(this.txtBoxTenSanBay);
            this.Controls.Add(this.txtBoxMaSanBay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "NhapSanBay";
            this.Text = "Sân Bay";
            this.Load += new System.EventHandler(this.NhapSanBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sanBayData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxMaSanBay;
        private System.Windows.Forms.TextBox txtBoxTenSanBay;
        private System.Windows.Forms.DataGridView sanBayData;
        private System.Windows.Forms.ComboBox comBoxTinhThanhPho;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
    }
}