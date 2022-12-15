
namespace Quản_lý_Bán_vé_Máy_bay
{
    partial class NhapKhach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapKhach));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.khachID = new System.Windows.Forms.TextBox();
            this.khachName = new System.Windows.Forms.TextBox();
            this.khachCMND = new System.Windows.Forms.TextBox();
            this.khachPhone = new System.Windows.Forms.TextBox();
            this.khachData = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.khachData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Name = "label4";
            // 
            // khachID
            // 
            this.khachID.BackColor = System.Drawing.SystemColors.Window;
            this.khachID.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.khachID, "khachID");
            this.khachID.Name = "khachID";
            this.khachID.ReadOnly = true;
            this.khachID.TabStop = false;
            // 
            // khachName
            // 
            this.khachName.BackColor = System.Drawing.SystemColors.Window;
            this.khachName.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.khachName, "khachName");
            this.khachName.Name = "khachName";
            // 
            // khachCMND
            // 
            this.khachCMND.BackColor = System.Drawing.SystemColors.Window;
            this.khachCMND.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.khachCMND, "khachCMND");
            this.khachCMND.Name = "khachCMND";
            // 
            // khachPhone
            // 
            this.khachPhone.BackColor = System.Drawing.SystemColors.Window;
            this.khachPhone.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.khachPhone, "khachPhone");
            this.khachPhone.Name = "khachPhone";
            // 
            // khachData
            // 
            resources.ApplyResources(this.khachData, "khachData");
            this.khachData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.khachData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.khachData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.khachData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.khachData.Name = "khachData";
            this.khachData.ReadOnly = true;
            this.khachData.RowTemplate.Height = 33;
            this.khachData.TabStop = false;
            this.khachData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.khachData_CellClick);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.BackColor = System.Drawing.SystemColors.Window;
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.BackColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.SystemColors.Window;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NhapKhach
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.khachData);
            this.Controls.Add(this.khachPhone);
            this.Controls.Add(this.khachCMND);
            this.Controls.Add(this.khachName);
            this.Controls.Add(this.khachID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "NhapKhach";
            this.Load += new System.EventHandler(this.NhapKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khachData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox khachID;
        private System.Windows.Forms.TextBox khachName;
        private System.Windows.Forms.TextBox khachCMND;
        private System.Windows.Forms.TextBox khachPhone;
        private System.Windows.Forms.DataGridView khackData;
        private System.Windows.Forms.DataGridView khachData;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
    }
}