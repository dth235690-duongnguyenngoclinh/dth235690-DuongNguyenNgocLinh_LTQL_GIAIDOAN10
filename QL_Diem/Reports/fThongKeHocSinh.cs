// 1. Phải thêm dòng này để sử dụng thư viện Report
using Microsoft.Reporting.WinForms;
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

namespace QL_Diem.Reports
{
    public partial class fThongKeHocSinh : Form
    {
        // 2. Khai báo biến ReportViewer
        private ReportViewer reportViewer1;

        public fThongKeHocSinh()
        {
            InitializeComponent();

            // 3. Khởi tạo ReportViewer bằng code (Thay vì kéo thả bị lỗi)
            reportViewer1 = new ReportViewer();
            reportViewer1.Dock = DockStyle.Fill; // Để báo cáo tràn hết Form
            this.Controls.Add(reportViewer1); // Thêm nó vào giao diện Form
        }

        // 4. Khi Form load, thiết lập file rdlc và đổ dữ liệu
        private void fThongKeHocSinh_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Khởi tạo Database Context (Thay bằng tên Context thật của bạn)
                QLDiemDbContext db = new QLDiemDbContext();

                // 2. Lấy dữ liệu học sinh từ SQL
                var dsHocSinh = db.HocSinhs.ToList();

                // 3. Xóa dữ liệu cũ trên Report (nếu có)
                reportViewer1.LocalReport.DataSources.Clear();

                // 4. Tạo nguồn dữ liệu mới (Tên "DataSet1" phải khớp chính xác với tên trong file .rdlc)
                ReportDataSource rds = new ReportDataSource("DataSet1", dsHocSinh);
                reportViewer1.LocalReport.DataSources.Add(rds);

                // 5. Chỉ đường dẫn tới file thiết kế .rdlc
                // Lưu ý: Copy file rdlc vào thư mục bin/Debug hoặc dùng đường dẫn tương đối
                reportViewer1.LocalReport.ReportPath = "Reports/rptThongKeHocSinh.rdlc";

                // 6. Làm mới lại báo cáo
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}