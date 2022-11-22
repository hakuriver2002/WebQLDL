using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebQLDL
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void chuyếnDuLịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ChuyenDuLich dl = new frm_ChuyenDuLich();
            dl.MdiParent = this;
            dl.Show();
        }

        private void tuyếnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Tuyen dl = new frm_Tuyen();
            dl.MdiParent = this;
            dl.Show();
        }

        private void stripKhachHang_Click(object sender, EventArgs e)
        {
            frm_Khach dl = new frm_Khach();
            dl.MdiParent = this;
            dl.Show();
        }

        private void stripDangKy_Click(object sender, EventArgs e)
        {
            frm_Dangky dl = new frm_Dangky();
            dl.MdiParent = this;
            dl.Show();
        }

        private void stripDiaDiemThamQuan_Click(object sender, EventArgs e)
        {
            frm_DiaDiemThamQuan dl = new frm_DiaDiemThamQuan();
            dl.MdiParent = this;
            dl.Show();
        }
    }
}
