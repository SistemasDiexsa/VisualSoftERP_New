using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using System.Data.SqlClient;
using VisualSoftERP.Classes.Utils;
using System.Windows.Forms;
using DevExpress.Xpo.DB;
using VisualSoftERP.Models;
using DevExpress.XtraBars.Ribbon;

namespace VisualSoftERP.Classes
{
    public class Program_Class
    {
        #region PROGRAM PROPERTIES 
        public static readonly byte[] connectionStringKey = ConfigurationManager.AppSettings["EncryptKeyConnectionString"].ToString() == string.Empty ? EncryptHelper_Class.GenerateKey("EncryptKeyConnectionString") : Convert.FromBase64String(ConfigurationManager.AppSettings["EncryptKeyConnectionString"]);
        public static readonly byte[] connectionStringIV = ConfigurationManager.AppSettings["EncryptIVConnectionString"].ToString() == string.Empty ? EncryptHelper_Class.GenerateIV("EncryptIVConnectionString") : Convert.FromBase64String(ConfigurationManager.AppSettings["EncryptIVConnectionString"]);
        
        public static readonly string strServer = ConfigurationManager.AppSettings["Server"].ToString();
        public static bool isConnectionStringCrypted = ConfigurationManager.AppSettings["isConnectionStringCrypted"].ToString() == "true" ? true : false;
        public static bool isInstalled = ConfigurationManager.AppSettings["isInstalled"].ToString() == "true" ? true : false;
        public static string cnnString = EncryptHelper_Class.DecryptConnectionString();
        #endregion PROGRAM PROPERTIES


        #region SESSION PROPERTIES
        public static Company_Model Company;
        public static Users_Model User;
        public static List<Permissions_Model> Permissions;
        public static int WindowWidth;
        public static int WindowHeight;
        public static RibbonPage RibbonPageSelected;
        #endregion SESSION PROPERTIES


        #region METHODS
        public static void TurnOff()
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TurnOff: " + ex.Message);
            }
        }

        public static bool EnsureInstallation()
        {
            try
            {
                if (!isInstalled)
                {
                    string path = ConfigurationManager.AppSettings["mainPath"].ToString();
                    if (Directory.Exists(path))
                        return true;
                    else
                        return false;
                }
                return isInstalled;
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
                return false;
            }
        }

        public static bool EnsureLogIn()
        {
            try
            {
                string user = string.Empty;
                string password = string.Empty;
                string data = string.Empty;
                string pathLayouts = ConfigurationManager.AppSettings["mainPath"].ToString() + "Layouts\\";

                if (File.Exists(pathLayouts + "login.txt"))
                {
                    data = System.IO.File.ReadAllText(@pathLayouts + "login.txt");
                    user = data.Substring(0, data.Length - 2);
                }

                if (File.Exists(pathLayouts + "login.txtps.txt"))
                {
                    data = System.IO.File.ReadAllText(@pathLayouts + "login.txtps.txt");
                    password = data.Substring(0, data.Length - 2);
                }

                Login_Class cl = new Login_Class();
                cl.parameters = new Dictionary<string, object>
                {
                    {"Login", user},
                    {"Password", password}
                };

                if (cl.UsersCheckLogIn())
                {
                    Company = cl.Read<Company_Model>("CompanyRead", null, new Dictionary<string, object> { });
                    User = cl.User;
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
                return false;
            }
        }

        #endregion METHODS

    }
}
