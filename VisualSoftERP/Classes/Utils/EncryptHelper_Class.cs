using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VisualSoftERP.Classes.Utils
{
    public class EncryptHelper_Class
    {
        #region METHODS
        public static byte[] GenerateKey(string appSettingsKey)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var key = new byte[32];
                rng.GetBytes(key);
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings[appSettingsKey].Value = Convert.ToBase64String(key);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                return key;
            }
        }

        public static byte[] GenerateIV(string appSettingsKey)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var iv = new byte[16];
                rng.GetBytes(iv);
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings[appSettingsKey].Value = Convert.ToBase64String(iv);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                return iv;
            }
        }

        public static void EncryptConnectionString()
        {
            try
            {
                if (!Program_Class.isConnectionStringCrypted)
                {
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var section = (ConnectionStringsSection)config.GetSection("connectionStrings");
                    foreach (ConnectionStringSettings connectionString in section.ConnectionStrings)
                    {
                        var rawConnectionString = connectionString.ConnectionString;
                        string encryptedConnectionString = string.Empty;
                        using (var aes = Aes.Create())
                        {
                            aes.Key = Program_Class.connectionStringKey;
                            aes.IV = Program_Class.connectionStringIV;

                            using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                            {
                                var buffer = Encoding.UTF8.GetBytes(rawConnectionString);
                                encryptedConnectionString = Convert.ToBase64String(encryptor.TransformFinalBlock(buffer, 0, buffer.Length));
                            }
                        }
                        connectionString.ConnectionString = encryptedConnectionString;
                    }
                    config.Save(ConfigurationSaveMode.Modified);
                    var appconfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    appconfig.AppSettings.Settings["isConnectionStringCrypted"].Value = "true";
                    appconfig.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                    Program_Class.isConnectionStringCrypted = true;
                    Program_Class.cnnString = EncryptHelper_Class.DecryptConnectionString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.Message);
            }
        }

        public static string DecryptConnectionString()
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var section = (ConnectionStringsSection)config.GetSection("connectionStrings");
                var encryptedConnectionString = section.ConnectionStrings[Program_Class.strServer]?.ConnectionString;
                using (var aes = Aes.Create())
                {
                    aes.Key = Program_Class.connectionStringKey;
                    aes.IV = Program_Class.connectionStringIV;
                    using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                    {
                        var buffer = Convert.FromBase64String(encryptedConnectionString);
                        return Encoding.UTF8.GetString(decryptor.TransformFinalBlock(buffer, 0, buffer.Length));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return string.Empty;
            }
        }
        #endregion METHODS
    }
}
