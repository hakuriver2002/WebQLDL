namespace WebQLDL
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stripTrangTru = new System.Windows.Forms.ToolStripMenuItem();
            this.stripDuLich = new System.Windows.Forms.ToolStripMenuItem();
            this.stripDangKy = new System.Windows.Forms.ToolStripMenuItem();
            this.stripDiaDiemThamQuan = new System.Windows.Forms.ToolStripMenuItem();
            this.stripChuyenDuLich = new System.Windows.Forms.ToolStripMenuItem();
            this.stripTuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.stripKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.stripThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.StripBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripTrangTru,
            this.stripDuLich,
            this.stripKhachHang,
            this.stripThongKe,
            this.StripBaoCao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stripTrangTru
            // 
            this.stripTrangTru.Name = "stripTrangTru";
            this.stripTrangTru.Size = new System.Drawing.Size(87, 24);
            this.stripTrangTru.Text = "Trang chủ";
            // 
            // stripDuLich
            // 
            this.stripDuLich.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripDangKy,
            this.stripDiaDiemThamQuan,
            this.stripChuyenDuLich,
            this.stripTuyen});
            this.stripDuLich.Name = "stripDuLich";
            this.stripDuLich.Size = new System.Drawing.Size(69, 24);
            this.stripDuLich.Text = "Du lịch";
            // 
            // stripDangKy
            // 
            this.stripDangKy.Name = "stripDangKy";
            this.stripDangKy.Size = new System.Drawing.Size(228, 26);
            this.stripDangKy.Text = "Đăng ký du lịch";
            this.stripDangKy.Click += new System.EventHandler(this.stripDangKy_Click);
            // 
            // stripDiaDiemThamQuan
            // 
            this.stripDiaDiemThamQuan.Name = "stripDiaDiemThamQuan";
            this.stripDiaDiemThamQuan.Size = new System.Drawing.Size(228, 26);
            this.stripDiaDiemThamQuan.Text = "Địa điểm tham quan";
            this.stripDiaDiemThamQuan.Click += new System.EventHandler(this.stripDiaDiemThamQuan_Click);
            // 
            // stripChuyenDuLich
            // 
            this.stripChuyenDuLich.Name = "stripChuyenDuLich";
            this.stripChuyenDuLich.Size = new System.Drawing.Size(228, 26);
            this.stripChuyenDuLich.Text = "Chuyến du lịch";
            this.stripChuyenDuLich.Click += new System.EventHandler(this.chuyếnDuLịchToolStripMenuItem_Click);
            // 
            // stripTuyen
            // 
            this.stripTuyen.Name = "stripTuyen";
            this.stripTuyen.Size = new System.Drawing.Size(228, 26);
            this.stripTuyen.Text = "Tuyến";
            this.stripTuyen.Click += new System.EventHandler(this.tuyếnToolStripMenuItem_Click);
            // 
            // stripKhachHang
            // 
            this.stripKhachHang.Name = "stripKhachHang";
            this.stripKhachHang.Size = new System.Drawing.Size(100, 24);
            this.stripKhachHang.Text = "Khách hàng";
            this.stripKhachHang.Click += new System.EventHandler(this.stripKhachHang_Click);
            // 
            // stripThongKe
            // 
            this.stripThongKe.Name = "stripThongKe";
            this.stripThongKe.Size = new System.Drawing.Size(84, 24);
            this.stripThongKe.Text = "Thống kê";
            // 
            // StripBaoCao
            // 
            this.StripBaoCao.Name = "StripBaoCao";
            this.StripBaoCao.Size = new System.Drawing.Size(77, 24);
            this.StripBaoCao.Text = "Báo cáo";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_main";
            this.Text = "Quản lý du lịch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stripTrangTru;
        private System.Windows.Forms.ToolStripMenuItem stripDuLich;
        private System.Windows.Forms.ToolStripMenuItem stripDangKy;
        private System.Windows.Forms.ToolStripMenuItem stripDiaDiemThamQuan;
        private System.Windows.Forms.ToolStripMenuItem stripChuyenDuLich;
        private System.Windows.Forms.ToolStripMenuItem stripTuyen;
        private System.Windows.Forms.ToolStripMenuItem stripKhachHang;
        private System.Windows.Forms.ToolStripMenuItem stripThongKe;
        private System.Windows.Forms.ToolStripMenuItem StripBaoCao;
    }
}