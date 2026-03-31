using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DiemTruongTieuHoc.Data
{
    public class MonHoc
    {
        public int ID { get; set; } // Khóa chính (Database)
        public string MaMon { get; set; } // Mã môn nghiệp vụ (Vd: T1, TV2) 
        public string TenMon { get; set; } // Tên môn học 
        public int SoTiet { get; set; } // Số tiết học 
        public string LoaiMon { get; set; } // Tính điểm hoặc Nhận xét 
        public int KhoiLop { get; set; } // Thuộc khối 1, 2, 3, 4, 5
        public bool TrangThai { get; set; } // Còn đang giảng dạy hay không [cite: 42]
        // Quan hệ 1-N với bảng điểm
        public virtual ICollection<QLDiem> BangDiems { get; set; }
    }
}