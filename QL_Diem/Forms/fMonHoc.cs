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
    public partial class fMonHoc : Form
    {
        public fMonHoc()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMon.Text) || string.IsNullOrWhiteSpace(txtTenMon.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã môn và Tên môn!");
                return;
            }

            try
            {
                using (var db = new QLDiemDbContext())
                {
                    if (db.MonHoc.Any(x => x.MaMon == txtMaMon.Text.Trim()))
                    {
                        MessageBox.Show("Mã môn học này đã tồn tại!");
                        return;
                    }

                    var mh = new MonHoc
                    {
                        MaMon = txtMaMon.Text.Trim(),
                        TenMon = txtTenMon.Text.Trim(),
                        SoTiet = (int)numSoTiet.Value,
                        LoaiMon = cmbLoaiMon.Text,
                        KhoiLop = int.TryParse(txtKhoiLop.Text, out int k) ? k : 1,
                        TrangThai = rdDangDay.Checked // Giả định em đặt tên RadioButton là rdbDangDay
                    };

                    db.MonHoc.Add(mh);
                    db.SaveChanges();
                }
                LoadData();
                btnLamMoi_Click(null, null);
                MessageBox.Show("Thêm môn học thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.CurrentRow == null) return;

            try
            {
                int id = (int)dgvMonHoc.CurrentRow.Cells["ID"].Value;
                using (var db = new QLDiemDbContext())
                {
                    var mh = db.MonHoc.Find(id);
                    if (mh != null)
                    {
                        mh.MaMon = txtMaMon.Text.Trim();
                        mh.TenMon = txtTenMon.Text.Trim();
                        mh.SoTiet = (int)numSoTiet.Value;
                        mh.LoaiMon = cmbLoaiMon.Text;
                        mh.KhoiLop = int.TryParse(txtKhoiLop.Text, out int k) ? k : 1;
                        mh.TrangThai = rdDangDay.Checked;

                        db.SaveChanges();
                        LoadData();
                        MessageBox.Show("Cập nhật môn học thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.CurrentRow == null) return;

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa môn học này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    int id = (int)dgvMonHoc.CurrentRow.Cells["ID"].Value;
                    using (var db = new QLDiemDbContext())
                    {
                        var mh = db.MonHoc.Find(id);
                        if (mh != null)
                        {
                            db.MonHoc.Remove(mh);
                            db.SaveChanges();
                            LoadData();
                            btnLamMoi_Click(null, null);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể xóa môn học đã có dữ liệu điểm!");
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
            txtTenMon.Clear();
            numSoTiet.Value = 0;
            txtKhoiLop.Clear();
            rdDangDay.Checked = true;
            if (cmbLoaiMon.Items.Count > 0) cmbLoaiMon.SelectedIndex = 0;
            txtMaMon.Focus();
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            using (var db = new QLDiemDbContext())
            {
                // 1. Xóa sạch dữ liệu trong bảng TaiKhoan
                // Lưu ý: Tên bảng trong Database của em thường là 'TaiKhoans' (có chữ s)
                db.Database.ExecuteSqlRaw("DELETE FROM MonHoc");

                // 2. Lệnh reset ID (Identity) quay về 0
                db.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('MonHoc', RESEED, 0)");

                MessageBox.Show("Đã dọn dẹp và reset ID về 1 thành công!");
            }
            LoadData(); // Load lại bảng trắng tinh
        }

        private void fMonHoc_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadData();
        }
        private void LoadComboBox()
        {
            cmbLoaiMon.Items.Clear();
            cmbLoaiMon.Items.Add("Tính điểm");
            cmbLoaiMon.Items.Add("Nhận xét");
            cmbLoaiMon.SelectedIndex = 0;
        }
        private void LoadData()
        {
            try
            {
                using (var db = new QLDiemDbContext())
                {
                    var data = db.MonHoc.Select(m => new
                    {
                        m.ID,
                        m.MaMon,
                        m.TenMon,
                        m.SoTiet,
                        TrangThai = m.TrangThai ? "Đang dạy" : "Tạm ngưng",
                        m.LoaiMon,
                        m.KhoiLop
                    }).ToList();

                    dgvMonHoc.DataSource = data;

                    if (dgvMonHoc.Columns.Count > 0)
                    {
                        dgvMonHoc.Columns["ID"].HeaderText = "ID";
                        dgvMonHoc.Columns["MaMon"].HeaderText = "MÃ MÔN";
                        dgvMonHoc.Columns["TenMon"].HeaderText = "TÊN MÔN";
                        dgvMonHoc.Columns["SoTiet"].HeaderText = "SỐ TIẾT";
                        dgvMonHoc.Columns["TrangThai"].HeaderText = "TRẠNG THÁI";
                        dgvMonHoc.Columns["LoaiMon"].HeaderText = "LOẠI MÔN";
                        dgvMonHoc.Columns["KhoiLop"].HeaderText = "KHỐI LỚP";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }
        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvMonHoc.CurrentRow != null)
            {
                var r = dgvMonHoc.CurrentRow;
                txtID.Text = r.Cells["ID"].Value?.ToString();
                txtMaMon.Text = r.Cells["MaMon"].Value?.ToString();
                txtTenMon.Text = r.Cells["TenMon"].Value?.ToString();
                numSoTiet.Value = Convert.ToDecimal(r.Cells["SoTiet"].Value);
                cmbLoaiMon.Text = r.Cells["LoaiMon"].Value?.ToString();
                txtKhoiLop.Text = r.Cells["KhoiLop"].Value?.ToString();

                bool tt = r.Cells["TrangThai"].Value?.ToString() == "Đang dạy";
                if (tt) rdDangDay.Checked = true;
                else rdTamNgung.Checked = true;
            }
        }
    }
}
