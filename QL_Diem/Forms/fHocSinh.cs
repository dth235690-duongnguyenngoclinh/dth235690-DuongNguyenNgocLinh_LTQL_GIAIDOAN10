using Microsoft.EntityFrameworkCore;
using QL_Diem.Data;
using QL_DiemTruongTieuHoc.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Diem.Forms
{
    public partial class fHocSinh : Form
    {
        public fHocSinh()
        {
            InitializeComponent();
        }

        private string _tenDN;
        private string _loaiTK; // Thêm dòng này

        // Sửa Constructor để nhận thêm loại tài khoản
        public fHocSinh(string tenDangNhap, string loaiTaiKhoan)
        {
            InitializeComponent();
            this._tenDN = tenDangNhap;
            this._loaiTK = loaiTaiKhoan; // Gán giá trị
            PhanQuyen(); //gọi hàm phân quyền ngay khi form đc tạo
        }
        private void PhanQuyen()
        {
            if (_loaiTK.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = true;
                thôngTinChiTiếtToolStripMenuItem.Enabled = true;
            }
            else if (_loaiTK.Equals("GiaoVien", StringComparison.OrdinalIgnoreCase))
            {
                quảnLýTàiKhoảnToolStripMenuItem.Visible = false;
                thôngTinChiTiếtToolStripMenuItem.Visible = false;
            }


        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTaiKhoan f = new fTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLop f = new fLop();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void quảnLýMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fMonHoc f = new fMonHoc();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void qUaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLDiem f = new fQLDiem();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fHocSinh_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        // 1. Hàm tải dữ liệu lên bảng
        private void LoadData()
        {
            try
            {
                using (var db = new QLDiemDbContext())
                {
                    var data = db.HocSinhs.Select(h => new
                    {
                        h.ID,
                        h.MaHocSinh,
                        h.HoTen,
                        h.GioiTinh,
                        TenLop = h.Lop != null ? h.Lop.TenLop : "Chưa xếp",
                        h.NgaySinh,
                        h.DiaChi,
                        h.NamHoc,
                        h.SoDienThoaiPhuHuynh,
                        h.GiaoVienChuNhiem,
                        h.TrangThai
                    }).ToList();
                    dgvHocSinh.AutoGenerateColumns = false;

                    dgvHocSinh.DataSource = data;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHocSinh.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã và Tên học sinh!", "Thông báo");
                return;
            }
            using (var db = new QLDiemDbContext())
            {
                // Kiểm tra trùng mã
                if (db.HocSinhs.Any(x => x.MaHocSinh == txtMaHocSinh.Text.Trim()))
                {
                    MessageBox.Show("Mã học sinh này đã tồn tại!");
                    return;
                }

                var hs = new HocSinh
                {
                    MaHocSinh = txtMaHocSinh.Text.Trim(),
                    HoTen = txtHoTen.Text.Trim(),
                    NgaySinh = dtpkNgaySinh.Value,
                    GioiTinh = rdNam.Checked ? "Nam" : "Nữ",
                    DiaChi = txtDiaChi.Text.Trim(),
                    SoDienThoaiPhuHuynh = txtSoDienThoaiPhuHuynh.Text.Trim(),
                    TrangThai = chbDangHoc.Checked ? "Đang học" : "Nghỉ học",
                    LopID = 1,
                    NamHoc = txtNamHoc.Text.Trim(), // thêm năm học
                    GiaoVienChuNhiem = cmbGiaoVienChuNhiem.Text.Trim() // thêm GVCN
                };

                db.HocSinhs.Add(hs);
                db.SaveChanges();
            }
            LoadData();
            btnLamMoi_Click(null, null);
            MessageBox.Show("Thêm thành công!");
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.CurrentRow == null) return;
            int id = (int)dgvHocSinh.CurrentRow.Cells["ID"].Value;
            using (var db = new QLDiemDbContext())
            {
                var hs = db.HocSinhs.Find(id);
                if (hs != null)
                {
                    hs.MaHocSinh = txtMaHocSinh.Text.Trim();
                    hs.HoTen = txtHoTen.Text.Trim();
                    hs.NgaySinh = dtpkNgaySinh.Value;
                    hs.GioiTinh = rdNam.Checked ? "Nam" : "Nữ";
                    hs.DiaChi = txtDiaChi.Text.Trim();
                    hs.SoDienThoaiPhuHuynh = txtSoDienThoaiPhuHuynh.Text.Trim();
                    hs.NamHoc = txtNamHoc.Text.Trim();
                    hs.GiaoVienChuNhiem = cmbGiaoVienChuNhiem.Text.Trim();
                    hs.TrangThai = chbDangHoc.Checked ? "Đang học" : "Nghỉ học";


                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Cập nhật thành công!");
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.CurrentRow == null) return;

            var result = MessageBox.Show("Xóa học sinh này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int id = (int)dgvHocSinh.CurrentRow.Cells["ID"].Value;
                using (var db = new QLDiemDbContext())
                {
                    var hs = db.HocSinhs.Find(id);
                    if (hs != null)
                    {
                        db.HocSinhs.Remove(hs);
                        db.SaveChanges();
                        LoadData();
                        btnLamMoi_Click(null, null);
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtMaHocSinh.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoDienThoaiPhuHuynh.Clear();
            rdNam.Checked = true;
            dtpkNgaySinh.Value = DateTime.Now;
            txtMaHocSinh.Focus();
            txtNamHoc.Clear();
            cmbGiaoVienChuNhiem.SelectedIndex = -1; // hoặc cmbGiaoVienChuNhiem.Text = "";
            chbDangHoc.Checked = true;   // mặc định đang học
            chbNghiHoc.Checked = false;


        }
        // 5. Đổ dữ liệu lên TextBox khi click bảng
        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvHocSinh.CurrentRow != null)
            {
                var r = dgvHocSinh.CurrentRow;

                txtID.Text = r.Cells["ID"].Value?.ToString();
                txtMaHocSinh.Text = r.Cells["MaHocSinh"].Value?.ToString();
                txtHoTen.Text = r.Cells["HoTen"].Value?.ToString();
                txtDiaChi.Text = r.Cells["DiaChi"].Value?.ToString();
                txtSoDienThoaiPhuHuynh.Text = r.Cells["SoDienThoaiPhuHuynh"].Value?.ToString();
                string gioiTinh = r.Cells["GioiTinh"].Value?.ToString();
                if (gioiTinh == "Nam") rdNam.Checked = true;
                else rdNu.Checked = true;

                if (r.Cells["NgaySinh"].Value != null)
                {
                    dtpkNgaySinh.Value = Convert.ToDateTime(r.Cells["NgaySinh"].Value);
                }
                string trangThai = r.Cells["TrangThai"].Value?.ToString();
                chbDangHoc.Checked = (trangThai == "Đang học");
                chbNghiHoc.Checked = (trangThai == "Nghỉ học");

                txtTenLop.Text = r.Cells["TenLop"].Value?.ToString();
                txtNamHoc.Text = r.Cells["NamHoc"].Value?.ToString();
                cmbGiaoVienChuNhiem.Text = r.Cells["GiaoVienChuNhiem"].Value?.ToString();
            }
        }
        private void thôngTinChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fThongTinChiTiet(this._tenDN, this._loaiTK).ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDoiMatKhau f = new fDoiMatKhau(this._tenDN);
            f.ShowDialog();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hỏi xác nhận trước khi thoát cho chắc chắn
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnO_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("CẢNH BÁO: Hành động này sẽ XÓA SẠCH toàn bộ lớp học và reset ID về 1. Bạn có chắc chắn không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (var db = new QLDiemDbContext())
                    {
                        // 1. Xóa sạch dữ liệu trong bảng 
                        db.Database.ExecuteSqlRaw("DELETE FROM HocSinh");
                        // 2. Lệnh reset ID (Identity) của bảng LopHocs quay về 0
                        db.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('HocSinh', RESEED, 0)");
                        MessageBox.Show("Đã xóa sạch lớp học và reset ID về 1 thành công!");
                    }
                    LoadData(); // Cập nhật lại GridView (bây giờ sẽ trống trơn)
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể reset vì: " + ex.Message + "\n(Có thể do đang có Học sinh thuộc các lớp này nên không xóa được)");
                }
            }
        }

        private void chbDangHoc_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNghiHoc.Checked) chbNghiHoc.Checked = false;
        }

        private void chbNghiHoc_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDangHoc.Checked) chbDangHoc.Checked = false;
        }
    }
    
}
