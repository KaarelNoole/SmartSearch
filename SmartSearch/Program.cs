using System;
using System.Windows.Forms;
using VideoOS.Platform.SDK.UI.LoginDialog;

namespace SmartSearch
{
    static class Program
    {
        private static readonly Guid IntegrationId = new Guid("09061B21-D13E-478A-985A-B614B004FC30");
        private const string IntegrationName = "Smart Search";
        private const string Version = "1.0";
        private const string ManufacturerName = "Sample Manufacturer";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            VideoOS.Platform.SDK.Environment.Initialize();
            VideoOS.Platform.SDK.UI.Environment.Initialize();
            VideoOS.Platform.SDK.Export.Environment.Initialize();

            DialogLoginForm loginForm = new DialogLoginForm(SetLoginResult, IntegrationId, IntegrationName, Version, ManufacturerName);
            Application.Run(loginForm);
            if (Connected)
            {
                Application.Run(new MainForm());
            }

        }

        private static bool Connected = false;
        private static void SetLoginResult(bool connected)
        {
            Connected = connected;
        }

    }
}