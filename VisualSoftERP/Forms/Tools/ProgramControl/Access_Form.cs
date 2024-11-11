using DevExpress.XtraBars;
using DevExpress.XtraNavBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualSoftERP.Classes.Tools.ProgramControl;
using VisualSoftERP.Classes.Utils;

namespace VisualSoftERP.Forms.Tools.ProgramControl
{
    public partial class Access_Form : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public Access_Form()
        {
            InitializeComponent();
        }

        #region USER INTERACTIONS
        private void Access_Form_Load(object sender, EventArgs e)
        {
            LoadCombos();
            ShowHideButtons(false);
            InitGrid();
            LoadGrid();
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseDefaultWaitForm();
        }
        private void navBarControl_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                NavBarItemLink item = e.Link;
                if (item != null)
                {
                    switch (item.ItemName)
                    {
                        case "navBarItemAccessByUsers":
                            navigationFrame.SelectedPage = navigationPageAccessByUsers;
                            break;
                        case "navBarItemAccessByPrograms":
                            navigationFrame.SelectedPage = navigationPageAccessByPrograms;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        #endregion USER INTERACTIONS


        #region BUTTONS

        #endregion BUTTONS


        private void LoadCombos()
        {
            try
            {
                Combos_Class cl = new Combos_Class();
                #region USERS
                cboUsers.Properties.ValueMember = "UsersID";
                cboUsers.Properties.DisplayMember = "Name";
                cboUsers.Properties.DataSource = cl.Grid("UsersGrid", cl.parameters);
                cboUsers.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
                cboUsers.Properties.ForceInitialize();
                cboUsers.Properties.PopulateColumns();
                cboUsers.Properties.Columns["Name"].Caption = "Usuario";
                cboUsers.Properties.Columns["UsersID"].Visible = false;
                cboUsers.Properties.Columns["Login"].Visible = false;
                cboUsers.Properties.Columns["Password"].Visible = false;
                cboUsers.Properties.Columns["TextIsActive"].Visible = false;
                cboUsers.Properties.Columns["IsActive"].Visible = false;
                cboUsers.Properties.Columns["UserTypesID"].Visible = false;
                cboUsers.Properties.Columns["UserTypesName"].Visible = false;
                cboUsers.Properties.Columns["IsRemembering"].Visible = false;
                cboUsers.Properties.Columns["TextIsRemembering"].Visible = false;
                cboUsers.Properties.Columns["LastActive"].Visible = false;
                cboUsers.Properties.Columns["CreateAt"].Visible = false;
                cboUsers.Properties.Columns["UpdateAt"].Visible = false;
                cboUsers.Properties.NullText = "Favor de seleccionar un usuario";
                cboUsers.EditValue = null;
                #endregion USERS

                #region PROGRAMS
                //cboPrograms.Properties.ValueMember = "ProgramsID";
                //cboPrograms.Properties.DisplayMember = "Name";
                //cboPrograms.Properties.DataSource = cl.Grid("ProgramsGrid", cl.parameters);
                //cboPrograms.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
                //cboPrograms.Properties.ForceInitialize();
                //cboPrograms.Properties.PopulateColumns();
                #endregion PROGRAMS
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }

        private void ShowHideButtons(bool IsEditing)
        {
            try
            {
                if (IsEditing)
                {
                    bbiCreate.Enabled = false;
                    bbiRead.Enabled   = false;
                    bbiUpdate.Enabled = true;
                    bbiDelete.Enabled = false;
                    bbiReturn.Enabled = true;
                }
                else
                {
                    bbiCreate.Enabled = false;
                    bbiRead.Enabled   = true;
                    bbiUpdate.Enabled = false;
                    bbiDelete.Enabled = false;
                    bbiReturn.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }

        private void InitGrid() 
        {
            try
            {
                gridViewAccessByPrograms.OptionsBehavior.ReadOnly = true;
                gridViewAccessByPrograms.OptionsBehavior.Editable = false;
                gridViewAccessByPrograms.OptionsView.ShowViewCaption = true;
                gridViewAccessByPrograms.OptionsView.ShowAutoFilterRow = true;
                gridViewAccessByPrograms.ActiveFilter.Clear();
                gridViewAccessByPrograms.ViewCaption = "Accesos por Programas";
                gridViewAccessByPrograms.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                gridViewAccessByPrograms.OptionsSelection.MultiSelect = true;

                gridViewAccessByUsers.OptionsBehavior.ReadOnly = true;
                gridViewAccessByUsers.OptionsBehavior.Editable = false;
                gridViewAccessByUsers.OptionsView.ShowViewCaption = true;
                gridViewAccessByUsers.OptionsView.ShowAutoFilterRow = true;
                gridViewAccessByUsers.ActiveFilter.Clear();
                gridViewAccessByUsers.ViewCaption = "Accesos por Usuarios";
                gridViewAccessByUsers.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                gridViewAccessByUsers.OptionsSelection.MultiSelect = true;
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }

        private void LoadGrid()
        {
            try
            {
                Access_Class cl = new Access_Class();
                //gridControlUsers.DataSource = cl.Grid("UsersGrid", cl.parameters);
                //gridControlUsersPermissions.DataSource = cl.Grid("PermissionsGrid", cl.parameters);
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }

        
    }
}