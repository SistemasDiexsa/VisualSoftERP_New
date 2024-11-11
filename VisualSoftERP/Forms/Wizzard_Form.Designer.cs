namespace VisualSoftERP.Forms
{
    partial class Wizzard_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wizzard_Form));
            this.wizardControl = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.wizardPageDirectories = new DevExpress.XtraWizard.WizardPage();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.lBCDrive = new DevExpress.XtraEditors.ListBoxControl();
            this.completionWizardPage = new DevExpress.XtraWizard.CompletionWizardPage();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.wizardPageCompanyData = new DevExpress.XtraWizard.WizardPage();
            this.txtLogo = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.btnAddFile = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtCompanyPage = new DevExpress.XtraEditors.TextEdit();
            this.txtCompanyEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtCompanyPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtCompanyRFC = new DevExpress.XtraEditors.TextEdit();
            this.txtCompanyAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtCompanyName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl)).BeginInit();
            this.wizardControl.SuspendLayout();
            this.welcomeWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.wizardPageDirectories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lBCDrive)).BeginInit();
            this.completionWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            this.wizardPageCompanyData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyPage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyRFC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl
            // 
            this.wizardControl.Controls.Add(this.welcomeWizardPage);
            this.wizardControl.Controls.Add(this.wizardPageDirectories);
            this.wizardControl.Controls.Add(this.completionWizardPage);
            this.wizardControl.Controls.Add(this.wizardPageCompanyData);
            this.wizardControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl.HelpVisible = true;
            this.wizardControl.Name = "wizardControl";
            this.wizardControl.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage,
            this.wizardPageDirectories,
            this.wizardPageCompanyData,
            this.completionWizardPage});
            this.wizardControl.Size = new System.Drawing.Size(677, 432);
            this.wizardControl.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControl_CancelClick);
            this.wizardControl.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl_FinishClick);
            this.wizardControl.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl_NextClick);
            this.wizardControl.HelpClick += new DevExpress.XtraWizard.WizardButtonClickEventHandler(this.wizardControl_HelpClick);
            // 
            // welcomeWizardPage
            // 
            this.welcomeWizardPage.Controls.Add(this.pictureEdit1);
            this.welcomeWizardPage.IntroductionText = "Este asistente lo guiará paso a paso para empezar a usar el sistema.";
            this.welcomeWizardPage.Name = "welcomeWizardPage";
            this.welcomeWizardPage.Size = new System.Drawing.Size(460, 300);
            this.welcomeWizardPage.Text = "Bienvenido al asistente de instalación";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::VisualSoftERP.Properties.Resources.VS_grande;
            this.pictureEdit1.Location = new System.Drawing.Point(302, 272);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(158, 28);
            this.pictureEdit1.TabIndex = 2;
            // 
            // wizardPageDirectories
            // 
            this.wizardPageDirectories.Controls.Add(this.pictureEdit2);
            this.wizardPageDirectories.Controls.Add(this.lBCDrive);
            this.wizardPageDirectories.DescriptionText = "La estructura de directorios del sistema será instalada en el drive. Si desea cam" +
    "biar el drive, seleccionelo de la lista.";
            this.wizardPageDirectories.Name = "wizardPageDirectories";
            this.wizardPageDirectories.Size = new System.Drawing.Size(645, 289);
            this.wizardPageDirectories.Text = "Crear Directorios";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = global::VisualSoftERP.Properties.Resources.VS_grande;
            this.pictureEdit2.Location = new System.Drawing.Point(487, 261);
            this.pictureEdit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(158, 28);
            this.pictureEdit2.TabIndex = 3;
            // 
            // lBCDrive
            // 
            this.lBCDrive.Location = new System.Drawing.Point(0, 3);
            this.lBCDrive.Name = "lBCDrive";
            this.lBCDrive.Size = new System.Drawing.Size(186, 283);
            this.lBCDrive.TabIndex = 0;
            // 
            // completionWizardPage
            // 
            this.completionWizardPage.Controls.Add(this.pictureEdit4);
            this.completionWizardPage.FinishText = "El asistente creará las carpetas necesarias y terminará la instalación";
            this.completionWizardPage.Name = "completionWizardPage";
            this.completionWizardPage.ProceedText = "Para continuar, pulse Finalizar";
            this.completionWizardPage.Size = new System.Drawing.Size(460, 300);
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = global::VisualSoftERP.Properties.Resources.VS_grande;
            this.pictureEdit4.Location = new System.Drawing.Point(302, 272);
            this.pictureEdit4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit4.Size = new System.Drawing.Size(158, 28);
            this.pictureEdit4.TabIndex = 40;
            // 
            // wizardPageCompanyData
            // 
            this.wizardPageCompanyData.Controls.Add(this.txtLogo);
            this.wizardPageCompanyData.Controls.Add(this.pictureEdit3);
            this.wizardPageCompanyData.Controls.Add(this.btnAddFile);
            this.wizardPageCompanyData.Controls.Add(this.labelControl13);
            this.wizardPageCompanyData.Controls.Add(this.txtCompanyPage);
            this.wizardPageCompanyData.Controls.Add(this.txtCompanyEmail);
            this.wizardPageCompanyData.Controls.Add(this.txtCompanyPhone);
            this.wizardPageCompanyData.Controls.Add(this.labelControl9);
            this.wizardPageCompanyData.Controls.Add(this.labelControl8);
            this.wizardPageCompanyData.Controls.Add(this.labelControl7);
            this.wizardPageCompanyData.Controls.Add(this.txtCompanyRFC);
            this.wizardPageCompanyData.Controls.Add(this.txtCompanyAddress);
            this.wizardPageCompanyData.Controls.Add(this.txtCompanyName);
            this.wizardPageCompanyData.Controls.Add(this.labelControl4);
            this.wizardPageCompanyData.Controls.Add(this.labelControl5);
            this.wizardPageCompanyData.Controls.Add(this.labelControl6);
            this.wizardPageCompanyData.DescriptionText = "Favor de llenar con los datos de su empresa.";
            this.wizardPageCompanyData.Name = "wizardPageCompanyData";
            this.wizardPageCompanyData.Size = new System.Drawing.Size(645, 289);
            this.wizardPageCompanyData.Text = "Datos de la Empresa";
            // 
            // txtLogo
            // 
            this.txtLogo.Enabled = false;
            this.txtLogo.EnterMoveNextControl = true;
            this.txtLogo.Location = new System.Drawing.Point(77, 190);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Properties.MaxLength = 14;
            this.txtLogo.Size = new System.Drawing.Size(288, 20);
            this.txtLogo.TabIndex = 37;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = global::VisualSoftERP.Properties.Resources.VS_grande;
            this.pictureEdit3.Location = new System.Drawing.Point(487, 261);
            this.pictureEdit3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(158, 28);
            this.pictureEdit3.TabIndex = 39;
            // 
            // btnAddFile
            // 
            this.btnAddFile.EditValue = ((object)(resources.GetObject("btnAddFile.EditValue")));
            this.btnAddFile.Location = new System.Drawing.Point(371, 185);
            this.btnAddFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.btnAddFile.Size = new System.Drawing.Size(40, 25);
            this.btnAddFile.TabIndex = 38;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(3, 193);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(41, 13);
            this.labelControl13.TabIndex = 36;
            this.labelControl13.Text = "Logotipo";
            // 
            // txtCompanyPage
            // 
            this.txtCompanyPage.EnterMoveNextControl = true;
            this.txtCompanyPage.Location = new System.Drawing.Point(77, 159);
            this.txtCompanyPage.Name = "txtCompanyPage";
            this.txtCompanyPage.Properties.MaxLength = 100;
            this.txtCompanyPage.Size = new System.Drawing.Size(509, 20);
            this.txtCompanyPage.TabIndex = 35;
            // 
            // txtCompanyEmail
            // 
            this.txtCompanyEmail.EnterMoveNextControl = true;
            this.txtCompanyEmail.Location = new System.Drawing.Point(77, 129);
            this.txtCompanyEmail.Name = "txtCompanyEmail";
            this.txtCompanyEmail.Properties.MaxLength = 100;
            this.txtCompanyEmail.Size = new System.Drawing.Size(509, 20);
            this.txtCompanyEmail.TabIndex = 34;
            // 
            // txtCompanyPhone
            // 
            this.txtCompanyPhone.EnterMoveNextControl = true;
            this.txtCompanyPhone.Location = new System.Drawing.Point(77, 100);
            this.txtCompanyPhone.Name = "txtCompanyPhone";
            this.txtCompanyPhone.Properties.MaxLength = 50;
            this.txtCompanyPhone.Size = new System.Drawing.Size(509, 20);
            this.txtCompanyPhone.TabIndex = 33;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(3, 161);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(55, 13);
            this.labelControl9.TabIndex = 32;
            this.labelControl9.Text = "Página web";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(3, 132);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(33, 13);
            this.labelControl8.TabIndex = 31;
            this.labelControl8.Text = "Correo";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(3, 102);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(42, 13);
            this.labelControl7.TabIndex = 30;
            this.labelControl7.Text = "Teléfono";
            // 
            // txtCompanyRFC
            // 
            this.txtCompanyRFC.EnterMoveNextControl = true;
            this.txtCompanyRFC.Location = new System.Drawing.Point(77, 36);
            this.txtCompanyRFC.Name = "txtCompanyRFC";
            this.txtCompanyRFC.Properties.MaxLength = 14;
            this.txtCompanyRFC.Size = new System.Drawing.Size(187, 20);
            this.txtCompanyRFC.TabIndex = 26;
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.EnterMoveNextControl = true;
            this.txtCompanyAddress.Location = new System.Drawing.Point(77, 68);
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.Properties.MaxLength = 100;
            this.txtCompanyAddress.Size = new System.Drawing.Size(509, 20);
            this.txtCompanyAddress.TabIndex = 27;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.EnterMoveNextControl = true;
            this.txtCompanyName.Location = new System.Drawing.Point(77, 3);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Properties.MaxLength = 100;
            this.txtCompanyName.Size = new System.Drawing.Size(509, 20);
            this.txtCompanyName.TabIndex = 24;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(3, 70);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 13);
            this.labelControl4.TabIndex = 29;
            this.labelControl4.Text = "Dirección";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(3, 7);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 13);
            this.labelControl5.TabIndex = 28;
            this.labelControl5.Text = "Nombre";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(3, 38);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(16, 13);
            this.labelControl6.TabIndex = 25;
            this.labelControl6.Text = "Rfc";
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // Wizzard_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 432);
            this.Controls.Add(this.wizardControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Wizzard_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instalador VisualSoftERP";
            this.Load += new System.EventHandler(this.Wizzard_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl)).EndInit();
            this.wizardControl.ResumeLayout(false);
            this.welcomeWizardPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.wizardPageDirectories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lBCDrive)).EndInit();
            this.completionWizardPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            this.wizardPageCompanyData.ResumeLayout(false);
            this.wizardPageCompanyData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyPage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyRFC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage;
        private DevExpress.XtraWizard.WizardPage wizardPageDirectories;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.ListBoxControl lBCDrive;
        private DevExpress.XtraWizard.WizardPage wizardPageCompanyData;
        private DevExpress.XtraEditors.PictureEdit btnAddFile;
        private DevExpress.XtraEditors.TextEdit txtLogo;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtCompanyPage;
        private DevExpress.XtraEditors.TextEdit txtCompanyEmail;
        private DevExpress.XtraEditors.TextEdit txtCompanyPhone;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtCompanyRFC;
        private DevExpress.XtraEditors.TextEdit txtCompanyAddress;
        private DevExpress.XtraEditors.TextEdit txtCompanyName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
    }
}