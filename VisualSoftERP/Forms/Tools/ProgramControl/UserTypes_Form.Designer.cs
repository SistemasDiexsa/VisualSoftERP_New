namespace VisualSoftERP.Forms.Tools.ProgramControl
{
    partial class UserTypes_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserTypes_Form));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiCreate = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRead = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReturn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageActions = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupActions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tablePanelGeneral = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanelGrids = new DevExpress.Utils.Layout.TablePanel();
            this.gridControlUserTypesPermissions = new DevExpress.XtraGrid.GridControl();
            this.gridViewUserTypesPermissions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnUserTypePermissions_PermissionsID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUserTypePermissions_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUserTypePermissions_Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUserTypePermissions_IsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUserTypePermissions_CreateAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUserTypePermissions_UpdateAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlUserTypes = new DevExpress.XtraGrid.GridControl();
            this.gridViewUserTypes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnUserTypesID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCreateAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUpdateAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tablePanelData = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanelDescription = new DevExpress.Utils.Layout.TablePanel();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.tablePanelName = new DevExpress.Utils.Layout.TablePanel();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelGeneral)).BeginInit();
            this.tablePanelGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelGrids)).BeginInit();
            this.tablePanelGrids.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUserTypesPermissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserTypesPermissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUserTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelData)).BeginInit();
            this.tablePanelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelDescription)).BeginInit();
            this.tablePanelDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelName)).BeginInit();
            this.tablePanelName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(1274, 147);
            this.ribbon.StatusBar = this.ribbonStatusBar;
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
            this.bbiRead.AllowHtmlText = DevExpress.Utils.DefaultBoolean.False;
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 635);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1274, 23);
            // 
            // tablePanelGeneral
            // 
            this.tablePanelGeneral.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanelGeneral.Controls.Add(this.tablePanelGrids);
            this.tablePanelGeneral.Controls.Add(this.tablePanelData);
            this.tablePanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelGeneral.Location = new System.Drawing.Point(0, 147);
            this.tablePanelGeneral.Name = "tablePanelGeneral";
            this.tablePanelGeneral.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 125F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanelGeneral.Size = new System.Drawing.Size(1274, 488);
            this.tablePanelGeneral.TabIndex = 2;
            // 
            // tablePanelGrids
            // 
            this.tablePanelGeneral.SetColumn(this.tablePanelGrids, 0);
            this.tablePanelGrids.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanelGrids.Controls.Add(this.gridControlUserTypesPermissions);
            this.tablePanelGrids.Controls.Add(this.gridControlUserTypes);
            this.tablePanelGrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelGrids.Location = new System.Drawing.Point(3, 128);
            this.tablePanelGrids.Name = "tablePanelGrids";
            this.tablePanelGeneral.SetRow(this.tablePanelGrids, 1);
            this.tablePanelGrids.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanelGrids.Size = new System.Drawing.Size(1268, 357);
            this.tablePanelGrids.TabIndex = 2;
            // 
            // gridControlUserTypesPermissions
            // 
            this.tablePanelGrids.SetColumn(this.gridControlUserTypesPermissions, 0);
            this.gridControlUserTypesPermissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUserTypesPermissions.Location = new System.Drawing.Point(3, 182);
            this.gridControlUserTypesPermissions.MainView = this.gridViewUserTypesPermissions;
            this.gridControlUserTypesPermissions.MenuManager = this.ribbon;
            this.gridControlUserTypesPermissions.Name = "gridControlUserTypesPermissions";
            this.tablePanelGrids.SetRow(this.gridControlUserTypesPermissions, 1);
            this.gridControlUserTypesPermissions.Size = new System.Drawing.Size(1262, 172);
            this.gridControlUserTypesPermissions.TabIndex = 1;
            this.gridControlUserTypesPermissions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUserTypesPermissions});
            // 
            // gridViewUserTypesPermissions
            // 
            this.gridViewUserTypesPermissions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnUserTypePermissions_PermissionsID,
            this.gridColumnUserTypePermissions_Name,
            this.gridColumnUserTypePermissions_Description,
            this.gridColumnUserTypePermissions_IsActive,
            this.gridColumnUserTypePermissions_CreateAt,
            this.gridColumnUserTypePermissions_UpdateAt});
            this.gridViewUserTypesPermissions.GridControl = this.gridControlUserTypesPermissions;
            this.gridViewUserTypesPermissions.Name = "gridViewUserTypesPermissions";
            // 
            // gridColumnUserTypePermissions_PermissionsID
            // 
            this.gridColumnUserTypePermissions_PermissionsID.Caption = "Permisos";
            this.gridColumnUserTypePermissions_PermissionsID.FieldName = "PermissionsID";
            this.gridColumnUserTypePermissions_PermissionsID.Name = "gridColumnUserTypePermissions_PermissionsID";
            // 
            // gridColumnUserTypePermissions_Name
            // 
            this.gridColumnUserTypePermissions_Name.Caption = "Nombre";
            this.gridColumnUserTypePermissions_Name.FieldName = "Name";
            this.gridColumnUserTypePermissions_Name.Name = "gridColumnUserTypePermissions_Name";
            this.gridColumnUserTypePermissions_Name.Visible = true;
            this.gridColumnUserTypePermissions_Name.VisibleIndex = 0;
            // 
            // gridColumnUserTypePermissions_Description
            // 
            this.gridColumnUserTypePermissions_Description.Caption = "Descripción";
            this.gridColumnUserTypePermissions_Description.FieldName = "Description";
            this.gridColumnUserTypePermissions_Description.Name = "gridColumnUserTypePermissions_Description";
            this.gridColumnUserTypePermissions_Description.Visible = true;
            this.gridColumnUserTypePermissions_Description.VisibleIndex = 1;
            // 
            // gridColumnUserTypePermissions_IsActive
            // 
            this.gridColumnUserTypePermissions_IsActive.Caption = "Activo";
            this.gridColumnUserTypePermissions_IsActive.FieldName = "IsActive";
            this.gridColumnUserTypePermissions_IsActive.Name = "gridColumnUserTypePermissions_IsActive";
            // 
            // gridColumnUserTypePermissions_CreateAt
            // 
            this.gridColumnUserTypePermissions_CreateAt.Caption = "Creado en";
            this.gridColumnUserTypePermissions_CreateAt.FieldName = "CreateAt";
            this.gridColumnUserTypePermissions_CreateAt.Name = "gridColumnUserTypePermissions_CreateAt";
            // 
            // gridColumnUserTypePermissions_UpdateAt
            // 
            this.gridColumnUserTypePermissions_UpdateAt.Caption = "Ultima Actualización";
            this.gridColumnUserTypePermissions_UpdateAt.FieldName = "UpdateAt";
            this.gridColumnUserTypePermissions_UpdateAt.Name = "gridColumnUserTypePermissions_UpdateAt";
            // 
            // gridControlUserTypes
            // 
            this.tablePanelGrids.SetColumn(this.gridControlUserTypes, 0);
            this.gridControlUserTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUserTypes.Location = new System.Drawing.Point(3, 3);
            this.gridControlUserTypes.MainView = this.gridViewUserTypes;
            this.gridControlUserTypes.MenuManager = this.ribbon;
            this.gridControlUserTypes.Name = "gridControlUserTypes";
            this.tablePanelGrids.SetRow(this.gridControlUserTypes, 0);
            this.gridControlUserTypes.Size = new System.Drawing.Size(1262, 173);
            this.gridControlUserTypes.TabIndex = 0;
            this.gridControlUserTypes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUserTypes});
            // 
            // gridViewUserTypes
            // 
            this.gridViewUserTypes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnUserTypesID,
            this.gridColumnName,
            this.gridColumnDescription,
            this.gridColumnCreateAt,
            this.gridColumnUpdateAt});
            this.gridViewUserTypes.GridControl = this.gridControlUserTypes;
            this.gridViewUserTypes.Name = "gridViewUserTypes";
            this.gridViewUserTypes.Click += new System.EventHandler(this.gridViewUserTypes_Click);
            this.gridViewUserTypes.DoubleClick += new System.EventHandler(this.gridViewUserTypes_DoubleClick);
            // 
            // gridColumnUserTypesID
            // 
            this.gridColumnUserTypesID.Caption = "ID";
            this.gridColumnUserTypesID.FieldName = "UserTypesID";
            this.gridColumnUserTypesID.Name = "gridColumnUserTypesID";
            this.gridColumnUserTypesID.OptionsColumn.AllowEdit = false;
            this.gridColumnUserTypesID.OptionsColumn.AllowFocus = false;
            this.gridColumnUserTypesID.Visible = true;
            this.gridColumnUserTypesID.VisibleIndex = 0;
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Nombre";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.OptionsColumn.AllowEdit = false;
            this.gridColumnName.OptionsColumn.AllowFocus = false;
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 1;
            // 
            // gridColumnDescription
            // 
            this.gridColumnDescription.Caption = "Descripción";
            this.gridColumnDescription.FieldName = "Description";
            this.gridColumnDescription.Name = "gridColumnDescription";
            this.gridColumnDescription.OptionsColumn.AllowEdit = false;
            this.gridColumnDescription.OptionsColumn.AllowFocus = false;
            this.gridColumnDescription.Visible = true;
            this.gridColumnDescription.VisibleIndex = 2;
            // 
            // gridColumnCreateAt
            // 
            this.gridColumnCreateAt.Caption = "Creado en";
            this.gridColumnCreateAt.FieldName = "CreateAt";
            this.gridColumnCreateAt.Name = "gridColumnCreateAt";
            this.gridColumnCreateAt.OptionsColumn.AllowEdit = false;
            this.gridColumnCreateAt.OptionsColumn.AllowFocus = false;
            this.gridColumnCreateAt.Visible = true;
            this.gridColumnCreateAt.VisibleIndex = 3;
            // 
            // gridColumnUpdateAt
            // 
            this.gridColumnUpdateAt.Caption = "Ultima Actualización";
            this.gridColumnUpdateAt.FieldName = "UpdateAt";
            this.gridColumnUpdateAt.Name = "gridColumnUpdateAt";
            this.gridColumnUpdateAt.OptionsColumn.AllowEdit = false;
            this.gridColumnUpdateAt.OptionsColumn.AllowFocus = false;
            this.gridColumnUpdateAt.Visible = true;
            this.gridColumnUpdateAt.VisibleIndex = 4;
            // 
            // tablePanelData
            // 
            this.tablePanelGeneral.SetColumn(this.tablePanelData, 0);
            this.tablePanelData.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 75F)});
            this.tablePanelData.Controls.Add(this.tablePanelDescription);
            this.tablePanelData.Controls.Add(this.tablePanelName);
            this.tablePanelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelData.Location = new System.Drawing.Point(3, 3);
            this.tablePanelData.Name = "tablePanelData";
            this.tablePanelGeneral.SetRow(this.tablePanelData, 0);
            this.tablePanelData.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanelData.Size = new System.Drawing.Size(1268, 119);
            this.tablePanelData.TabIndex = 1;
            // 
            // tablePanelDescription
            // 
            this.tablePanelData.SetColumn(this.tablePanelDescription, 1);
            this.tablePanelDescription.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanelDescription.Controls.Add(this.txtDescription);
            this.tablePanelDescription.Controls.Add(this.lblDescription);
            this.tablePanelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelDescription.Location = new System.Drawing.Point(320, 3);
            this.tablePanelDescription.Name = "tablePanelDescription";
            this.tablePanelDescription.Padding = new System.Windows.Forms.Padding(20);
            this.tablePanelData.SetRow(this.tablePanelDescription, 0);
            this.tablePanelDescription.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanelDescription.Size = new System.Drawing.Size(945, 113);
            this.tablePanelDescription.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.tablePanelDescription.SetColumn(this.txtDescription, 0);
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(23, 48);
            this.txtDescription.MenuManager = this.ribbon;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.MaxLength = 2000;
            this.tablePanelDescription.SetRow(this.txtDescription, 1);
            this.txtDescription.Size = new System.Drawing.Size(899, 42);
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
            // tablePanelName
            // 
            this.tablePanelData.SetColumn(this.tablePanelName, 0);
            this.tablePanelName.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanelName.Controls.Add(this.txtName);
            this.tablePanelName.Controls.Add(this.lblName);
            this.tablePanelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelName.Location = new System.Drawing.Point(3, 3);
            this.tablePanelName.Name = "tablePanelName";
            this.tablePanelName.Padding = new System.Windows.Forms.Padding(20);
            this.tablePanelData.SetRow(this.tablePanelName, 0);
            this.tablePanelName.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanelName.Size = new System.Drawing.Size(311, 113);
            this.tablePanelName.TabIndex = 0;
            // 
            // txtName
            // 
            this.tablePanelName.SetColumn(this.txtName, 0);
            this.txtName.Location = new System.Drawing.Point(23, 59);
            this.txtName.MenuManager = this.ribbon;
            this.txtName.Name = "txtName";
            this.tablePanelName.SetRow(this.txtName, 1);
            this.txtName.Size = new System.Drawing.Size(265, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.tablePanelName.SetColumn(this.lblName, 0);
            this.lblName.Location = new System.Drawing.Point(23, 26);
            this.lblName.Name = "lblName";
            this.tablePanelName.SetRow(this.lblName, 0);
            this.lblName.Size = new System.Drawing.Size(37, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // UserTypes_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 658);
            this.Controls.Add(this.tablePanelGeneral);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "UserTypes_Form";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Roles de Usuario";
            this.Load += new System.EventHandler(this.UserTypes_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelGeneral)).EndInit();
            this.tablePanelGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelGrids)).EndInit();
            this.tablePanelGrids.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUserTypesPermissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserTypesPermissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUserTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelData)).EndInit();
            this.tablePanelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelDescription)).EndInit();
            this.tablePanelDescription.ResumeLayout(false);
            this.tablePanelDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelName)).EndInit();
            this.tablePanelName.ResumeLayout(false);
            this.tablePanelName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
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
        private DevExpress.Utils.Layout.TablePanel tablePanelGeneral;
        private DevExpress.XtraGrid.GridControl gridControlUserTypes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUserTypes;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUserTypesID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCreateAt;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUpdateAt;
        private DevExpress.Utils.Layout.TablePanel tablePanelData;
        private DevExpress.Utils.Layout.TablePanel tablePanelName;
        private DevExpress.Utils.Layout.TablePanel tablePanelDescription;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.Utils.Layout.TablePanel tablePanelGrids;
        private DevExpress.XtraGrid.GridControl gridControlUserTypesPermissions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUserTypesPermissions;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUserTypePermissions_PermissionsID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUserTypePermissions_Name;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUserTypePermissions_Description;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUserTypePermissions_IsActive;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUserTypePermissions_CreateAt;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUserTypePermissions_UpdateAt;
    }
}