using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualSoftERP.Forms;
using VisualSoftERP.Classes;
using VisualSoftERP.Classes.Utils;
using VisualSoftERP.Properties;
using VisualSoftERP.Forms.Tools.ProgramControl;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Utils.Extensions;
using VisualSoftERP.Forms.Chats;
using VisualSoftERP.Classes.Tools.ProgramControl;
using VisualSoftERP.Models;

namespace VisualSoftERP.Forms
{
    public partial class Menu_Form : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Menu_Form()
        {
            InitializeComponent();
        }


        #region USER INTERACTIONS
        private void Menu_Form_Load(object sender, EventArgs e)
        {
            try
            {
                UserLookAndFeel.Default.SkinName = Settings.Default["ApplicationSkinName"].ToString();
                Version version = Assembly.GetExecutingAssembly().GetName().Version;
                lblVersion.Caption = version.ToString();
                lblUserName.Caption = Program_Class.User.Name;
                lblCompanyName.Caption = Program_Class.Company.CompanyName;
                ribbonControl.SelectedPage = ribbonPageHome;
                LoadAlerts();
                Access();
                timer.Start();
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        private void Menu_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult Result = MessageBox.Show("¿Desea salir del sistema?", "Cerrar", MessageBoxButtons.YesNo);
                if (Result == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }

                Program_Class.User.IsOnline = 0;
                Users_Class cl = new Users_Class();
                cl.CrudNoMessage("UsersCrud", Program_Class.User, cl.parameters);
                Settings.Default["ApplicationSkinName"] = UserLookAndFeel.Default.SkinName;
                Settings.Default.Save();
                Dispose();
                System.Windows.Forms.Application.Exit();
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        private void Menu_Form_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                Program_Class.WindowHeight = this.Height;
                Program_Class.WindowWidth = this.Width;
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        private void ribbonControl_Merge(object sender, RibbonMergeEventArgs e)
        {
            e.MergeOwner.SelectedPage = e.MergeOwner.MergedPages["Acciones"];
        }
        private void ribbonControl_UnMerge(object sender, RibbonMergeEventArgs e)
        {
            e.MergeOwner.SelectedPage = Program_Class.RibbonPageSelected;
        }
        #endregion USER INTERACTIONS

        #region BUTTONS


        #region TOOLS
        private void bbiUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowDefaultWaitForm();
            Program_Class.RibbonPageSelected = ribbonPageTools;
            Users_Form form = new Users_Form();
            this.tabbedView.AddDocument(form);
        }
        private void bbiUserTypes_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowDefaultWaitForm();
            Program_Class.RibbonPageSelected = ribbonPageTools;
            UserTypes_Form form = new UserTypes_Form();
            this.tabbedView.AddDocument(form);
        }
        private void bbiPermissions_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowDefaultWaitForm();
            Program_Class.RibbonPageSelected = ribbonPageTools; 
            Permissions_Form form = new Permissions_Form();
            this.tabbedView.AddDocument(form);
        }
        private void bbiAccess_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowDefaultWaitForm();
            Program_Class.RibbonPageSelected = ribbonPageTools; 
            Access_Form form = new Access_Form();
            this.tabbedView.AddDocument(form);
        }
        private void bbiPrograms_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowDefaultWaitForm();
            Program_Class.RibbonPageSelected = ribbonPageTools;
            Programs_Form form = new Programs_Form();
            this.tabbedView.AddDocument(form);
        }
        #endregion TOOLS

        #region CHATS
        private void OpenChats_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowDefaultWaitForm();
            Chats_Form form = new Chats_Form();
            this.tabbedView.AddDocument(form);
        }
        #endregion CHATS
        #endregion BUTTONS


        private void LoadAlerts()
        {
            
        }

        private void Access()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
    }
}