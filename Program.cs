using Supermarket_mvp._repository;
using Supermarket_mvp.model;
using Supermarket_mvp.view;
using Supermarket_mvp.Properties;
using Supermarket_mvp.Presenters;

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
            IMainView view = new MainView();
            new MainPresenter(view, sqlConnectString);
            Application.Run((Form)view);
        }
    }
}