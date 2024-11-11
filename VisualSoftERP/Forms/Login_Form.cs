using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using VisualSoftERP.Classes;
using VisualSoftERP.Classes.Utils;
using VisualSoftERP.Models;

namespace VisualSoftERP.Forms
{
    public partial class Login_Form : DevExpress.XtraEditors.XtraForm
    {
        public Login_Form()
        {
            InitializeComponent();
        }


        #region USER INTERACTIONS
        private void Login_Form_Load(object sender, EventArgs e)
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            lblVersion.Caption = version.ToString();

            if (Program_Class.strServer != "Production")
                popupContainerControl.Show();
        }
        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) txtPassword.Focus();
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) LogIn();
        }
        private void swPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) LogIn();
        }
        private void swIsRemembering_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) LogIn();
        }
        #endregion USER INTERACTIONS


        #region BUTTONS
        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void bbiLogIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LogIn();
        }
        private void btnClosePopUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAceptDBTest_Click(object sender, EventArgs e)
        {
            popupContainerControl.Hide();
        }
        #endregion BUTTONS


        private void LogIn()
        {
            try
            {
                if (txtLogin.Text.Length == 0 || txtPassword.Text.Length == 0)
                    throw new Exception("Teclee el login y password");

                Login_Class cl = new Login_Class();
                cl.parameters = new Dictionary<string, object>
                {
                    {"Login", txtLogin.Text},
                    {"Password", txtPassword.Text},
                    {"IsRemembering", swIsRemembering.IsOn == true ? 1 : 0 }
                };

                Company_Model company = cl.Read<Company_Model>("CompanyRead", null, new Dictionary<string, object> { });

                if (cl.LogIn())
                {
                    SaveLogIn();
                    Program_Class.User = cl.User;
                    Program_Class.Company = company;

                    Menu_Form frame = new Menu_Form();
                    frame.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }

        private void SaveLogIn()
        {
            try
            {
                string pathPassword = string.Empty;
                string pathLayouts = ConfigurationManager.AppSettings["mainPath"].ToString() + "Layouts\\";

                using (StreamWriter writer = new StreamWriter(pathLayouts + "login.txt"))
                {
                    writer.WriteLine(txtLogin.Text);
                }

                if (swPassword.IsOn)
                {
                    using (StreamWriter writer = new StreamWriter(pathLayouts + "login.txtps.txt"))
                    {
                        writer.WriteLine(txtPassword.Text);
                    }
                }
                else
                {
                    if (File.Exists(pathLayouts + "login.txtps.txt"))
                        File.Delete(pathLayouts + "login.txtps.txt");
                }
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
    }
}