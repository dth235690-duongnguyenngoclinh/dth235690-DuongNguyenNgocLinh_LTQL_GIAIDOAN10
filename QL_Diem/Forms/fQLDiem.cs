using Microsoft.EntityFrameworkCore;
using QL_DiemTruongTieuHoc.Data;
using System;
using System.Linq;
using System.Text;
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

            cmbHocKy.Text = "Học kỳ 1";
        }

        private void LoadData()
        {
            try
            {
                using (var db = new QLDiemDbContext())
                {
                    var data = db.QLDiems
                        .Include(d => d.HocSinh).ThenInclude(h => h.Lop)
                        .Include(d => d.MonHoc)
                        .Select(d => new
                        {
                            d.ID,
                            MaHocSinh = d.HocSinh.MaHocSinh,
                            HoTen = d.HocSinh.HoTen,
                            TenLop = d.HocSinh.Lop.TenLop,
                            MaMon = d.MonHoc.MaMon,
                            TenMon = d.MonHoc.TenMon,
                            d.KTThuongXuyen1,
                            d.KTThuongXuyen2,
                            d.KTThuongXuyen3,
                            d.DiemGiuaKy,
                            d.DiemCuoiKy,
                            d.HocKy,
                            d.NamHoc,
                            d.NhanXet,
                            d.DanhGia,
                            d.NgayCapNhat,
                            d.IsLock
                        }).ToList();

                    dgvQLDiem.AutoGenerateColumns = false;

                    dgvQLDiem.DataSource = data;

                    if (dgvQLDiem.Columns.Count > 0)
                    {
                        dgvQLDiem.Columns["MaHocSinh"].HeaderText = "MÃ HS";
                        dgvQLDiem.Columns["HoTen"].HeaderText = "TÊN HS";
                        dgvQLDiem.Columns["TenLop"].HeaderText = "TÊN LỚP";
                        dgvQLDiem.Columns["MaMon"].HeaderText = "MÃ MÔN";
                        dgvQLDiem.Columns["TenMon"].HeaderText = "TÊN MÔN";
                        dgvQLDiem.Columns["KTThuongXuyen1"].HeaderText = "THƯỜNG XUYÊN 1";
                        dgvQLDiem.Columns["KTThuongXuyen2"].HeaderText = "THƯỜNG XUYÊN 2";
                        dgvQLDiem.Columns["KTThuongXuyen3"].HeaderText = "THƯỜNG XUYÊN 3";
                        dgvQLDiem.Columns["IsLock"].HeaderText = "KHÓA";
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
                        KTThuongXuyen1 = double.TryParse(txtKTThuongXuyen1.Text, out double tx1) ? tx1 : (double?)null,
                        KTThuongXuyen2 = double.TryParse(txtKTThuongXuyen2.Text, out double tx2) ? tx2 : (double?)null,
                        KTThuongXuyen3 = double.TryParse(txtKTThuongXuyen3.Text, out double tx3) ? tx3 : (double?)null,
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
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!");
                return;
            }

            int id = int.Parse(txtID.Text);
            using (var db = new QLDiemDbContext())
            {
                var diem = db.QLDiems.Find(id);
                if (diem != null)
                {
                    // KIỂM TRA KHÓA
                    if (diem.IsLock)
                    {
                        MessageBox.Show("Dòng điểm này đã bị khóa, không thể sửa!", "Thông báo");
                        return;
                    }
                    diem.KTThuongXuyen1 = double.TryParse(txtKTThuongXuyen1.Text, out double tx1) ? tx1 : (double?)null;
                    diem.KTThuongXuyen2 = double.TryParse(txtKTThuongXuyen2.Text, out double tx2) ? tx2 : (double?)null;
                    diem.KTThuongXuyen3 = double.TryParse(txtKTThuongXuyen3.Text, out double tx3) ? tx3 : (double?)null;
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
            txtKTThuongXuyen1.Clear();
            txtKTThuongXuyen2.Clear();
            txtKTThuongXuyen3.Clear();
            txtDiemGiuaKy.Clear();
            txtDiemCuoiKy.Clear();
            txtNhanXet.Clear();
            txtHoTen.Clear();
            txtTenLop.Clear();
            txtTenMon.Clear();
            dtpkNamHoc.Value = DateTime.Now;
            cmbDanhGia.SelectedIndex = 0;
        }

        private void dgvQLDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvQLDiem.CurrentRow != null)
            {
                var r = dgvQLDiem.CurrentRow;
                txtID.Text = r.Cells["ID"].Value?.ToString();
                txtMaHocSinh.Text = r.Cells["MaHocSinh"].Value?.ToString();
                txtHoTen.Text = r.Cells["HoTen"].Value?.ToString();
                txtTenLop.Text = r.Cells["TenLop"].Value?.ToString();
                txtMaMon.Text = r.Cells["MaMon"].Value?.ToString();
                txtTenMon.Text = r.Cells["TenMon"].Value?.ToString();
                txtKTThuongXuyen1.Text = r.Cells["KTThuongXuyen1"].Value?.ToString();
                txtKTThuongXuyen2.Text = r.Cells["KTThuongXuyen2"].Value?.ToString();
                txtKTThuongXuyen3.Text = r.Cells["KTThuongXuyen3"].Value?.ToString();
                txtDiemGiuaKy.Text = r.Cells["DiemGiuaKy"].Value?.ToString();
                txtDiemCuoiKy.Text = r.Cells["DiemCuoiKy"].Value?.ToString();
                cmbHocKy.Text = r.Cells["HocKy"].Value?.ToString();
                txtNhanXet.Text = r.Cells["NhanXet"].Value?.ToString();
                cmbDanhGia.Text = r.Cells["DanhGia"].Value?.ToString();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHocSinh.Text))
            {
                MessageBox.Show("Vui lòng chọn học sinh để in phiếu điểm!");
                return;
            }

            using (var db = new QLDiemDbContext())
            {
                var maHS = txtMaHocSinh.Text.Trim();
                var hs = db.HocSinhs.Include(h => h.Lop).FirstOrDefault(h => h.MaHocSinh == maHS);
                if (hs == null) return;

                var data = db.QLDiems
                    .Where(d => d.HocSinh.MaHocSinh == maHS)
                    .Include(d => d.MonHoc)
                    .ToList();

                if (data.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu điểm cho học sinh này!");
                    return;
                }

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("PHIẾU ĐIỂM");
                sb.AppendLine($"Họ và tên: {hs.HoTen}");
                sb.AppendLine($"Lớp: {hs.Lop.TenLop}");
                sb.AppendLine("--------------------------------------------------");
                sb.AppendLine("KẾT QUẢ HỌC TẬP:");

                foreach (var item in data.OrderBy(d => d.NamHoc).ThenBy(d => d.HocKy).ThenBy(d => d.MonHoc.TenMon))
                {
                    sb.AppendLine($"Năm học: {item.NamHoc} - Học kỳ: {item.HocKy} - Môn: {item.MonHoc.TenMon}");
                    sb.AppendLine($"Điểm: TX1={item.KTThuongXuyen1}, TX2={item.KTThuongXuyen2}, TX3={item.KTThuongXuyen3}, GK={item.DiemGiuaKy}, CK={item.DiemCuoiKy}");
                    sb.AppendLine($"Đánh giá: {item.DanhGia}");
                    sb.AppendLine($"Nhận xét: {item.NhanXet}");
                    sb.AppendLine();
                }

                // Tạo thư mục PhieuDiem nếu chưa có
                string folderPath = Path.Combine(Application.StartupPath, "PhieuDiem");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // Lưu file theo mã học sinh + tên
                string fileName = $"{hs.MaHocSinh}_{hs.HoTen}_PhieuDiem.txt";
                string filePath = Path.Combine(folderPath, fileName);

                File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);

                MessageBox.Show($"Phiếu điểm đã được lưu tại: {filePath}", "Thông báo");
            }
        }
        

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng chọn một dòng để khóa!");
                return;
            }

            int id = int.Parse(txtID.Text);
            using (var db = new QLDiemDbContext())
            {
                var diem = db.QLDiems.Find(id);
                if (diem != null)
                {
                    // Nếu chưa khóa thì mới cho khóa
                    if (!diem.IsLock)
                    {
                        diem.IsLock = true;
                        db.SaveChanges();
                        LoadData();
                        MessageBox.Show("Đã khóa điểm thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Dòng điểm này đã bị khóa trước đó!");
                    }
                }
            }
        }
    }
}
