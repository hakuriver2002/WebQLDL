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
    public partial class frm_ChiTietChuyenDuLich : Form
    {
        QLDKDULICHEntities1 data = new QLDKDULICHEntities1();
        public frm_ChiTietChuyenDuLich()
        {
            InitializeComponent();
        }

        private void frm_ChiTietChuyenDuLich_Load(object sender, EventArgs e)
        {
            getMaChuyen();
            getMaDiaDiem();
            //loadData();
        }

        void getMaChuyen()
        {
            cobbMaChuyen.DisplayMember = "MaChuyen";
            cobbMaChuyen.ValueMember = "MaChuyen";
            //cobbMaChuyen.DataSource = data.tChiTietChuyenDuLich
        }

        void getMaDiaDiem()
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
