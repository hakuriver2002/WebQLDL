namespace WebQLDL
{
    partial class frm_ChuyenDuLich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ChuyenDuLich));
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.cbxPhuongTien = new System.Windows.Forms.ComboBox();
            this.cbxMaTuyen = new System.Windows.Forms.ComboBox();
            this.txtHuongDanVien = new System.Windows.Forms.TextBox();
            this.txtMaChuyen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb3 = new System.Windows.Forms.GroupBox();
            this.datagridDuLich = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.gb2.SuspendLayout();
            this.gb3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDuLich)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Location = new System.Drawing.Point(159, 66);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(200, 100);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.txtDonGia);
            this.gb2.Controls.Add(this.cbxPhuongTien);
            this.gb2.Controls.Add(this.cbxMaTuyen);
            this.gb2.Controls.Add(this.txtHuongDanVien);
            this.gb2.Controls.Add(this.txtMaChuyen);
            this.gb2.Controls.Add(this.label6);
            this.gb2.Controls.Add(this.label5);
            this.gb2.Controls.Add(this.label4);
            this.gb2.Controls.Add(this.label3);
            this.gb2.Controls.Add(this.label2);
            this.gb2.Controls.Add(this.label1);
            this.gb2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb2.Location = new System.Drawing.Point(0, 0);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(839, 515);
            this.gb2.TabIndex = 1;
            this.gb2.TabStop = false;
            this.gb2.Text = "Nhập thông tin";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(448, 144);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(167, 22);
            this.txtDonGia.TabIndex = 10;
            // 
            // cbxPhuongTien
            // 
            this.cbxPhuongTien.FormattingEnabled = true;
            this.cbxPhuongTien.Items.AddRange(new object[] {
            "Xe máy",
            "Xe khách",
            "Máy bay",
            "Tàu lửa"});
            this.cbxPhuongTien.Location = new System.Drawing.Point(108, 188);
            this.cbxPhuongTien.Name = "cbxPhuongTien";
            this.cbxPhuongTien.Size = new System.Drawing.Size(136, 24);
            this.cbxPhuongTien.TabIndex = 9;
            // 
            // cbxMaTuyen
            // 
            this.cbxMaTuyen.FormattingEnabled = true;
            this.cbxMaTuyen.Location = new System.Drawing.Point(108, 136);
            this.cbxMaTuyen.Name = "cbxMaTuyen";
            this.cbxMaTuyen.Size = new System.Drawing.Size(136, 24);
            this.cbxMaTuyen.TabIndex = 8;
            // 
            // txtHuongDanVien
            // 
            this.txtHuongDanVien.Location = new System.Drawing.Point(448, 85);
            this.txtHuongDanVien.Name = "txtHuongDanVien";
            this.txtHuongDanVien.Size = new System.Drawing.Size(167, 22);
            this.txtHuongDanVien.TabIndex = 7;
            // 
            // txtMaChuyen
            // 
            this.txtMaChuyen.Location = new System.Drawing.Point(108, 87);
            this.txtMaChuyen.Name = "txtMaChuyen";
            this.txtMaChuyen.Size = new System.Drawing.Size(136, 22);
            this.txtMaChuyen.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên hướng dẫn viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phương tiện";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Tuyến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã chuyến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(196, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuyến du lịch hiện có";
            // 
            // gb3
            // 
            this.gb3.Controls.Add(this.datagridDuLich);
            this.gb3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb3.Location = new System.Drawing.Point(0, 265);
            this.gb3.Name = "gb3";
            this.gb3.Size = new System.Drawing.Size(839, 250);
            this.gb3.TabIndex = 2;
            this.gb3.TabStop = false;
            this.gb3.Text = "Các chuyến đi hiện có";
            // 
            // datagridDuLich
            // 
            this.datagridDuLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridDuLich.Location = new System.Drawing.Point(6, 29);
            this.datagridDuLich.Name = "datagridDuLich";
            this.datagridDuLich.RowHeadersWidth = 51;
            this.datagridDuLich.RowTemplate.Height = 24;
            this.datagridDuLich.Size = new System.Drawing.Size(821, 215);
            this.datagridDuLich.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(839, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 24);
            this.btnSave.Text = "Save";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(77, 24);
            this.toolStripButton1.Text = "Delete";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(59, 24);
            this.toolStripButton2.Text = "Edit";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(178, 24);
            this.toolStripButton3.Text = "Chi tiết chuyến du lịch";
            // 
            // frm_ChuyenDuLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 515);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gb3);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Name = "frm_ChuyenDuLich";
            this.Text = "Chuyến du lịch";
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.gb3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridDuLich)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.GroupBox gb3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ComboBox cbxPhuongTien;
        private System.Windows.Forms.ComboBox cbxMaTuyen;
        private System.Windows.Forms.TextBox txtHuongDanVien;
        private System.Windows.Forms.TextBox txtMaChuyen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView datagridDuLich;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}