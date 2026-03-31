using Microsoft.EntityFrameworkCore;
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
    public partial class fQLDiem : Form
    {
        public fQLDiem()
        {
            InitializeComponent();
        }

        private void fQLDiem_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadData();
        }
        private void LoadComboBox()
        {
            cmbDanhGia.Items.Clear();
            cmbDanhGia.Items.Add("Hoàn thành tốt");
            cmbDanhGia.Items.Add("Hoàn thành");
            cmbDanhGia.Items.Add("Chưa hoàn thành");
            cmbDanhGia.SelectedIndex = 0;

            // Em có thể thêm danh sách Học kỳ nếu muốn
            cmbHocKy.Text = "Học kỳ 1";
        }
        private void LoadData()
        {
            try
            {
                using (var db = new QLDiemDbContext())
                {
                    // Join với bảng MonHoc và HocSinh để lấy Mã thay vì lấy ID số
                    var data = db.QLDiems.Select(d => new
                    {
                        d.ID,
                        MaMon = d.MonHoc.MaMon,
                        MaHS = d.HocSinh.MaHocSinh,
                        d.DiemGiuaKy,
                        d.DiemCuoiKy,
                        d.HocKy,
                        d.NamHoc,
                        d.DanhGia,
                        d.NhanXet,
                        d.NgayCapNhat
                    }).ToList();

                    dgvQLDiem.DataSource = data;

                    // Chỉnh tiêu đề cột cho đẹp
                    if (dgvQLDiem.Columns.Count > 0)
                    {
                        dgvQLDiem.Columns["ID"].HeaderText = "ID";
                        dgvQLDiem.Columns["MaMon"].HeaderText = "MÃ MÔN";
                        dgvQLDiem.Columns["MaHS"].HeaderText = "MÃ HỌC SINH";
                        dgvQLDiem.Columns["DiemGiuaKy"].HeaderText = "ĐIỂM GIỮA KỲ";
                        dgvQLDiem.Columns["DiemCuoiKy"].HeaderText = "ĐIỂM CUỐI KỲ";
                        dgvQLDiem.Columns["HocKy"].HeaderText = "HỌC KỲ";
                        dgvQLDiem.Columns["NamHoc"].HeaderText = "NĂM HỌC";
                        dgvQLDiem.Columns["DanhGia"].HeaderText = "ĐÁNH GIÁ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMon.Text) || string.IsNullOrWhiteSpace(txtMaHocSinh.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã môn và Mã học sinh!");
                return;
            }

            try
            {
                using (var db = new QLDiemDbContext())
                {
                    // Tìm ID của Môn học và Học sinh dựa trên Mã nhập vào
                    var mon = db.MonHoc.FirstOrDefault(m => m.MaMon == txtMaMon.Text.Trim());
                    var hs = db.HocSinhs.FirstOrDefault(h => h.MaHocSinh == txtMaHocSinh.Text.Trim());

                    if (mon == null || hs == null)
                    {
                        MessageBox.Show("Mã môn hoặc Mã học sinh không tồn tại!");
                        return;
                    }

                    var diem = new QLDiem
                    {
                        MonHocID = mon.ID,
                        HocSinhID = hs.ID,
                        DiemGiuaKy = double.TryParse(txtDiemGiuaKy.Text, out double dgk) ? dgk : (double?)null,
                        DiemCuoiKy = double.TryParse(txtDiemCuoiKy.Text, out double dck) ? dck : (double?)null,
                        HocKy = cmbHocKy.Text,
                        NamHoc = dtpkNamHoc.Value.Year.ToString(),
                        DanhGia = cmbDanhGia.Text,
                        NhanXet = txtNhanXet.Text,
                        NgayCapNhat = DateTime.Now,
                        IsLock = false
                    };

                    db.QLDiems.Add(diem);
                    db.SaveChanges();
                }
                LoadData();
                btnLamMoi_Click(null, null);
                MessageBox.Show("Thêm điểm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) return;

            int id = int.Parse(txtID.Text);
            using (var db = new QLDiemDbContext())
            {
                var diem = db.QLDiems.Find(id);
                if (diem != null)
                {
                    diem.DiemGiuaKy = double.TryParse(txtDiemGiuaKy.Text, out double dgk) ? dgk : (double?)null;
                    diem.DiemCuoiKy = double.TryParse(txtDiemCuoiKy.Text, out double dck) ? dck : (double?)null;
                    diem.HocKy = cmbHocKy.Text;
                    diem.DanhGia = cmbDanhGia.Text;
                    diem.NhanXet = txtNhanXet.Text;
                    diem.NgayCapNhat = DateTime.Now;

                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Cập nhật điểm thành công!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) return;

            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng điểm này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                int id = int.Parse(txtID.Text);
                using (var db = new QLDiemDbContext())
                {
                    var diem = db.QLDiems.Find(id);
                    if (diem != null)
                    {
                        db.QLDiems.Remove(diem);
                        db.SaveChanges();
                        LoadData();
                        btnLamMoi_Click(null, null);
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtMaMon.Clear();
            txtMaHocSinh.Clear();
            txtDiemGiuaKy.Clear();
            txtDiemCuoiKy.Clear();
            txtNhanXet.Clear();
            dtpkNamHoc.Value = DateTime.Now;
            cmbDanhGia.SelectedIndex = 0;
        }
        private void dgvBangDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvQLDiem.CurrentRow != null)
            {
                var r = dgvQLDiem.CurrentRow;
                txtID.Text = r.Cells["ID"].Value?.ToString();
                txtMaMon.Text = r.Cells["MaMon"].Value?.ToString();
                txtMaHocSinh.Text = r.Cells["MaHS"].Value?.ToString();
                txtDiemGiuaKy.Text = r.Cells["DiemGiuaKy"].Value?.ToString();
                txtDiemCuoiKy.Text = r.Cells["DiemCuoiKy"].Value?.ToString();
                cmbHocKy.Text = r.Cells["HocKy"].Value?.ToString();
                cmbDanhGia.Text = r.Cells["DanhGia"].Value?.ToString();
                txtNhanXet.Text = r.Cells["NhanXet"].Value?.ToString();
            }
        }
        private void btnO_Click(object sender, EventArgs e)
        {
            using (var db = new QLDiemDbContext())
            {
                // 1. Xóa sạch dữ liệu trong bảng TaiKhoan
                // Lưu ý: Tên bảng trong Database của em thường là 'TaiKhoans' (có chữ s)
                db.Database.ExecuteSqlRaw("DELETE FROM QLDiem");

                // 2. Lệnh reset ID (Identity) quay về 0
                db.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('QLDiem', RESEED, 0)");

                MessageBox.Show("Đã dọn dẹp và reset ID về 1 thành công!");
            }
            LoadData(); // Load lại bảng trắng tinh
        }
    }
}
