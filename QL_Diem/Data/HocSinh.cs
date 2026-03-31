using QL_DiemTruongTieuHoc.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Diem.Data
{
    public class HocSinh
    {
        public int ID { get; set; } // Khóa chính tự tăng
        public string MaHocSinh { get; set; } // Ví dụ: HS2024001
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoaiPhuHuynh { get; set; }
        // Liên kết với lớp học (Quan hệ 1 lớp - nhiều học sinh)
        public int LopID { get; set; }
        public virtual Lop Lop { get; set; }
        public string TrangThai { get; set; } // Đang học, Nghỉ học...
        // Quan hệ 1 học sinh có nhiều bảng điểm
        public virtual ICollection<QLDiem> BangDiems { get; set; }
    }
}
