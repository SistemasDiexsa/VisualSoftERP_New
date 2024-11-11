namespace VisualSoftERP.Forms.Chats
{
    partial class Chats_Form
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.navBarControlOnlineUsers = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroupOnlineUsers = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemNoOnlineUsers = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemAllUsers = new DevExpress.XtraNavBar.NavBarItem();
            this.panelControlMessageControl = new DevExpress.XtraEditors.PanelControl();
            this.txtMessage = new DevExpress.XtraEditors.MemoEdit();
            this.btnSend = new DevExpress.XtraEditors.SimpleButton();
            this.panelControlChat = new DevExpress.XtraEditors.PanelControl();
            this.listBoxControlMessages = new DevExpress.XtraEditors.ListBoxControl();
            this.timerChats = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlOnlineUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMessageControl)).BeginInit();
            this.panelControlMessageControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlChat)).BeginInit();
            this.panelControlChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.Size = new System.Drawing.Size(1273, 54);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 602);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1273, 23);
            // 
            // navBarControlOnlineUsers
            // 
            this.navBarControlOnlineUsers.ActiveGroup = this.navBarGroupOnlineUsers;
            this.navBarControlOnlineUsers.Dock = System.Windows.Forms.DockStyle.Right;
            this.navBarControlOnlineUsers.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroupOnlineUsers});
            this.navBarControlOnlineUsers.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemNoOnlineUsers,
            this.navBarItemAllUsers});
            this.navBarControlOnlineUsers.Location = new System.Drawing.Point(1083, 54);
            this.navBarControlOnlineUsers.Name = "navBarControlOnlineUsers";
            this.navBarControlOnlineUsers.OptionsNavPane.ExpandedWidth = 190;
            this.navBarControlOnlineUsers.Size = new System.Drawing.Size(190, 548);
            this.navBarControlOnlineUsers.TabIndex = 2;
            this.navBarControlOnlineUsers.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarControlOnlineUsers_LinkClicked);
            // 
            // navBarGroupOnlineUsers
            // 
            this.navBarGroupOnlineUsers.Caption = "Usuarios en Línea";
            this.navBarGroupOnlineUsers.Expanded = true;
            this.navBarGroupOnlineUsers.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemNoOnlineUsers),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemAllUsers)});
            this.navBarGroupOnlineUsers.Name = "navBarGroupOnlineUsers";
            // 
            // navBarItemNoOnlineUsers
            // 
            this.navBarItemNoOnlineUsers.Caption = "Sin Usuarios En Línea";
            this.navBarItemNoOnlineUsers.Name = "navBarItemNoOnlineUsers";
            this.navBarItemNoOnlineUsers.Visible = false;
            // 
            // navBarItemAllUsers
            // 
            this.navBarItemAllUsers.Caption = "Todos";
            this.navBarItemAllUsers.Name = "navBarItemAllUsers";
            this.navBarItemAllUsers.Visible = false;
            // 
            // panelControlMessageControl
            // 
            this.panelControlMessageControl.Controls.Add(this.txtMessage);
            this.panelControlMessageControl.Controls.Add(this.btnSend);
            this.panelControlMessageControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlMessageControl.Location = new System.Drawing.Point(2, 452);
            this.panelControlMessageControl.Name = "panelControlMessageControl";
            this.panelControlMessageControl.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.panelControlMessageControl.Size = new System.Drawing.Size(1079, 94);
            this.panelControlMessageControl.TabIndex = 1;
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Location = new System.Drawing.Point(12, 22);
            this.txtMessage.MenuManager = this.ribbon;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(980, 50);
            this.txtMessage.TabIndex = 2;
            this.txtMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMessage_KeyPress);
            // 
            // btnSend
            // 
            this.btnSend.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Appearance.Options.UseFont = true;
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSend.Location = new System.Drawing.Point(992, 22);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 50);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Enviar";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // panelControlChat
            // 
            this.panelControlChat.Controls.Add(this.listBoxControlMessages);
            this.panelControlChat.Controls.Add(this.panelControlMessageControl);
            this.panelControlChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlChat.Location = new System.Drawing.Point(0, 54);
            this.panelControlChat.Name = "panelControlChat";
            this.panelControlChat.Size = new System.Drawing.Size(1083, 548);
            this.panelControlChat.TabIndex = 6;
            // 
            // listBoxControlMessages
            // 
            this.listBoxControlMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControlMessages.Location = new System.Drawing.Point(2, 2);
            this.listBoxControlMessages.Name = "listBoxControlMessages";
            this.listBoxControlMessages.Size = new System.Drawing.Size(1079, 450);
            this.listBoxControlMessages.TabIndex = 7;
            // 
            // timerChats
            // 
            this.timerChats.Interval = 1000;
            this.timerChats.Tick += new System.EventHandler(this.timerChats_Tick);
            // 
            // Chats_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 625);
            this.Controls.Add(this.panelControlChat);
            this.Controls.Add(this.navBarControlOnlineUsers);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "Chats_Form";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Chats";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chats_Form_FormClosing);
            this.Load += new System.EventHandler(this.Chats_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlOnlineUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMessageControl)).EndInit();
            this.panelControlMessageControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlChat)).EndInit();
            this.panelControlChat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlMessages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraNavBar.NavBarControl navBarControlOnlineUsers;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupOnlineUsers;
        private DevExpress.XtraEditors.PanelControl panelControlMessageControl;
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private DevExpress.XtraEditors.PanelControl panelControlChat;
        private DevExpress.XtraEditors.ListBoxControl listBoxControlMessages;
        private DevExpress.XtraNavBar.NavBarItem navBarItemNoOnlineUsers;
        private DevExpress.XtraNavBar.NavBarItem navBarItemAllUsers;
        private DevExpress.XtraEditors.MemoEdit txtMessage;
        private System.Windows.Forms.Timer timerChats;
    }
}