namespace VisualSoftERP.Forms.Tools.ProgramControl
{
    partial class Programs_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programs_Form));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPageActions = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupActions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.bbiCreate = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRead = new DevExpress.XtraBars.BarButtonItem();
            this.bbiUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReturn = new DevExpress.XtraBars.BarButtonItem();
            this.tablePanelGeneral = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanelData = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanelIsActive = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanelRibbonPageGroup = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanelRibbonPage = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanelName = new DevExpress.Utils.Layout.TablePanel();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.lblRibbonPage = new DevExpress.XtraEditors.LabelControl();
            this.lblRibbonPageGroup = new DevExpress.XtraEditors.LabelControl();
            this.lblIsActive = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.cboRibbonPage = new DevExpress.XtraEditors.LookUpEdit();
            this.cboRibbonPageGroup = new DevExpress.XtraEditors.LookUpEdit();
            this.swIsActive = new DevExpress.XtraEditors.ToggleSwitch();
            this.gridControlPrograms = new DevExpress.XtraGrid.GridControl();
            this.gridViewPrograms = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnProgramsID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRibbonPage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRibbonPageGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTextIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCreateAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUpdateAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelGeneral)).BeginInit();
            this.tablePanelGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelData)).BeginInit();
            this.tablePanelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelIsActive)).BeginInit();
            this.tablePanelIsActive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelRibbonPageGroup)).BeginInit();
            this.tablePanelRibbonPageGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelRibbonPage)).BeginInit();
            this.tablePanelRibbonPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelName)).BeginInit();
            this.tablePanelName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRibbonPage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRibbonPageGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swIsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPrograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPrograms)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(1029, 147);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 599);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1029, 23);
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
            this.bbiReturn.Caption = "Regresar";
            this.bbiReturn.Enabled = false;
            this.bbiReturn.Id = 5;
            this.bbiReturn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiReturn.ImageOptions.SvgImage")));
            this.bbiReturn.Name = "bbiReturn";
            this.bbiReturn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReturn_ItemClick);
            // 
            // tablePanelGeneral
            // 
            this.tablePanelGeneral.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanelGeneral.Controls.Add(this.gridControlPrograms);
            this.tablePanelGeneral.Controls.Add(this.tablePanelData);
            this.tablePanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelGeneral.Location = new System.Drawing.Point(0, 147);
            this.tablePanelGeneral.Name = "tablePanelGeneral";
            this.tablePanelGeneral.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 125F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.tablePanelGeneral.Size = new System.Drawing.Size(1029, 452);
            this.tablePanelGeneral.TabIndex = 2;
            // 
            // tablePanelData
            // 
            this.tablePanelGeneral.SetColumn(this.tablePanelData, 0);
            this.tablePanelData.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)});
            this.tablePanelData.Controls.Add(this.tablePanelName);
            this.tablePanelData.Controls.Add(this.tablePanelRibbonPage);
            this.tablePanelData.Controls.Add(this.tablePanelRibbonPageGroup);
            this.tablePanelData.Controls.Add(this.tablePanelIsActive);
            this.tablePanelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelData.Location = new System.Drawing.Point(3, 3);
            this.tablePanelData.Name = "tablePanelData";
            this.tablePanelGeneral.SetRow(this.tablePanelData, 0);
            this.tablePanelData.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanelData.Size = new System.Drawing.Size(1023, 119);
            this.tablePanelData.TabIndex = 0;
            // 
            // tablePanelIsActive
            // 
            this.tablePanelData.SetColumn(this.tablePanelIsActive, 3);
            this.tablePanelIsActive.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanelIsActive.Controls.Add(this.swIsActive);
            this.tablePanelIsActive.Controls.Add(this.lblIsActive);
            this.tablePanelIsActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelIsActive.Location = new System.Drawing.Point(770, 3);
            this.tablePanelIsActive.Name = "tablePanelIsActive";
            this.tablePanelIsActive.Padding = new System.Windows.Forms.Padding(20);
            this.tablePanelData.SetRow(this.tablePanelIsActive, 0);
            this.tablePanelIsActive.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanelIsActive.Size = new System.Drawing.Size(250, 113);
            this.tablePanelIsActive.TabIndex = 0;
            // 
            // tablePanelRibbonPageGroup
            // 
            this.tablePanelData.SetColumn(this.tablePanelRibbonPageGroup, 2);
            this.tablePanelRibbonPageGroup.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanelRibbonPageGroup.Controls.Add(this.cboRibbonPageGroup);
            this.tablePanelRibbonPageGroup.Controls.Add(this.lblRibbonPageGroup);
            this.tablePanelRibbonPageGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelRibbonPageGroup.Location = new System.Drawing.Point(515, 3);
            this.tablePanelRibbonPageGroup.Name = "tablePanelRibbonPageGroup";
            this.tablePanelRibbonPageGroup.Padding = new System.Windows.Forms.Padding(20);
            this.tablePanelData.SetRow(this.tablePanelRibbonPageGroup, 0);
            this.tablePanelRibbonPageGroup.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanelRibbonPageGroup.Size = new System.Drawing.Size(250, 113);
            this.tablePanelRibbonPageGroup.TabIndex = 1;
            // 
            // tablePanelRibbonPage
            // 
            this.tablePanelData.SetColumn(this.tablePanelRibbonPage, 1);
            this.tablePanelRibbonPage.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanelRibbonPage.Controls.Add(this.cboRibbonPage);
            this.tablePanelRibbonPage.Controls.Add(this.lblRibbonPage);
            this.tablePanelRibbonPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelRibbonPage.Location = new System.Drawing.Point(259, 3);
            this.tablePanelRibbonPage.Name = "tablePanelRibbonPage";
            this.tablePanelRibbonPage.Padding = new System.Windows.Forms.Padding(20);
            this.tablePanelData.SetRow(this.tablePanelRibbonPage, 0);
            this.tablePanelRibbonPage.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanelRibbonPage.Size = new System.Drawing.Size(250, 113);
            this.tablePanelRibbonPage.TabIndex = 2;
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
            this.tablePanelName.Size = new System.Drawing.Size(250, 113);
            this.tablePanelName.TabIndex = 3;
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
            // lblRibbonPage
            // 
            this.tablePanelRibbonPage.SetColumn(this.lblRibbonPage, 0);
            this.lblRibbonPage.Location = new System.Drawing.Point(23, 26);
            this.lblRibbonPage.Name = "lblRibbonPage";
            this.tablePanelRibbonPage.SetRow(this.lblRibbonPage, 0);
            this.lblRibbonPage.Size = new System.Drawing.Size(39, 13);
            this.lblRibbonPage.TabIndex = 0;
            this.lblRibbonPage.Text = "Pestaña";
            // 
            // lblRibbonPageGroup
            // 
            this.tablePanelRibbonPageGroup.SetColumn(this.lblRibbonPageGroup, 0);
            this.lblRibbonPageGroup.Location = new System.Drawing.Point(23, 26);
            this.lblRibbonPageGroup.Name = "lblRibbonPageGroup";
            this.tablePanelRibbonPageGroup.SetRow(this.lblRibbonPageGroup, 0);
            this.lblRibbonPageGroup.Size = new System.Drawing.Size(29, 13);
            this.lblRibbonPageGroup.TabIndex = 0;
            this.lblRibbonPageGroup.Text = "Grupo";
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
            // txtName
            // 
            this.tablePanelName.SetColumn(this.txtName, 0);
            this.txtName.Location = new System.Drawing.Point(23, 59);
            this.txtName.MenuManager = this.ribbon;
            this.txtName.Name = "txtName";
            this.tablePanelName.SetRow(this.txtName, 1);
            this.txtName.Size = new System.Drawing.Size(204, 20);
            this.txtName.TabIndex = 1;
            // 
            // cboRibbonPage
            // 
            this.tablePanelRibbonPage.SetColumn(this.cboRibbonPage, 0);
            this.cboRibbonPage.Location = new System.Drawing.Point(23, 59);
            this.cboRibbonPage.MenuManager = this.ribbon;
            this.cboRibbonPage.Name = "cboRibbonPage";
            this.cboRibbonPage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanelRibbonPage.SetRow(this.cboRibbonPage, 1);
            this.cboRibbonPage.Size = new System.Drawing.Size(204, 20);
            this.cboRibbonPage.TabIndex = 1;
            this.cboRibbonPage.EditValueChanged += new System.EventHandler(this.cboRibbonPage_EditValueChanged);
            // 
            // cboRibbonPageGroup
            // 
            this.tablePanelRibbonPageGroup.SetColumn(this.cboRibbonPageGroup, 0);
            this.cboRibbonPageGroup.Location = new System.Drawing.Point(23, 59);
            this.cboRibbonPageGroup.MenuManager = this.ribbon;
            this.cboRibbonPageGroup.Name = "cboRibbonPageGroup";
            this.cboRibbonPageGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanelRibbonPageGroup.SetRow(this.cboRibbonPageGroup, 1);
            this.cboRibbonPageGroup.Size = new System.Drawing.Size(204, 20);
            this.cboRibbonPageGroup.TabIndex = 1;
            // 
            // swIsActive
            // 
            this.tablePanelIsActive.SetColumn(this.swIsActive, 0);
            this.swIsActive.Location = new System.Drawing.Point(23, 57);
            this.swIsActive.MenuManager = this.ribbon;
            this.swIsActive.Name = "swIsActive";
            this.swIsActive.Properties.OffText = "Inactivo";
            this.swIsActive.Properties.OnText = "Activo";
            this.tablePanelIsActive.SetRow(this.swIsActive, 1);
            this.swIsActive.Size = new System.Drawing.Size(204, 24);
            this.swIsActive.TabIndex = 1;
            // 
            // gridControlPrograms
            // 
            this.tablePanelGeneral.SetColumn(this.gridControlPrograms, 0);
            this.gridControlPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPrograms.Location = new System.Drawing.Point(3, 128);
            this.gridControlPrograms.MainView = this.gridViewPrograms;
            this.gridControlPrograms.MenuManager = this.ribbon;
            this.gridControlPrograms.Name = "gridControlPrograms";
            this.tablePanelGeneral.SetRow(this.gridControlPrograms, 1);
            this.gridControlPrograms.Size = new System.Drawing.Size(1023, 321);
            this.gridControlPrograms.TabIndex = 1;
            this.gridControlPrograms.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPrograms});
            // 
            // gridViewPrograms
            // 
            this.gridViewPrograms.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnProgramsID,
            this.gridColumnName,
            this.gridColumnRibbonPage,
            this.gridColumnRibbonPageGroup,
            this.gridColumnTextIsActive,
            this.gridColumnCreateAt,
            this.gridColumnUpdateAt,
            this.gridColumnIsActive});
            this.gridViewPrograms.GridControl = this.gridControlPrograms;
            this.gridViewPrograms.Name = "gridViewPrograms";
            this.gridViewPrograms.Click += new System.EventHandler(this.gridViewPrograms_Click);
            this.gridViewPrograms.DoubleClick += new System.EventHandler(this.gridViewPrograms_DoubleClick);
            // 
            // gridColumnProgramsID
            // 
            this.gridColumnProgramsID.Caption = "ID";
            this.gridColumnProgramsID.FieldName = "ProgramsID";
            this.gridColumnProgramsID.Name = "gridColumnProgramsID";
            this.gridColumnProgramsID.OptionsColumn.AllowEdit = false;
            this.gridColumnProgramsID.OptionsColumn.AllowFocus = false;
            this.gridColumnProgramsID.Visible = true;
            this.gridColumnProgramsID.VisibleIndex = 0;
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
            // gridColumnRibbonPage
            // 
            this.gridColumnRibbonPage.Caption = "Pestaña";
            this.gridColumnRibbonPage.FieldName = "RibbonPage";
            this.gridColumnRibbonPage.Name = "gridColumnRibbonPage";
            this.gridColumnRibbonPage.OptionsColumn.AllowEdit = false;
            this.gridColumnRibbonPage.OptionsColumn.AllowFocus = false;
            this.gridColumnRibbonPage.Visible = true;
            this.gridColumnRibbonPage.VisibleIndex = 2;
            // 
            // gridColumnRibbonPageGroup
            // 
            this.gridColumnRibbonPageGroup.Caption = "Grupo";
            this.gridColumnRibbonPageGroup.FieldName = "RibbonPageGroup";
            this.gridColumnRibbonPageGroup.Name = "gridColumnRibbonPageGroup";
            this.gridColumnRibbonPageGroup.OptionsColumn.AllowEdit = false;
            this.gridColumnRibbonPageGroup.OptionsColumn.AllowFocus = false;
            this.gridColumnRibbonPageGroup.Visible = true;
            this.gridColumnRibbonPageGroup.VisibleIndex = 3;
            // 
            // gridColumnTextIsActive
            // 
            this.gridColumnTextIsActive.Caption = "Activo";
            this.gridColumnTextIsActive.FieldName = "TextIsActive";
            this.gridColumnTextIsActive.Name = "gridColumnTextIsActive";
            this.gridColumnTextIsActive.OptionsColumn.AllowEdit = false;
            this.gridColumnTextIsActive.OptionsColumn.AllowFocus = false;
            this.gridColumnTextIsActive.Visible = true;
            this.gridColumnTextIsActive.VisibleIndex = 4;
            // 
            // gridColumnCreateAt
            // 
            this.gridColumnCreateAt.Caption = "Creado en";
            this.gridColumnCreateAt.FieldName = "CreateAt";
            this.gridColumnCreateAt.Name = "gridColumnCreateAt";
            this.gridColumnCreateAt.OptionsColumn.AllowEdit = false;
            this.gridColumnCreateAt.OptionsColumn.AllowFocus = false;
            this.gridColumnCreateAt.Visible = true;
            this.gridColumnCreateAt.VisibleIndex = 5;
            // 
            // gridColumnUpdateAt
            // 
            this.gridColumnUpdateAt.Caption = "Ultima Actualización";
            this.gridColumnUpdateAt.FieldName = "UpdateAt";
            this.gridColumnUpdateAt.Name = "gridColumnUpdateAt";
            this.gridColumnUpdateAt.OptionsColumn.AllowEdit = false;
            this.gridColumnUpdateAt.OptionsColumn.AllowFocus = false;
            this.gridColumnUpdateAt.Visible = true;
            this.gridColumnUpdateAt.VisibleIndex = 6;
            // 
            // gridColumnIsActive
            // 
            this.gridColumnIsActive.Caption = "IsActive";
            this.gridColumnIsActive.Name = "gridColumnIsActive";
            // 
            // Programs_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 622);
            this.Controls.Add(this.tablePanelGeneral);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "Programs_Form";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Módulos";
            this.Load += new System.EventHandler(this.Programs_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelGeneral)).EndInit();
            this.tablePanelGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelData)).EndInit();
            this.tablePanelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelIsActive)).EndInit();
            this.tablePanelIsActive.ResumeLayout(false);
            this.tablePanelIsActive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelRibbonPageGroup)).EndInit();
            this.tablePanelRibbonPageGroup.ResumeLayout(false);
            this.tablePanelRibbonPageGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelRibbonPage)).EndInit();
            this.tablePanelRibbonPage.ResumeLayout(false);
            this.tablePanelRibbonPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelName)).EndInit();
            this.tablePanelName.ResumeLayout(false);
            this.tablePanelName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRibbonPage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRibbonPageGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swIsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPrograms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPrograms)).EndInit();
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
        private DevExpress.Utils.Layout.TablePanel tablePanelData;
        private DevExpress.Utils.Layout.TablePanel tablePanelName;
        private DevExpress.Utils.Layout.TablePanel tablePanelRibbonPage;
        private DevExpress.Utils.Layout.TablePanel tablePanelRibbonPageGroup;
        private DevExpress.Utils.Layout.TablePanel tablePanelIsActive;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.LabelControl lblRibbonPage;
        private DevExpress.XtraEditors.LabelControl lblRibbonPageGroup;
        private DevExpress.XtraEditors.LabelControl lblIsActive;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LookUpEdit cboRibbonPage;
        private DevExpress.XtraEditors.LookUpEdit cboRibbonPageGroup;
        private DevExpress.XtraEditors.ToggleSwitch swIsActive;
        private DevExpress.XtraGrid.GridControl gridControlPrograms;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPrograms;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProgramsID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRibbonPage;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRibbonPageGroup;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTextIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCreateAt;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUpdateAt;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIsActive;
    }
}