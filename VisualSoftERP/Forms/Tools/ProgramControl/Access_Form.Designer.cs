namespace VisualSoftERP.Forms.Tools.ProgramControl
{
    partial class Access_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Access_Form));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiCreate = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRead = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReturn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageActions = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupActions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroupOptions = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemAccessByUsers = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemAccessByPrograms = new DevExpress.XtraNavBar.NavBarItem();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPageAccessByUsers = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tablePanelAccessByUsers = new DevExpress.Utils.Layout.TablePanel();
            this.gridControlAccessByUsers = new DevExpress.XtraGrid.GridControl();
            this.gridViewAccessByUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblByUsers = new DevExpress.XtraEditors.LabelControl();
            this.cboUsers = new DevExpress.XtraEditors.LookUpEdit();
            this.navigationPageAccessByPrograms = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tablePanelAccessByPrograms = new DevExpress.Utils.Layout.TablePanel();
            this.gridControlAccessByPrograms = new DevExpress.XtraGrid.GridControl();
            this.gridViewAccessByPrograms = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboPrograms = new DevExpress.XtraEditors.LookUpEdit();
            this.lblByPrograms = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl.Panel1)).BeginInit();
            this.splitContainerControl.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl.Panel2)).BeginInit();
            this.splitContainerControl.Panel2.SuspendLayout();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.navigationPageAccessByUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelAccessByUsers)).BeginInit();
            this.tablePanelAccessByUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAccessByUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccessByUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUsers.Properties)).BeginInit();
            this.navigationPageAccessByPrograms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelAccessByPrograms)).BeginInit();
            this.tablePanelAccessByPrograms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAccessByPrograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccessByPrograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPrograms.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.bbiCreate,
            this.bbiRead,
            this.bbiUpdate,
            this.bbiDelete,
            this.bbiReturn});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageActions});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.Size = new System.Drawing.Size(959, 147);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiCreate
            // 
            this.bbiCreate.Caption = "Nuevo";
            this.bbiCreate.Enabled = false;
            this.bbiCreate.Id = 1;
            this.bbiCreate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiCreate.ImageOptions.SvgImage")));
            this.bbiCreate.Name = "bbiCreate";
            // 
            // bbiRead
            // 
            this.bbiRead.Caption = "Ver";
            this.bbiRead.Enabled = false;
            this.bbiRead.Id = 2;
            this.bbiRead.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiRead.ImageOptions.SvgImage")));
            this.bbiRead.Name = "bbiRead";
            // 
            // bbiUpdate
            // 
            this.bbiUpdate.Caption = "Guardar";
            this.bbiUpdate.Enabled = false;
            this.bbiUpdate.Id = 3;
            this.bbiUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiUpdate.ImageOptions.SvgImage")));
            this.bbiUpdate.Name = "bbiUpdate";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Eliminar";
            this.bbiDelete.Enabled = false;
            this.bbiDelete.Id = 4;
            this.bbiDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiDelete.ImageOptions.SvgImage")));
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiReturn
            // 
            this.bbiReturn.Caption = "Regresar";
            this.bbiReturn.Enabled = false;
            this.bbiReturn.Id = 5;
            this.bbiReturn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiReturn.ImageOptions.SvgImage")));
            this.bbiReturn.Name = "bbiReturn";
            // 
            // ribbonPageActions
            // 
            this.ribbonPageActions.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupActions});
            this.ribbonPageActions.Name = "ribbonPageActions";
            this.ribbonPageActions.Text = "Acciones";
            // 
            // ribbonPageGroupActions
            // 
            this.ribbonPageGroupActions.ItemLinks.Add(this.bbiCreate);
            this.ribbonPageGroupActions.ItemLinks.Add(this.bbiRead);
            this.ribbonPageGroupActions.ItemLinks.Add(this.bbiUpdate);
            this.ribbonPageGroupActions.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroupActions.ItemLinks.Add(this.bbiReturn);
            this.ribbonPageGroupActions.Name = "ribbonPageGroupActions";
            this.ribbonPageGroupActions.Text = "Acciones";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 608);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(959, 23);
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.IsSplitterFixed = true;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 147);
            this.splitContainerControl.Name = "splitContainerControl";
            // 
            // splitContainerControl.Panel1
            // 
            this.splitContainerControl.Panel1.Controls.Add(this.navBarControl);
            this.splitContainerControl.Panel1.Text = "Panel1";
            // 
            // splitContainerControl.Panel2
            // 
            this.splitContainerControl.Panel2.Controls.Add(this.navigationFrame);
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.Size = new System.Drawing.Size(959, 461);
            this.splitContainerControl.SplitterPosition = 145;
            this.splitContainerControl.TabIndex = 2;
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.navBarGroupOptions;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroupOptions});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemAccessByUsers,
            this.navBarItemAccessByPrograms});
            this.navBarControl.Location = new System.Drawing.Point(0, 0);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 145;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl.Size = new System.Drawing.Size(145, 461);
            this.navBarControl.TabIndex = 0;
            this.navBarControl.Text = "Opciones";
            this.navBarControl.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarControl_LinkClicked);
            // 
            // navBarGroupOptions
            // 
            this.navBarGroupOptions.Caption = "Opciones";
            this.navBarGroupOptions.Expanded = true;
            this.navBarGroupOptions.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemAccessByUsers),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemAccessByPrograms)});
            this.navBarGroupOptions.Name = "navBarGroupOptions";
            // 
            // navBarItemAccessByUsers
            // 
            this.navBarItemAccessByUsers.Caption = "Accesos por Usuario";
            this.navBarItemAccessByUsers.Name = "navBarItemAccessByUsers";
            // 
            // navBarItemAccessByPrograms
            // 
            this.navBarItemAccessByPrograms.Caption = "Accesos por Programa";
            this.navBarItemAccessByPrograms.Name = "navBarItemAccessByPrograms";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.navigationPageAccessByUsers);
            this.navigationFrame.Controls.Add(this.navigationPageAccessByPrograms);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 0);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPageAccessByUsers,
            this.navigationPageAccessByPrograms});
            this.navigationFrame.SelectedPage = this.navigationPageAccessByUsers;
            this.navigationFrame.Size = new System.Drawing.Size(802, 461);
            this.navigationFrame.TabIndex = 0;
            // 
            // navigationPageAccessByUsers
            // 
            this.navigationPageAccessByUsers.Controls.Add(this.tablePanelAccessByUsers);
            this.navigationPageAccessByUsers.Name = "navigationPageAccessByUsers";
            this.navigationPageAccessByUsers.Size = new System.Drawing.Size(802, 461);
            // 
            // tablePanelAccessByUsers
            // 
            this.tablePanelAccessByUsers.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanelAccessByUsers.Controls.Add(this.gridControlAccessByUsers);
            this.tablePanelAccessByUsers.Controls.Add(this.lblByUsers);
            this.tablePanelAccessByUsers.Controls.Add(this.cboUsers);
            this.tablePanelAccessByUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelAccessByUsers.Location = new System.Drawing.Point(0, 0);
            this.tablePanelAccessByUsers.Name = "tablePanelAccessByUsers";
            this.tablePanelAccessByUsers.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 60F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.tablePanelAccessByUsers.Size = new System.Drawing.Size(802, 461);
            this.tablePanelAccessByUsers.TabIndex = 0;
            // 
            // gridControlAccessByUsers
            // 
            this.tablePanelAccessByUsers.SetColumn(this.gridControlAccessByUsers, 0);
            this.gridControlAccessByUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAccessByUsers.Location = new System.Drawing.Point(3, 63);
            this.gridControlAccessByUsers.MainView = this.gridViewAccessByUsers;
            this.gridControlAccessByUsers.MenuManager = this.ribbon;
            this.gridControlAccessByUsers.Name = "gridControlAccessByUsers";
            this.tablePanelAccessByUsers.SetRow(this.gridControlAccessByUsers, 1);
            this.gridControlAccessByUsers.Size = new System.Drawing.Size(796, 395);
            this.gridControlAccessByUsers.TabIndex = 2;
            this.gridControlAccessByUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAccessByUsers});
            // 
            // gridViewAccessByUsers
            // 
            this.gridViewAccessByUsers.GridControl = this.gridControlAccessByUsers;
            this.gridViewAccessByUsers.Name = "gridViewAccessByUsers";
            // 
            // lblByUsers
            // 
            this.tablePanelAccessByUsers.SetColumn(this.lblByUsers, 0);
            this.lblByUsers.Location = new System.Drawing.Point(20, 23);
            this.lblByUsers.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.lblByUsers.Name = "lblByUsers";
            this.tablePanelAccessByUsers.SetRow(this.lblByUsers, 0);
            this.lblByUsers.Size = new System.Drawing.Size(36, 13);
            this.lblByUsers.TabIndex = 0;
            this.lblByUsers.Text = "Usuario";
            // 
            // cboUsers
            // 
            this.cboUsers.Location = new System.Drawing.Point(107, 21);
            this.cboUsers.MenuManager = this.ribbon;
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboUsers.Size = new System.Drawing.Size(659, 20);
            this.cboUsers.TabIndex = 1;
            // 
            // navigationPageAccessByPrograms
            // 
            this.navigationPageAccessByPrograms.Controls.Add(this.tablePanelAccessByPrograms);
            this.navigationPageAccessByPrograms.Name = "navigationPageAccessByPrograms";
            this.navigationPageAccessByPrograms.Size = new System.Drawing.Size(802, 461);
            // 
            // tablePanelAccessByPrograms
            // 
            this.tablePanelAccessByPrograms.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanelAccessByPrograms.Controls.Add(this.gridControlAccessByPrograms);
            this.tablePanelAccessByPrograms.Controls.Add(this.cboPrograms);
            this.tablePanelAccessByPrograms.Controls.Add(this.lblByPrograms);
            this.tablePanelAccessByPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelAccessByPrograms.Location = new System.Drawing.Point(0, 0);
            this.tablePanelAccessByPrograms.Name = "tablePanelAccessByPrograms";
            this.tablePanelAccessByPrograms.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 60F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.tablePanelAccessByPrograms.Size = new System.Drawing.Size(802, 461);
            this.tablePanelAccessByPrograms.TabIndex = 0;
            // 
            // gridControlAccessByPrograms
            // 
            this.tablePanelAccessByPrograms.SetColumn(this.gridControlAccessByPrograms, 0);
            this.gridControlAccessByPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAccessByPrograms.Location = new System.Drawing.Point(3, 63);
            this.gridControlAccessByPrograms.MainView = this.gridViewAccessByPrograms;
            this.gridControlAccessByPrograms.MenuManager = this.ribbon;
            this.gridControlAccessByPrograms.Name = "gridControlAccessByPrograms";
            this.tablePanelAccessByPrograms.SetRow(this.gridControlAccessByPrograms, 1);
            this.gridControlAccessByPrograms.Size = new System.Drawing.Size(796, 395);
            this.gridControlAccessByPrograms.TabIndex = 2;
            this.gridControlAccessByPrograms.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAccessByPrograms});
            // 
            // gridViewAccessByPrograms
            // 
            this.gridViewAccessByPrograms.GridControl = this.gridControlAccessByPrograms;
            this.gridViewAccessByPrograms.Name = "gridViewAccessByPrograms";
            // 
            // cboPrograms
            // 
            this.cboPrograms.Location = new System.Drawing.Point(107, 21);
            this.cboPrograms.MenuManager = this.ribbon;
            this.cboPrograms.Name = "cboPrograms";
            this.cboPrograms.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPrograms.Size = new System.Drawing.Size(659, 20);
            this.cboPrograms.TabIndex = 1;
            // 
            // lblByPrograms
            // 
            this.tablePanelAccessByPrograms.SetColumn(this.lblByPrograms, 0);
            this.lblByPrograms.Location = new System.Drawing.Point(20, 23);
            this.lblByPrograms.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.lblByPrograms.Name = "lblByPrograms";
            this.tablePanelAccessByPrograms.SetRow(this.lblByPrograms, 0);
            this.lblByPrograms.Size = new System.Drawing.Size(46, 13);
            this.lblByPrograms.TabIndex = 0;
            this.lblByPrograms.Text = "Programa";
            // 
            // Access_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 631);
            this.Controls.Add(this.splitContainerControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "Access_Form";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Accesos";
            this.Load += new System.EventHandler(this.Access_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl.Panel1)).EndInit();
            this.splitContainerControl.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl.Panel2)).EndInit();
            this.splitContainerControl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.navigationPageAccessByUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelAccessByUsers)).EndInit();
            this.tablePanelAccessByUsers.ResumeLayout(false);
            this.tablePanelAccessByUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAccessByUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccessByUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUsers.Properties)).EndInit();
            this.navigationPageAccessByPrograms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelAccessByPrograms)).EndInit();
            this.tablePanelAccessByPrograms.ResumeLayout(false);
            this.tablePanelAccessByPrograms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAccessByPrograms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccessByPrograms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPrograms.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageActions;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupActions;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bbiCreate;
        private DevExpress.XtraBars.BarButtonItem bbiRead;
        private DevExpress.XtraBars.BarButtonItem bbiUpdate;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiReturn;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupOptions;
        private DevExpress.XtraNavBar.NavBarItem navBarItemAccessByUsers;
        private DevExpress.XtraNavBar.NavBarItem navBarItemAccessByPrograms;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageAccessByUsers;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageAccessByPrograms;
        private DevExpress.Utils.Layout.TablePanel tablePanelAccessByUsers;
        private DevExpress.XtraEditors.LabelControl lblByUsers;
        private DevExpress.XtraEditors.LookUpEdit cboUsers;
        private DevExpress.Utils.Layout.TablePanel tablePanelAccessByPrograms;
        private DevExpress.XtraEditors.LabelControl lblByPrograms;
        private DevExpress.XtraEditors.LookUpEdit cboPrograms;
        private DevExpress.XtraGrid.GridControl gridControlAccessByPrograms;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAccessByPrograms;
        private DevExpress.XtraGrid.GridControl gridControlAccessByUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAccessByUsers;
    }
}