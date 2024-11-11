namespace VisualSoftERP.Forms
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.imgLogo = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiLogIn = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barHeaderVersion = new DevExpress.XtraBars.BarHeaderItem();
            this.lblSoftwareName = new DevExpress.XtraBars.BarStaticItem();
            this.lblVersion = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.swPassword = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.popupContainerControl = new DevExpress.XtraEditors.PopupContainerControl();
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.btnAceptarDBPruebas = new DevExpress.XtraEditors.SimpleButton();
            this.btnCerrarPopUp = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.swIsRemembering = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl)).BeginInit();
            this.popupContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swIsRemembering.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.EditValue = global::VisualSoftERP.Properties.Resources.VS_grande;
            this.imgLogo.Location = new System.Drawing.Point(356, 278);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.imgLogo.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.imgLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.imgLogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.imgLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.imgLogo.Size = new System.Drawing.Size(101, 20);
            this.imgLogo.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(43, 179);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Usuario";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 209);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Contraseña";
            // 
            // txtLogin
            // 
            this.txtLogin.EnterMoveNextControl = true;
            this.txtLogin.Location = new System.Drawing.Point(103, 172);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLogin.MenuManager = this.ribbonControl1;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtLogin.Properties.Appearance.Options.UseFont = true;
            this.txtLogin.Properties.MaxLength = 50;
            this.txtLogin.Size = new System.Drawing.Size(354, 26);
            this.txtLogin.TabIndex = 5;
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26, 24, 26, 24);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiClose,
            this.bbiLogIn,
            this.barHeaderItem1,
            this.barHeaderVersion,
            this.lblSoftwareName,
            this.lblVersion});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 283;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowItemCaptionsInQAT = true;
            this.ribbonControl1.Size = new System.Drawing.Size(482, 140);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Cerrar";
            this.bbiClose.Id = 1;
            this.bbiClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiClose.ImageOptions.SvgImage")));
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiClose_ItemClick);
            // 
            // bbiLogIn
            // 
            this.bbiLogIn.Caption = "Entrar";
            this.bbiLogIn.Id = 2;
            this.bbiLogIn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiLogIn.ImageOptions.SvgImage")));
            this.bbiLogIn.Name = "bbiLogIn";
            this.bbiLogIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiLogIn_ItemClick);
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "VisualSoft Erp .Net";
            this.barHeaderItem1.Id = 3;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barHeaderVersion
            // 
            this.barHeaderVersion.Caption = "barHeaderItem2";
            this.barHeaderVersion.Id = 4;
            this.barHeaderVersion.Name = "barHeaderVersion";
            // 
            // lblSoftwareName
            // 
            this.lblSoftwareName.Caption = "VisualSoftERP";
            this.lblSoftwareName.Id = 5;
            this.lblSoftwareName.Name = "lblSoftwareName";
            // 
            // lblVersion
            // 
            this.lblVersion.Caption = "Software Version";
            this.lblVersion.Id = 6;
            this.lblVersion.Name = "lblVersion";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Inicio";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiClose);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiLogIn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Acciones";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.lblSoftwareName);
            this.ribbonStatusBar1.ItemLinks.Add(this.lblVersion);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 320);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(482, 28);
            // 
            // txtPassword
            // 
            this.txtPassword.EnterMoveNextControl = true;
            this.txtPassword.Location = new System.Drawing.Point(103, 202);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.MenuManager = this.ribbonControl1;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.MaxLength = 50;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(354, 26);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // swPassword
            // 
            this.swPassword.Location = new System.Drawing.Point(103, 232);
            this.swPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swPassword.MenuManager = this.ribbonControl1;
            this.swPassword.Name = "swPassword";
            this.swPassword.Properties.OffText = "No";
            this.swPassword.Properties.OnText = "Sí";
            this.swPassword.Size = new System.Drawing.Size(87, 24);
            this.swPassword.TabIndex = 8;
            this.swPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.swPassword_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(4, 237);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(93, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Recordar password";
            // 
            // popupContainerControl
            // 
            this.popupContainerControl.Controls.Add(this.groupControl);
            this.popupContainerControl.Location = new System.Drawing.Point(124, 144);
            this.popupContainerControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.popupContainerControl.Name = "popupContainerControl";
            this.popupContainerControl.Size = new System.Drawing.Size(260, 123);
            this.popupContainerControl.TabIndex = 15;
            // 
            // groupControl
            // 
            this.groupControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl.Controls.Add(this.btnAceptarDBPruebas);
            this.groupControl.Controls.Add(this.btnCerrarPopUp);
            this.groupControl.Controls.Add(this.labelControl4);
            this.groupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl.Location = new System.Drawing.Point(0, 0);
            this.groupControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(260, 123);
            this.groupControl.TabIndex = 0;
            this.groupControl.Text = "Aviso!";
            // 
            // btnAceptarDBPruebas
            // 
            this.btnAceptarDBPruebas.Location = new System.Drawing.Point(53, 95);
            this.btnAceptarDBPruebas.Name = "btnAceptarDBPruebas";
            this.btnAceptarDBPruebas.Size = new System.Drawing.Size(116, 23);
            this.btnAceptarDBPruebas.TabIndex = 2;
            this.btnAceptarDBPruebas.Text = "Seguir en Pruebas";
            this.btnAceptarDBPruebas.Click += new System.EventHandler(this.btnAceptDBTest_Click);
            // 
            // btnCerrarPopUp
            // 
            this.btnCerrarPopUp.Location = new System.Drawing.Point(175, 95);
            this.btnCerrarPopUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarPopUp.Name = "btnCerrarPopUp";
            this.btnCerrarPopUp.Size = new System.Drawing.Size(81, 24);
            this.btnCerrarPopUp.TabIndex = 1;
            this.btnCerrarPopUp.Text = "Cerrar";
            this.btnCerrarPopUp.Click += new System.EventHandler(this.btnClosePopUp_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(17, 46);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(215, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "¡Está en modo de pruebas, avise a sistemas!";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(244, 237);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(120, 13);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "Mantener Sesión Iniciada";
            // 
            // swIsRemembering
            // 
            this.swIsRemembering.Location = new System.Drawing.Point(370, 232);
            this.swIsRemembering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swIsRemembering.MenuManager = this.ribbonControl1;
            this.swIsRemembering.Name = "swIsRemembering";
            this.swIsRemembering.Properties.OffText = "No";
            this.swIsRemembering.Properties.OnText = "Sí";
            this.swIsRemembering.Size = new System.Drawing.Size(87, 24);
            this.swIsRemembering.TabIndex = 20;
            this.swIsRemembering.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.swIsRemembering_KeyPress);
            // 
            // Login_Form
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 348);
            this.Controls.Add(this.popupContainerControl);
            this.Controls.Add(this.swIsRemembering);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.swPassword);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.imgLogo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl)).EndInit();
            this.popupContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            this.groupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swIsRemembering.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit imgLogo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraEditors.ToggleSwitch swPassword;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PopupContainerControl popupContainerControl;
        private DevExpress.XtraEditors.GroupControl groupControl;
        private DevExpress.XtraEditors.SimpleButton btnCerrarPopUp;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraBars.BarButtonItem bbiLogIn;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderVersion;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarStaticItem lblSoftwareName;
        private DevExpress.XtraBars.BarStaticItem lblVersion;
        private DevExpress.XtraEditors.SimpleButton btnAceptarDBPruebas;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ToggleSwitch swIsRemembering;
    }
}