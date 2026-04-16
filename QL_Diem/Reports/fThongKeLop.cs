using Microsoft.Reporting.WinForms;
using QL_DiemTruongTieuHoc.Data; // Đảm bảo đúng Namespace của DbContext
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QL_Diem.Reports
{
    public partial class fThongKeLop : Form
    {
        // Khai báo biến ReportViewer bằng tay vì Designer bị lỗi
        private ReportViewer reportViewer1;

        public fThongKeLop()
        {
            InitializeComponent();
            SetupReportViewer(); // Gọi hàm khởi tạo giao diện
        }

        // Hàm này thay thế cho việc kéo thả từ Toolbox
        private void SetupReportViewer()
        {
            reportViewer1 = new ReportViewer();
            reportViewer1.Dock = DockStyle.Fill; // Cho báo cáo tràn toàn bộ Form
            this.Controls.Add(reportViewer1);    // Thêm nó vào Form
        }

        private void fThongKeLop_Load(object sender, EventArgs e)
        {
            DoBaoCao();
        }

        private void DoBaoCao()
        {
            try
            {
                using (var db = new QLDiemDbContext())
                {
                    // 1. Lấy dữ liệu và nhóm theo Lớp, đếm số học sinh
                    var dataThongKe = db.HocSinhs
                        .GroupBy(h => h.Lop)
                        .Select(g => new
                        {
                            TenLop = g.Key,
                            SoLuongHS = g.Count()
                        })
                        .ToList();

                    // 2. Clear dữ liệu cũ
                    reportViewer1.LocalReport.DataSources.Clear();

                    // 3. Gán dữ liệu (Lưu ý: "DataSet1" phải khớp với tên trong file .rdlc)
                    ReportDataSource rds = new ReportDataSource("DataSet1", dataThongKe);
                    reportViewer1.LocalReport.DataSources.Add(rds);

                    // 4. Chỉ đường dẫn file RDLC (Nhớ chuột phải file rdlc chọn Copy Always)
                    reportViewer1.LocalReport.ReportPath = "Reports/rptThongKeLop.rdlc";

                    // 5. Hiển thị
                    reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Thông báo");
            }
        }
    }
}