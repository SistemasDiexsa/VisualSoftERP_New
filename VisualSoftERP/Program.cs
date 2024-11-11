using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using VisualSoftERP.Classes;
using VisualSoftERP.Classes.Utils;
using VisualSoftERP.Forms;
using VisualSoftERP.Properties;

namespace VisualSoftERP
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += Logger.HandleUnhandledException;
            Application.ThreadException += Logger.HandleThreadException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UserLookAndFeel.Default.SkinName = Settings.Default["ApplicationSkinName"].ToString();
            BonusSkins.Register();
            EncryptHelper_Class.EncryptConnectionString();

            if (!Program_Class.EnsureInstallation())
                Application.Run(new Wizzard_Form());
            else
            {
                if (!Program_Class.EnsureLogIn())
                    Application.Run(new Login_Form());
                else
                    Application.Run(new Menu_Form());
            }
        }
    }

    public static class Logger
    {
        public static void HandleUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            LogException(ex);
            Modals_Class.ShowError(ex);
            Program_Class.TurnOff();

        }

        public static void HandleThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Exception ex = e.Exception;
            LogException(ex);
            Modals_Class.ShowError(ex);
            Program_Class.TurnOff();
        }

        // SAVES THE ERROR AND STACK TRACE ON LOG FILE
        private static void LogException(Exception ex)
        {
            try
            {
                System.Text.StringBuilder msg = new System.Text.StringBuilder();
                msg.AppendLine("Exception Type: " + ex.GetType().FullName);
                msg.AppendLine("Message: " + ex.Message);
                msg.AppendLine("Stack Trace: " + ex.StackTrace);
                msg.AppendLine();
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string logFilePath = Path.Combine(desktopPath, "ExceptionsVisualSoftErp.txt");
                System.IO.File.AppendAllText(logFilePath, msg.ToString());
            }
            catch (Exception exception)
            {
                Modals_Class.ShowError(exception);
                Program_Class.TurnOff();
            }
        }
    }
}
