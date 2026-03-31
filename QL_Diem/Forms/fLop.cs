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
    public partial class fLop : Form
    {
        public fLop()
        {
            InitializeComponent();
        }

        private void fLop_Load(object sender, EventArgs e)
        {

            LoadData();
        }


        // 2. Tải dữ liệu lớp học lên bảng
        private void LoadData()
        {
            try
            {
                using (var db = new QLDiemDbContext())
                {
                    var data = db.LopHocs.Select(l => new
                    {
                        l.ID,
                        l.MaLop,
                        l.TenLop,
                        l.GiaoVienChuNhiem,
                        l.SoLuong,
                        l.NamHoc
                    }).ToList();

                    dgvLop.DataSource = data;

                    // ---- ĐOẠN CODE CHỈNH LẠI CỘT ĐÂY ----
                    if (dgvLop.Columns.Count > 0)
                    {
                        dgvLop.Columns["ID"].HeaderText = "ID";
                        dgvLop.Columns["MaLop"].HeaderText = "MÃ LỚP";
                        dgvLop.Columns["TenLop"].HeaderText = "TÊN LỚP";
                        dgvLop.Columns["GiaoVienChuNhiem"].HeaderText = "GIÁO VIÊN CHỦ NHIỆM";
                        dgvLop.Columns["SoLuong"].HeaderText = "SỐ LƯỢNG";
                        dgvLop.Columns["NamHoc"].HeaderText = "NĂM HỌC";
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
            // 1. Kiểm tra đầu vào cơ bản
            if (string.IsNullOrWhiteSpace(txtMaLop.Text) || string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã lớp và Tên lớp!");
                return;
            }

            try
            {
                using (var db = new QLDiemDbContext())
                {
                    // 2. Kiểm tra trùng mã lớp
                    if (db.LopHocs.Any(x => x.MaLop == txtMaLop.Text.Trim()))
                    {
                        MessageBox.Show("Mã lớp này đã tồn tại!");
                        return;
                    }

                    // 3. Tạo đối tượng Lop và GÁN ĐẦY ĐỦ các thuộc tính mà Entity yêu cầu
                    var lop = new Lop
                    {
                        MaLop = txtMaLop.Text.Trim(),
                        TenLop = txtTenLop.Text.Trim(),
                        GiaoVienChuNhiem = cmbGVCN.Text,
                        SoLuong = (int)numSoLuong.Value,
                        NamHoc = dtpkNamHoc.Value.Year.ToString(),

                        // --- PHẦN QUAN TRỌNG: Gán giá trị mặc định cho các cột còn thiếu ---
                        KhoiLop = 1,          // Tạm thời để là khối 1 (Bạn có thể sửa tùy ý)
                        PhongHoc = "Chưa xếp", // Tránh để null nếu DB không cho phép
                        DaKetThuc = false     // Lớp mới tạo thì tất nhiên là chưa kết thúc
                    };

                    db.LopHocs.Add(lop);
                    db.SaveChanges(); // Lưu vào Database
                }

                // 4. Cập nhật lại giao diện sau khi thêm thành công
                LoadData();
                btnLamMoi_Click(null, null);
                MessageBox.Show("Thêm lớp thành công!");
            }
            catch (Exception ex)
            {
                // 5. Đoạn catch này sẽ hiện thông báo cực kỳ chi tiết nếu vẫn còn lỗi
                string errorDetail = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                if (ex.InnerException?.InnerException != null)
                    errorDetail = ex.InnerException.InnerException.Message;

                MessageBox.Show("Lỗi Database chi tiết: " + errorDetail);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();
            numSoLuong.Value = 0;
            txtMaLop.Focus();
        }
        // 4. Sự kiện click bảng đổ dữ liệu lên control
        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào dòng dữ liệu hay không (tránh click vào tiêu đề)
            if (e.RowIndex >= 0 && dgvLop.CurrentRow != null)
            {
                try
                {
                    var r = dgvLop.CurrentRow;

                    // Cách an toàn nhất: Lấy giá trị theo đúng tên thuộc tính bạn đã Select ở LoadData
                    txtID.Text = r.Cells["ID"].Value?.ToString();
                    txtMaLop.Text = r.Cells["MaLop"].Value?.ToString();
                    txtTenLop.Text = r.Cells["TenLop"].Value?.ToString();

                    // Dùng ?.ToString() để tránh lỗi Crash nếu dữ liệu trong ô đó bị Null
                    cmbGVCN.Text = r.Cells["GiaoVienChuNhiem"].Value?.ToString() ?? "";

                    // Xử lý số lượng (ép kiểu cẩn thận)
                    if (r.Cells["SoLuong"].Value != null)
                    {
                        numSoLuong.Value = Convert.ToDecimal(r.Cells["SoLuong"].Value);
                    }
                    else
                    {
                        numSoLuong.Value = 0;
                    }
                }
                catch (Exception ex)
                {
                    // Nếu vẫn lỗi, thông báo này sẽ cho biết chính xác tên cột nào bị sai
                    MessageBox.Show("Lỗi đổ dữ liệu: " + ex.Message);
                }
            }
        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLop.CurrentRow == null) return;

            int id = (int)dgvLop.CurrentRow.Cells["ID"].Value;
            using (var db = new QLDiemDbContext())
            {
                var lop = db.LopHocs.Find(id);
                if (lop != null)
                {
                    lop.MaLop = txtMaLop.Text.Trim();
                    lop.TenLop = txtTenLop.Text.Trim();
                    lop.GiaoVienChuNhiem = cmbGVCN.Text;
                    lop.SoLuong = (int)numSoLuong.Value;
                    lop.NamHoc = "2025-2026"; // Đảm bảo không bị null khi sửa

                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Cập nhật thành công!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLop.CurrentRow == null) return;

            var confirm = MessageBox.Show("Xóa lớp này sẽ ảnh hưởng đến dữ liệu học sinh. Bạn chắc chứ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    int id = (int)dgvLop.CurrentRow.Cells["ID"].Value;
                    using (var db = new QLDiemDbContext())
                    {
                        var lop = db.LopHocs.Find(id);
                        if (lop != null)
                        {
                            db.LopHocs.Remove(lop);
                            db.SaveChanges();
                            LoadData();
                            btnLamMoi_Click(null, null);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể xóa lớp đang có học sinh!");
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        // 1. Xóa sạch dữ liệu trong bảng LopHocs
                        // Lưu ý: Nếu có bảng Học Sinh đang liên kết với bảng Lớp, lệnh này sẽ lỗi (vì ràng buộc khóa ngoại)
                        db.Database.ExecuteSqlRaw("DELETE FROM LopHocs");

                        // 2. Lệnh reset ID (Identity) của bảng LopHocs quay về 0
                        db.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('LopHocs', RESEED, 0)");

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
    }

}

