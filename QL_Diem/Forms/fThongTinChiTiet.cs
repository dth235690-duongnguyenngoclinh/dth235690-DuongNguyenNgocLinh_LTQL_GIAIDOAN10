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
    public partial class fThongTinChiTiet : Form
    {
        // Hàm khởi tạo nhận 2 tham số: tên và loại tài khoản
        public fThongTinChiTiet(string ten, string loai)
        {
            InitializeComponent();

            txtTenDangNhap.Text = ten;
            txtLoaiTaiKhoan.Text = loai; 
            txtMatKhau.Text = "********";
        }
    }
}
