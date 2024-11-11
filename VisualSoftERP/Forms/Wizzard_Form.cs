using DevExpress.XtraEditors;
using DevExpress.XtraWizard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualSoftERP.Classes;
using VisualSoftERP.Classes.Utils;
using VisualSoftERP.Models;

namespace VisualSoftERP.Forms
{
    public partial class Wizzard_Form : DevExpress.XtraEditors.XtraForm
    {
        private bool firstInstalation = false;
        Company_Model company;

        public Wizzard_Form()
        {
            InitializeComponent();
        }
        
        private void Wizzard_Form_Load(object sender, EventArgs e)
        {
            LoadDrives();
        }

        private void LoadDrives()
        {
            try
            {
                DriveInfo[] allDrives = DriveInfo.GetDrives();
                foreach (DriveInfo d in allDrives)
                {
                    if (d.DriveType.ToString() == "Fixed" || d.DriveType.ToString() == "Network")
                        lBCDrive.Items.Add(d.Name);
                }
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }

        #region BUTTONS
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            try
            {
                string drive = lBCDrive.Text;
                xtraOpenFileDialog1.Filter = "Archivos (*.png)|*.png";
                xtraOpenFileDialog1.InitialDirectory = drive;
                xtraOpenFileDialog1.CheckFileExists = false;
                DialogResult result = xtraOpenFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtLogo.Text = xtraOpenFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        private void wizardControl_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            try
            {
                WizardControl wzControl = (WizardControl)sender;
                if (wzControl != null)
                {
                    if (wzControl.SelectedPage == wizardPageDirectories)
                    {
                        if (!ValidateDirection()) e.Handled = true;
                        if (!CompanyData()) e.Handled = true;
                    }
                    else if (wzControl.SelectedPage == wizardPageCompanyData)
                    {
                        if(!ValidateCompanyData()) e.Handled = true;    
                    }
                }
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        private void wizardControl_CancelClick(object sender, CancelEventArgs e)
        {
            try
            {
                WizardControl wzControl = (WizardControl)sender;
                if (wzControl != null)
                {
                    if (wzControl.SelectedPage != completionWizardPage)
                    {
                        DialogResult dialog = MessageBox.Show("¿Desea cancelar instalación?", "", MessageBoxButtons.OKCancel);
                        if (dialog == DialogResult.OK)
                        {
                            CancelInstallation();
                            Program_Class.TurnOff();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        private void wizardControl_HelpClick(object sender, WizardButtonClickEventArgs e)
        {
            string helpText = "Este instalador creará la ruta para el programa y los archivos necesarios.\nSiga los pasos para contiuar.";
            MessageBox.Show(helpText, "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void wizardControl_FinishClick(object sender, CancelEventArgs e)
        {
            if (!EnableSystem())
            {
                CancelInstallation();
                e.Cancel = true;
                return;
            }

            Login_Form login = new Login_Form();
            login.Show();
            this.Hide();
        }
        #endregion BUTTONS
        
        private bool ValidateCompanyData()
        {
            string result = "OK";
            if (txtCompanyName.Text.Length == 0)
                result = "Teclee el nombre de la empresa";
            
            if (txtCompanyRFC.Text.Length == 0)
                result = "Teclee el rfc de la empresa";
            
            if (txtCompanyAddress.Text.Length == 0)
                result = "Teclee la dirección de la empresa";
            
            if (txtCompanyPhone.Text.Length == 0)
                result = "Teclee el teléfono de la empresa";
            
            if (txtCompanyEmail.Text.Length == 0)
                result = "Teclee el correo de la empresa";
            
            if (txtCompanyPage.Text.Length == 0)
                result = "Teclee la página web de la empresa";

            if (txtLogo.Text.Length == 0)
                result = "Seleccione un archivo .png para usar como logotipo";
            
            if (!File.Exists(txtLogo.Text))
                result = "El archivo " + txtLogo.Text + " no existe";

            if (result != "OK")
            {
                MessageBox.Show(result);
                return false;
            }
            else return true;
        }
        
        private bool ValidateDirection()
        {
            string drive = lBCDrive.Text;
            string path = drive + "VisualSoftErp\\";
            if (Directory.Exists(path))
            {
                MessageBox.Show("El directorio " + path + " ya existe, por favor renombre o eliminelo antes de seguir");
                return false;
            }
            return true;
        }
        
        private bool CompanyData()
        {
            try
            {
                Wizzard_Class cl = new Wizzard_Class();
                company = cl.Read<Company_Model>("CompanyRead", null, new Dictionary<string, object> { });
                if (company.CompanyID > 0)
                {
                    txtCompanyName.Text = company.CompanyName;
                    txtCompanyRFC.Text = company.CompanyRFC;
                    txtCompanyAddress.Text = company.CompanyAddress;
                    txtCompanyPhone.Text = company.CompanyPhone;
                    txtCompanyEmail.Text = company.CompanyEmail;
                    txtCompanyPage.Text = company.CompanyPage;
                    txtCompanyName.Enabled = false;
                    txtCompanyRFC.Enabled = false;
                    txtCompanyAddress.Enabled = false;
                    txtCompanyPhone.Enabled = false;
                    txtCompanyEmail.Enabled = false;
                    txtCompanyPage.Enabled = false;

                    firstInstalation = false;
                }
                else
                    firstInstalation = true;
                return true;
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
                return false;
            }
        }
        
        private void CancelInstallation()
        {
            try
            {
                string path = "C:\\VisualSoftErp\\";
                
                if (Directory.Exists(path)) 
                    Directory.Delete(path, true);
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        
        private bool EnableSystem()
        {
            try
            {
                if (!CreateFolders()) { return false; }

                if (firstInstalation)
                {
                    Wizzard_Class controller = new Wizzard_Class();
                    company = Base_Model.Fill<Company_Model>(this.wizardPageCompanyData);
                    if (!controller.Crud("CompanyCrud", company, new Dictionary<string, object> { })) { return false; }
                    if (!controller.CreateFirstUser()) {  return false; }
                }
                return true;
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
                return false;
            }
        }
        
        private bool CreateFolders()
        {
            try
            {
                string drive = lBCDrive.Text;
                string path = drive + "VisualSoftErp\\";
                
                if (Directory.Exists(path))
                {
                    Modals_Class.ShowError("El directorio " + path + " ya existe, por favor renombre o eliminelo antes de seguir");
                    return false;
                }

                string subDir = path + "barcode";
                Directory.CreateDirectory(subDir);

                subDir = path + "Cotizaciones";
                Directory.CreateDirectory(subDir);

                subDir = path + "Images";
                Directory.CreateDirectory(subDir);

                subDir = path + "Layouts";
                Directory.CreateDirectory(subDir);

                subDir = path + "Pdf33";
                Directory.CreateDirectory(subDir);

                subDir = path + "Pref";
                Directory.CreateDirectory(subDir);

                subDir = path + "Sat";
                Directory.CreateDirectory(subDir);

                subDir = path + "Tcr33";
                Directory.CreateDirectory(subDir);

                subDir = path + "Xml33";
                Directory.CreateDirectory(subDir);

                subDir = path + "Xslt";
                Directory.CreateDirectory(subDir);

                string filedest = path + "Images\\logoEmpresa.png";
                File.Copy(txtLogo.Text, filedest);

                filedest = path + "Images\\SplashEmpresa.png";
                File.Copy(txtLogo.Text, filedest);

                return true;
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
                return false;
            }
        }

    }
}