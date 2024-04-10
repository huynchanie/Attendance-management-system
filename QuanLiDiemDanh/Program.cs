namespace QuanLiDiemDanh
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
            Application.Run(new Login());
            if (AppData.isLogined)
            {
                if (AppData.isAdmin)
                {
                    Application.Run(new FormAdmin());
                }
                else
                {
                    Application.Run(new FormUser());
                }
            }
        }
    }
}