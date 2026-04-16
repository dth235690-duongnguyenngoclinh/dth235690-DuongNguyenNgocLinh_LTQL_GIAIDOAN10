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
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu từ TextBox
            string tenDN = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            // 2. Kiểm tra không được để trống
            if (string.IsNullOrEmpty(tenDN) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu!", "Thông báo");
                return;
            }

            try
            {
                using (var db = new QLDiemDbContext())
                {

                    // Lấy tất cả tài khoản ra bộ nhớ
                    var users = db.TaiKhoans.AsEnumerable();

                    // So sánh tên đăng nhập phân biệt hoa thường
                    var user = users.FirstOrDefault(x => x.TenDangNhap.Equals(tenDN, StringComparison.Ordinal));

                    if (user == null)
                    {
                        MessageBox.Show("Tên đăng nhập không tồn tại!", "Lỗi");
                        return;
                    }

                    // Kiểm tra mật khẩu (phân biệt hoa thường)
                    if (user.MatKhau.Equals(matKhau, StringComparison.Ordinal))
                    {
                        MessageBox.Show($"Chào mừng {user.LoaiTaiKhoan}: {user.TenDangNhap}!", "Thành công");
                        fHocSinh f = new fHocSinh(user.TenDangNhap, user.LoaiTaiKhoan);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không đúng!", "Lỗi");
                        txtMatKhau.Clear();
                        txtMatKhau.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }
    }
}
