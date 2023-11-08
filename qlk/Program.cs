using QLK.utils;

namespace QLK
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DatabaseHelper.dbName = "KHOHANG";
            DatabaseHelper.serverName = "LAPTOP-QGBKFEJQ\\SQLEXPRESS";
            DatabaseHelper.userDb = "sa";
            DatabaseHelper.password = "123456";


            Application.Run(new frmMDI());

        }
    }
}