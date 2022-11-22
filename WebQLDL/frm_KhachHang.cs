using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebQLDL
{
    public partial class frm_KhachHang : Form
    {
        QLDKDULICHEntities1 data = new QLDKDULICHEntities1();

        public frm_KhachHang()
        {
            InitializeComponent();
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var k = new tKhach()
            {
                MaKhach = txtMaKhach.Text.Trim(),
                TenKhach = txtTenKhach.Text.Trim(),
                DienThoai = txtSDT.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
            };
            DialogResult sv = MessageBox.Show("Bạn muốn lưu dữ liệu?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sv == DialogResult.OK)
            {
                data.tKhach.Add(k);
                data.SaveChanges();
                loadData();
            }
        }

        void loadData()
        {
            int i = 0;
            List<tKhach> lstKH = data.tKhach.ToList();
            var columns = from k in lstKH
                          select new
                          {
                              STT = ++i,
                              MaKhach = k.MaKhach,
                              TenKhach = k.TenKhach,
                              SDT = k.DienThoai,
                              DiaChi = k.DiaChi,
                          };
            dsKhachHang.DataSource = columns.ToList();
            
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void dsKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow r = dsKhachHang.Rows[e.RowIndex];
                txtMaKhach.Text = r.Cells[1].Value.ToString();
                txtTenKhach.Text = r.Cells[2].Value.ToString();
                txtSDT.Text = r.Cells[3].Value.ToString();
                txtDiaChi.Text = r.Cells[4].Value.ToString();
            }

            txtMaKhach.ReadOnly = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn muốn xóa?", "cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(dialog.Equals(DialogResult.Yes))
            {
                var kh = data.tDangKy.FirstOrDefault(x => x.MaKhach.Contains(txtMaKhach.Text.Trim()));
                if (kh != null)
                {
                    MessageBox.Show("Bạn không thể xóa khách hàng này vì đã có trong dữ liệu đăng ký! Vui lòng thử lại");
                }
                else
                {
                    var del = data.tKhach
                            .Where(x => x.MaKhach == txtMaKhach.Text.Trim())
                            .FirstOrDefault();
                    data.tKhach.Remove(del);
                    data.SaveChanges();
                    loadData();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaKhach.ReadOnly = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            txtMaKhach.Clear();
            txtTenKhach.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult sv = MessageBox.Show("Bạn muốn sửa dữ liệu?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sv == DialogResult.Yes)
            {
                var del = data.tKhach
                      .Where(x => x.MaKhach == txtMaKhach.Text.Trim())
                      .FirstOrDefault();
                del.MaKhach = txtMaKhach.Text.Trim();
                del.TenKhach = txtTenKhach.Text.Trim();
                del.DienThoai = txtSDT.Text.Trim();
                del.DiaChi = txtDiaChi.Text.Trim();
                data.SaveChanges();
                loadData();
            }
            
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
