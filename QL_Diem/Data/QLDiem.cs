using QL_Diem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DiemTruongTieuHoc.Data
{
    public class QLDiem
    {
        public int ID { get; set; }

        // Liên kết dữ liệu (Foreign Keys)
        public int HocSinhID { get; set; }
        public virtual HocSinh HocSinh { get; set; }
        public int MonHocID { get; set; }
        public virtual MonHoc MonHoc { get; set; }

        // Dữ liệu điểm số & Đánh giá 
        public double? DiemGiuaKy { get; set; }
        public double? DiemCuoiKy { get; set; }
        public string HocKy { get; set; } // "Học kỳ 1", "Học kỳ 2"
        public string NamHoc { get; set; } // Ví dụ: 2025-2026
        // Đặc thù Tiểu học: Nhận xét & Xếp loại 
        public string NhanXet { get; set; }
        public string DanhGia { get; set; } // Hoàn thành tốt, Hoàn thành...
        public DateTime NgayCapNhat { get; set; }
        public bool IsLock { get; set; } // Khóa điểm sau khi đã phê duyệt để đảm bảo tính "Liêm" [cite: 99]
    }
}
