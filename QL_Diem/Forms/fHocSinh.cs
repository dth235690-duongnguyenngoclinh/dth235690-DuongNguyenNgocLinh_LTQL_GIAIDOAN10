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
                    // Chúng ta dùng 'Select' để chỉ lấy những thông tin cần thiết 
                    // y như cách em làm bên Form MonHoc
                    var data = db.HocSinhs.Select(h => new
                    {
                        h.ID,
                        MaHocSinh = h.MaHocSinh,
                        HoTen = h.HoTen,
                        GioiTinh = h.GioiTinh,
                        // Chỗ này quan trọng: Chỉ lấy TÊN LỚP, không lấy cả object Lop
                        TenLop = h.Lop != null ? h.Lop.TenLop : "Chưa xếp",
                        NgaySinh = h.NgaySinh,
                        DiaChi = h.DiaChi
                    }).ToList();

                    dgvHocSinh.DataSource = data;

                    // Đặt tên tiêu đề cột cho chuyên nghiệp
                    if (dgvHocSinh.Columns.Count > 0)
                    {
                        dgvHocSinh.Columns["ID"].HeaderText = "ID";
                        dgvHocSinh.Columns["MaHocSinh"].HeaderText = "MÃ HỌC SINH";
                        dgvHocSinh.Columns["HoTen"].HeaderText = "TÊN HỌC SINH";
                        dgvHocSinh.Columns["GioiTinh"].HeaderText = "GIỚI TÍNH";
                        dgvHocSinh.Columns["TenLop"].HeaderText = "LỚP";
                        dgvHocSinh.Columns["NgaySinh"].HeaderText = "NGÀY SINH";
                        dgvHocSinh.Columns["DiaChi"].HeaderText = "ĐỊA CHỈ";

                        // Tự động giãn cách các cột cho vừa khung hình (Y hệt Form MonHoc)
                        dgvHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu học sinh: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHocSinh.Text) || string.IsNullOrWhiteSpace(txtTHoTen.Text))
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
                    HoTen = txtTHoTen.Text.Trim(),
                    NgaySinh = dtpkNgaySinh.Value,
                    GioiTinh = rdNam.Checked ? "Nam" : "Nữ",
                    DiaChi = txtDiaChi.Text.Trim(),
                    SoDienThoaiPhuHuynh = txtSoDienThoaiPhuHuynh.Text.Trim(),
                    TrangThai = "Đang học",
                    LopID = 1 // TẠM THỜI: Gán ID lớp là 1 để không bị lỗi khóa ngoại
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
                    hs.HoTen = txtTHoTen.Text.Trim();
                    hs.NgaySinh = dtpkNgaySinh.Value;
                    hs.GioiTinh = rdNam.Checked ? "Nam" : "Nữ";
                    hs.DiaChi = txtDiaChi.Text.Trim();
                    hs.SoDienThoaiPhuHuynh = txtSoDienThoaiPhuHuynh.Text.Trim();

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
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtMaHocSinh.Clear();
            txtTHoTen.Clear();
            txtDiaChi.Clear();
            txtSoDienThoaiPhuHuynh.Clear();
            rdNam.Checked = true;
            dtpkNgaySinh.Value = DateTime.Now;
            txtMaHocSinh.Focus();
        }
        // 5. Đổ dữ liệu lên TextBox khi click bảng
        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvHocSinh.CurrentRow != null)
            {
                var r = dgvHocSinh.CurrentRow;

                // Lấy dữ liệu dựa theo tên cột mình đã đặt ở hàm LoadData
                txtID.Text = r.Cells["ID"].Value?.ToString();
                txtMaHocSinh.Text = r.Cells["MaHocSinh"].Value?.ToString();
                txtTHoTen.Text = r.Cells["HoTen"].Value?.ToString();
                txtDiaChi.Text = r.Cells["DiaChi"].Value?.ToString();

                // Xử lý RadioButton giới tính
                string gioiTinh = r.Cells["GioiTinh"].Value?.ToString();
                if (gioiTinh == "Nam") rdNam.Checked = true;
                else rdNu.Checked = true;

                // Xử lý ngày sinh
                if (r.Cells["NgaySinh"].Value != null)
                {
                    dtpkNgaySinh.Value = Convert.ToDateTime(r.Cells["NgaySinh"].Value);
                }

                // Hiện tên lớp lên ComboBox hoặc TextBox lớp
                txtLopHoc.Text = r.Cells["TenLop"].Value?.ToString();
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
    }
}
