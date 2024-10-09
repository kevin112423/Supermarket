using Supermarket_mvp._repository;
using Supermarket_mvp.model;
using Supermarket_mvp.view;
using Supermarket_mvp.Properties;

namespace Supermarket_mvp
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
            string sqlConnectString = Settings.Default.SqlConnection;
            IPayModeView view = new PayModeView();
            IPayModeRepository reposity = new PayModeRepository(sqlConnectString);
            Application.Run(new PayModeView());
        }
    }
}