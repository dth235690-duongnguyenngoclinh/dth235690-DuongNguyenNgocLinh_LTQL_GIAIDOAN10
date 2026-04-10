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
    public partial class fDoiMatKhau : Form
    {
        private string _tenDangNhapHienTai;
        
        public fDoiMatKhau(string tenDN)
        {
            InitializeComponent();
            this._tenDangNhapHienTai = tenDN; // Gán giá trị được truyền vào cho biến bên trên
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string matKhauCu = txtMatKhauCu.Text.Trim();
            string matKhauMoi = txtMatKhauMoi.Text.Trim();

            // 1. Kiểm tra nhập liệu trống
            if (string.IsNullOrEmpty(matKhauCu) || string.IsNullOrEmpty(matKhauMoi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new QLDiemDbContext()) // Khởi tạo DbContext
                {
                    // 2. Tìm tài khoản trong bảng TaiKhoans
                    var taiKhoan = db.TaiKhoans.FirstOrDefault(tk => tk.TenDangNhap == _tenDangNhapHienTai);

                    if (taiKhoan == null)
                    {
                        MessageBox.Show("Không tìm thấy thông tin tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 3. Kiểm tra mật khẩu cũ (So sánh trực tiếp nếu chưa mã hóa)
                    if (taiKhoan.MatKhau != matKhauCu)
                    {
                        MessageBox.Show("Mật khẩu cũ không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 4. Kiểm tra mật khẩu mới không được trùng mật khẩu cũ
                    if (matKhauCu == matKhauMoi)
                    {
                        MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 5. Cập nhật mật khẩu mới
                    taiKhoan.MatKhau = matKhauMoi;
                    db.SaveChanges(); // Lưu thay đổi vào SQL thông qua EF Core

                    MessageBox.Show("Đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Làm mới các ô nhập
                    txtMatKhauCu.Clear();
                    txtMatKhauMoi.Clear();
                    this.Close(); // Đóng form sau khi thành công
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật mật khẩu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
