using QL_Diem.Forms;

namespace QL_Diem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new fDangNhap());
            //Application.Run(new fTaiKhoan());
            //Application.Run(new fHocSinh());
            //Application.Run(new fMonHoc());
            //Application.Run(new fLop());
            Application.Run(new fQLDiem());

        }
    }
}