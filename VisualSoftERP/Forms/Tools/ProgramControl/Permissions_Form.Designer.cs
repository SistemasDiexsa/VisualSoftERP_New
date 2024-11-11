namespace VisualSoftERP.Forms.Tools.ProgramControl
{
    partial class Permissions_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Permissions_Form));
            this.RibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiCreate = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRead = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReturn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageActions = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupActions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tablePanelGeneral = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanelData = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanelName = new DevExpress.Utils.Layout.TablePanel();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.tablePanelIsActive = new DevExpress.Utils.Layout.TablePanel();
            this.swIsActive = new DevExpress.XtraEditors.ToggleSwitch();
            this.lblIsActive = new DevExpress.XtraEditors.LabelControl();
            this.tablePanelDescription = new DevExpress.Utils.Layout.TablePanel();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.gridControlPermissions = new DevExpress.XtraGrid.GridControl();
            this.gridViewPermissions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnPermissionsID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCreateAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUpdateAt = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelGeneral)).BeginInit();
            this.tablePanelGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelData)).BeginInit();
            this.tablePanelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelName)).BeginInit();
            this.tablePanelName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelIsActive)).BeginInit();
            this.tablePanelIsActive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swIsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelDescription)).BeginInit();
            this.tablePanelDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPermissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPermissions)).BeginInit();
            this.SuspendLayout();
            // 
            // RibbonControl
            // 
            this.RibbonControl.ExpandCollapseItem.Id = 0;
            this.RibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RibbonControl.ExpandCollapseItem,
            this.RibbonControl.SearchEditItem,
            this.bbiCreate,
            this.bbiRead,
            this.bbiUpdate,
            this.bbiDelete,
            this.bbiReturn});
            this.RibbonControl.Location = new System.Drawing.Point(0, 0);
            this.RibbonControl.MaxItemId = 6;
            this.RibbonControl.Name = "RibbonControl";
            this.RibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageActions});
            this.RibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.RibbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.RibbonControl.Size = new System.Drawing.Size(1228, 147);
            this.RibbonControl.StatusBar = this.ribbonStatusBar;
            // 
            // bbiCreate
            // 
            this.bbiCreate.Caption = "Nuevo";
            this.bbiCreate.Enabled = false;
            this.bbiCreate.Id = 1;
            this.bbiCreate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiCreate.ImageOptions.SvgImage")));
            this.bbiCreate.Name = "bbiCreate";
            this.bbiCreate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCreate_ItemClick);
            // 
            // bbiRead
            // 
            this.bbiRead.Caption = "Ver";
            this.bbiRead.Enabled = false;
            this.bbiRead.Id = 2;
            this.bbiRead.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiRead.ImageOptions.SvgImage")));
            this.bbiRead.Name = "bbiRead";
            this.bbiRead.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRead_ItemClick);
            // 
            // bbiUpdate
            // 
            this.bbiUpdate.Caption = "Guardar";
            this.bbiUpdate.Enabled = false;
            this.bbiUpdate.Id = 3;
            this.bbiUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiUpdate.ImageOptions.SvgImage")));
            this.bbiUpdate.Name = "bbiUpdate";
            this.bbiUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiUpdate_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Eliminar";
            this.bbiDelete.Enabled = false;
            this.bbiDelete.Id = 4;
            this.bbiDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiDelete.ImageOptions.SvgImage")));
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bbiReturn
            // 
            this.bbiReturn.AllowHtmlText = DevExpress.Utils.DefaultBoolean.False;
            this.bbiReturn.Caption = "Regresar";
            this.bbiReturn.Enabled = false;
            this.bbiReturn.Id = 5;
            this.bbiReturn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiReturn.ImageOptions.SvgImage")));
            this.bbiReturn.Name = "bbiReturn";
            this.bbiReturn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReturn_ItemClick);
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 639);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.RibbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1228, 23);
            // 
            // tablePanelGeneral
            // 
            this.tablePanelGeneral.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanelGeneral.Controls.Add(this.tablePanelData);
            this.tablePanelGeneral.Controls.Add(this.gridControlPermissions);
            this.tablePanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelGeneral.Location = new System.Drawing.Point(0, 147);
            this.tablePanelGeneral.Name = "tablePanelGeneral";
            this.tablePanelGeneral.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 125F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 0F)});
            this.tablePanelGeneral.Size = new System.Drawing.Size(1228, 492);
            this.tablePanelGeneral.TabIndex = 2;
            // 
            // tablePanelData
            // 
            this.tablePanelGeneral.SetColumn(this.tablePanelData, 0);
            this.tablePanelData.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 64F)});
            this.tablePanelData.Controls.Add(this.tablePanelName);
            this.tablePanelData.Controls.Add(this.tablePanelIsActive);
            this.tablePanelData.Controls.Add(this.tablePanelDescription);
            this.tablePanelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelData.Location = new System.Drawing.Point(3, 3);
            this.tablePanelData.Name = "tablePanelData";
            this.tablePanelGeneral.SetRow(this.tablePanelData, 0);
            this.tablePanelData.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanelData.Size = new System.Drawing.Size(1222, 119);
            this.tablePanelData.TabIndex = 1;
            // 
            // tablePanelName
            // 
            this.tablePanelData.SetColumn(this.tablePanelName, 0);
            this.tablePanelName.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanelName.Controls.Add(this.txtName);
            this.tablePanelName.Controls.Add(this.lblName);
            this.tablePanelName.Location = new System.Drawing.Point(3, 3);
            this.tablePanelName.Name = "tablePanelName";
            this.tablePanelName.Padding = new System.Windows.Forms.Padding(20);
            this.tablePanelData.SetRow(this.tablePanelName, 0);
            this.tablePanelName.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanelName.Size = new System.Drawing.Size(339, 113);
            this.tablePanelName.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(23, 59);
            this.txtName.MenuManager = this.RibbonControl;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(248, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(23, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // tablePanelIsActive
            // 
            this.tablePanelData.SetColumn(this.tablePanelIsActive, 1);
            this.tablePanelIsActive.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanelIsActive.Controls.Add(this.swIsActive);
            this.tablePanelIsActive.Controls.Add(this.lblIsActive);
            this.tablePanelIsActive.Location = new System.Drawing.Point(348, 3);
            this.tablePanelIsActive.Name = "tablePanelIsActive";
            this.tablePanelIsActive.Padding = new System.Windows.Forms.Padding(20);
            this.tablePanelData.SetRow(this.tablePanelIsActive, 0);
            this.tablePanelIsActive.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanelIsActive.Size = new System.Drawing.Size(203, 113);
            this.tablePanelIsActive.TabIndex = 1;
            // 
            // swIsActive
            // 
            this.tablePanelIsActive.SetColumn(this.swIsActive, 0);
            this.swIsActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swIsActive.Location = new System.Drawing.Point(23, 48);
            this.swIsActive.MenuManager = this.RibbonControl;
            this.swIsActive.Name = "swIsActive";
            this.swIsActive.Properties.OffText = "Inactivo";
            this.swIsActive.Properties.OnText = "Activo";
            this.tablePanelIsActive.SetRow(this.swIsActive, 1);
            this.swIsActive.Size = new System.Drawing.Size(157, 42);
            this.swIsActive.TabIndex = 1;
            // 
            // lblIsActive
            // 
            this.tablePanelIsActive.SetColumn(this.lblIsActive, 0);
            this.lblIsActive.Location = new System.Drawing.Point(23, 26);
            this.lblIsActive.Name = "lblIsActive";
            this.tablePanelIsActive.SetRow(this.lblIsActive, 0);
            this.lblIsActive.Size = new System.Drawing.Size(30, 13);
            this.lblIsActive.TabIndex = 0;
            this.lblIsActive.Text = "Activo";
            // 
            // tablePanelDescription
            // 
            this.tablePanelData.SetColumn(this.tablePanelDescription, 2);
            this.tablePanelDescription.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanelDescription.Controls.Add(this.txtDescription);
            this.tablePanelDescription.Controls.Add(this.lblDescription);
            this.tablePanelDescription.Location = new System.Drawing.Point(557, 3);
            this.tablePanelDescription.Name = "tablePanelDescription";
            this.tablePanelDescription.Padding = new System.Windows.Forms.Padding(20);
            this.tablePanelData.SetRow(this.tablePanelDescription, 0);
            this.tablePanelDescription.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanelDescription.Size = new System.Drawing.Size(662, 113);
            this.tablePanelDescription.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.tablePanelDescription.SetColumn(this.txtDescription, 0);
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(23, 48);
            this.txtDescription.MenuManager = this.RibbonControl;
            this.txtDescription.Name = "txtDescription";
            this.tablePanelDescription.SetRow(this.txtDescription, 1);
            this.txtDescription.Size = new System.Drawing.Size(616, 42);
            this.txtDescription.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.tablePanelDescription.SetColumn(this.lblDescription, 0);
            this.lblDescription.Location = new System.Drawing.Point(23, 26);
            this.lblDescription.Name = "lblDescription";
            this.tablePanelDescription.SetRow(this.lblDescription, 0);
            this.lblDescription.Size = new System.Drawing.Size(54, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Descripción";
            // 
            // gridControlPermissions
            // 
            this.tablePanelGeneral.SetColumn(this.gridControlPermissions, 0);
            this.gridControlPermissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPermissions.Location = new System.Drawing.Point(3, 128);
            this.gridControlPermissions.MainView = this.gridViewPermissions;
            this.gridControlPermissions.MenuManager = this.RibbonControl;
            this.gridControlPermissions.Name = "gridControlPermissions";
            this.tablePanelGeneral.SetRow(this.gridControlPermissions, 1);
            this.gridControlPermissions.Size = new System.Drawing.Size(1222, 361);
            this.gridControlPermissions.TabIndex = 0;
            this.gridControlPermissions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPermissions});
            // 
            // gridViewPermissions
            // 
            this.gridViewPermissions.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewPermissions.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewPermissions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnPermissionsID,
            this.gridColumnName,
            this.gridColumnDescription,
            this.gridColumnIsActive,
            this.gridColumnCreateAt,
            this.gridColumnUpdateAt});
            this.gridViewPermissions.GridControl = this.gridControlPermissions;
            this.gridViewPermissions.Name = "gridViewPermissions";
            this.gridViewPermissions.OptionsView.RowAutoHeight = true;
            this.gridViewPermissions.Click += new System.EventHandler(this.gridViewPermissions_Click);
            this.gridViewPermissions.DoubleClick += new System.EventHandler(this.gridViewPermissions_DoubleClick);
            // 
            // gridColumnPermissionsID
            // 
            this.gridColumnPermissionsID.Caption = "ID";
            this.gridColumnPermissionsID.FieldName = "PermissionsID";
            this.gridColumnPermissionsID.Name = "gridColumnPermissionsID";
            this.gridColumnPermissionsID.OptionsColumn.AllowEdit = false;
            this.gridColumnPermissionsID.OptionsColumn.AllowFocus = false;
            this.gridColumnPermissionsID.Visible = true;
            this.gridColumnPermissionsID.VisibleIndex = 0;
            this.gridColumnPermissionsID.Width = 70;
            // 
            // gridColumnName
            // 
            this.gridColumnName.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumnName.Caption = "Nombre";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.OptionsColumn.AllowEdit = false;
            this.gridColumnName.OptionsColumn.AllowFocus = false;
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 1;
            this.gridColumnName.Width = 250;
            // 
            // gridColumnDescription
            // 
            this.gridColumnDescription.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnDescription.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumnDescription.Caption = "Descripción";
            this.gridColumnDescription.FieldName = "Description";
            this.gridColumnDescription.Name = "gridColumnDescription";
            this.gridColumnDescription.OptionsColumn.AllowEdit = false;
            this.gridColumnDescription.OptionsColumn.AllowFocus = false;
            this.gridColumnDescription.Visible = true;
            this.gridColumnDescription.VisibleIndex = 2;
            this.gridColumnDescription.Width = 400;
            // 
            // gridColumnIsActive
            // 
            this.gridColumnIsActive.Caption = "Activo";
            this.gridColumnIsActive.FieldName = "IsActive";
            this.gridColumnIsActive.Name = "gridColumnIsActive";
            this.gridColumnIsActive.OptionsColumn.AllowEdit = false;
            this.gridColumnIsActive.OptionsColumn.AllowFocus = false;
            this.gridColumnIsActive.Visible = true;
            this.gridColumnIsActive.VisibleIndex = 3;
            // 
            // gridColumnCreateAt
            // 
            this.gridColumnCreateAt.Caption = "Creado en";
            this.gridColumnCreateAt.FieldName = "CreateAt";
            this.gridColumnCreateAt.Name = "gridColumnCreateAt";
            this.gridColumnCreateAt.OptionsColumn.AllowEdit = false;
            this.gridColumnCreateAt.OptionsColumn.AllowFocus = false;
            this.gridColumnCreateAt.Visible = true;
            this.gridColumnCreateAt.VisibleIndex = 4;
            this.gridColumnCreateAt.Width = 203;
            // 
            // gridColumnUpdateAt
            // 
            this.gridColumnUpdateAt.Caption = "Ultima Actualización";
            this.gridColumnUpdateAt.FieldName = "UpdateAt";
            this.gridColumnUpdateAt.Name = "gridColumnUpdateAt";
            this.gridColumnUpdateAt.OptionsColumn.AllowEdit = false;
            this.gridColumnUpdateAt.OptionsColumn.AllowFocus = false;
            this.gridColumnUpdateAt.Visible = true;
            this.gridColumnUpdateAt.VisibleIndex = 5;
            this.gridColumnUpdateAt.Width = 203;
            // 
            // Permissions_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 662);
            this.Controls.Add(this.tablePanelGeneral);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.RibbonControl);
            this.Name = "Permissions_Form";
            this.Ribbon = this.RibbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Permisos";
            this.Load += new System.EventHandler(this.Permissions_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelGeneral)).EndInit();
            this.tablePanelGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelData)).EndInit();
            this.tablePanelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelName)).EndInit();
            this.tablePanelName.ResumeLayout(false);
            this.tablePanelName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelIsActive)).EndInit();
            this.tablePanelIsActive.ResumeLayout(false);
            this.tablePanelIsActive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swIsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelDescription)).EndInit();
            this.tablePanelDescription.ResumeLayout(false);
            this.tablePanelDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPermissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPermissions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl RibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageActions;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupActions;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bbiCreate;
        private DevExpress.XtraBars.BarButtonItem bbiRead;
        private DevExpress.XtraBars.BarButtonItem bbiUpdate;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.Utils.Layout.TablePanel tablePanelGeneral;
        private DevExpress.XtraGrid.GridControl gridControlPermissions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPermissions;
        private DevExpress.Utils.Layout.TablePanel tablePanelData;
        private DevExpress.Utils.Layout.TablePanel tablePanelName;
        private DevExpress.Utils.Layout.TablePanel tablePanelIsActive;
        private DevExpress.Utils.Layout.TablePanel tablePanelDescription;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.ToggleSwitch swIsActive;
        private DevExpress.XtraEditors.LabelControl lblIsActive;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraBars.BarButtonItem bbiReturn;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPermissionsID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCreateAt;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUpdateAt;
    }
}