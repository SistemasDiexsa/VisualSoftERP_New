using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
using VisualSoftERP.Models;

namespace VisualSoftERP.Forms.Tools.ProgramControl
{
    public partial class Users_Form : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Users_Model Users = new Users_Model();
        public Users_Form()
        {
            InitializeComponent();
        }


        #region USER INTERACTIONS
        private void Users_Form_Load(object sender, EventArgs e)
        {
            LoadCombos();
            ShowHideButtons(false);
            InitGrid();
            LoadGrid();
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseDefaultWaitForm();
        }
        private void gridViewUsers_Click(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                if (view != null)
                {
                    Users.UsersID = Convert.ToInt32(view.GetRowCellValue(view.FocusedRowHandle, gridColumnUsers_UsersID));
                    Users.Name = view.GetRowCellValue(view.FocusedRowHandle, gridColumnUsers_Name).ToString();
                    Users.Login = view.GetRowCellValue(view.FocusedRowHandle, gridColumnUsers_Login).ToString();
                    Users.Password = view.GetRowCellValue(view.FocusedRowHandle, gridColumnUsers_Password).ToString();
                    Users.UserTypesID = Convert.ToInt32(view.GetRowCellValue(view.FocusedRowHandle, gridColumnUsers_UserTypesID));
                    Users.IsActive = Convert.ToInt32(view.GetRowCellValue(view.FocusedRowHandle, gridColumnUsers_IsActive));
                    Users.IsRemembering = Convert.ToInt32(view.GetRowCellValue(view.FocusedRowHandle, gridColumnUsers_IsRemembering));
                    Users.LastActive = Convert.ToDateTime(view.GetRowCellValue(view.FocusedRowHandle, gridColumnUsers_LastActive));
                    Users.CreateAt = Convert.ToDateTime(view.GetRowCellValue(view.FocusedRowHandle, gridColumnUsers_CreateAt));
                    Users.UpdateAt = Convert.ToDateTime(view.GetRowCellValue(view.FocusedRowHandle, gridColumnUsers_UpdateAt));

                    if (tablePanelGeneral.Rows[0].Height > 0) Read();
                }
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        private void gridViewUsers_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                if (view != null)
                {
                    Users.UsersID = Convert.ToInt32(view.GetRowCellValue(view.FocusedRowHandle, gridColumnUsers_UsersID));
                    Users.Name = view.GetRowCellValue(view.FocusedRowHandle, gridColumnUsers_Name).ToString();
                    Users.Login = view.GetRowCellValue(view.FocusedRowHandle, gridColumnUsers_Login).ToString();
                    Users.Password = view.GetRowCellValue(view.FocusedRowHandle, gridColumnUsers_Password).ToString();
                    Users.UserTypesID = Convert.ToInt32(view.GetRowCellValue(view.FocusedRowHandle, gridColumnUsers_UserTypesID));
                    Users.IsActive = Convert.ToInt32(view.GetRowCellValue(view.FocusedRowHandle, gridColumnUsers_IsActive));
                    Users.IsRemembering = Convert.ToInt32(view.GetRowCellValue(view.FocusedRowHandle, gridColumnUsers_IsRemembering));
                    Users.LastActive = Convert.ToDateTime(view.GetRowCellValue(view.FocusedRowHandle, gridColumnUsers_LastActive));
                    Users.CreateAt = Convert.ToDateTime(view.GetRowCellValue(view.FocusedRowHandle, gridColumnUsers_CreateAt));
                    Users.UpdateAt = Convert.ToDateTime(view.GetRowCellValue(view.FocusedRowHandle, gridColumnUsers_UpdateAt));
                    Read();
                }
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        private void cboUserTypesID_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                LookUpEdit combo = (LookUpEdit)sender;
                if (combo != null)
                {
                    gridViewUsersPermissions.ClearSelection();

                    UserTypes_Class cl = new UserTypes_Class();
                    cl.parameters = new Dictionary<string, object>
                    {
                        { "UserTypesID", combo.EditValue }
                    };

                    DataTable dt = cl.Grid("UserTypesPermissionsGrid", cl.parameters);
                    if (dt.Rows.Count == 1 && dt.Columns.Count == 1)
                    {
                        gridViewUsersPermissions.ClearSelection();
                        string mensaje = dt.Rows[0][0].ToString();
                        Modals_Class.ShowInformation(mensaje);
                    }
                    else if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < gridViewUsersPermissions.RowCount; i++)
                        {
                            int permissionsID = (int)gridViewUsersPermissions.GetRowCellValue(i, "PermissionsID");
                            bool existsInDataTable = dt.AsEnumerable().Any(row => row.Field<int>("PermissionsID") == permissionsID);

                            if (existsInDataTable)
                                gridViewUsersPermissions.SelectRow(i);
                        }
                    }
                    else
                        gridViewUsersPermissions.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        #endregion USER INTERACTIONS


        #region BUTTONS
        private void bbiCreate_ItemClick(object sender, ItemClickEventArgs e)
        {
            Create();
        }
        private void bbiRead_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (Users.UsersID <= 0)
                    Modals_Class.ShowWarning("Seleccione un usuario para ver");
                else
                    Read();
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        private void bbiUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            Save();
        }
        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (Users.UsersID <= 0)
                    Modals_Class.ShowWarning("Seleccione un usuario para eliminar");
                else
                    Delete();
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        private void bbiReturn_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowHideButtons(false);
            ClearBoxes();
        }
        #endregion BUTTONS


        private void LoadCombos()
        {
            try
            {
                Combos_Class cl = new Combos_Class();
                
                #region USER TYPES
                cboUserTypesID.Properties.ValueMember = "UserTypesID";
                cboUserTypesID.Properties.DisplayMember = "Name";
                cboUserTypesID.Properties.DataSource = cl.Grid("UserTypesGrid", cl.parameters);
                cboUserTypesID.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
                cboUserTypesID.Properties.ForceInitialize();
                cboUserTypesID.Properties.PopulateColumns();
                cboUserTypesID.Properties.Columns["UserTypesID"].Visible = false;
                cboUserTypesID.Properties.Columns["CreateAt"].Visible = false;
                cboUserTypesID.Properties.Columns["UpdateAt"].Visible = false;
                cboUserTypesID.Properties.NullText = "Seleccione un rol de usuario";
                cboUserTypesID.EditValue = null;
                #endregion USER TYPES
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
                    bbiCreate.Enabled = true;
                    bbiRead.Enabled = false;
                    bbiUpdate.Enabled = true;
                    bbiDelete.Enabled = true;
                    bbiReturn.Enabled = true;
                    tablePanelGeneral.Rows[0].Height = 125;
                }
                else
                {
                    bbiCreate.Enabled = true;
                    bbiRead.Enabled = true;
                    bbiUpdate.Enabled = false;
                    bbiDelete.Enabled = true;
                    bbiReturn.Enabled = false;
                    tablePanelGeneral.Rows[0].Height = 0;
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
                gridViewUsers.OptionsView.ShowViewCaption = true;
                gridViewUsers.ViewCaption = "Usuarios";
                var columnWidths = new Dictionary<string, int>
                {
                    { gridColumnUsers_UsersID.FieldName, 5 },
                    { gridColumnUsers_Name.FieldName, 30 },
                    { gridColumnUsers_Login.FieldName, 30 },
                    { gridColumnUsers_IsActive.FieldName, 5 },
                    { gridColumnUsers_LastActive.FieldName, 10 },
                    { gridColumnUsers_CreateAt.FieldName, 10 },
                    { gridColumnUsers_UpdateAt.FieldName, 10 }
                };
                GridViewHelper_Class.SetColumnWidthsByPercentage(gridViewUsers, columnWidths);

                gridViewUsersPermissions.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                gridViewUsersPermissions.OptionsSelection.MultiSelect = true;
                gridViewUsersPermissions.OptionsView.ShowViewCaption = true;
                gridViewUsersPermissions.ViewCaption = "Permisos asignados al Usuario";
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
                UserTypes_Class cl = new UserTypes_Class();
                gridControlUsers.DataSource = cl.Grid("UsersGrid", cl.parameters);
                gridControlUsersPermissions.DataSource = cl.Grid("PermissionsGrid", cl.parameters);
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }

        private void ClearBoxes()
        {
            try
            {
                Users = new Users_Model();
                txtName.Text = string.Empty;
                txtLogin.Text = string.Empty;
                txtPassword.Text = string.Empty;
                cboUserTypesID.EditValueChanged -= cboUserTypesID_EditValueChanged;
                cboUserTypesID.EditValue = null;
                cboUserTypesID.EditValueChanged += cboUserTypesID_EditValueChanged;
                swIsActive.IsOn = false;
                gridViewUsersPermissions.ClearSelection();
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }

        private void Create()
        {
            try
            {
                ClearBoxes();
                ShowHideButtons(true);
                Users.UsersID = 0;
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        
        private void Read()
        {
            try
            {
                txtName.Text = Users.Name;
                txtLogin.Text = Users.Login;
                txtPassword.Text = Users.Password;
                swIsActive.IsOn = Users.IsActive == 1;
                cboUserTypesID.EditValue = Users.UserTypesID;
                ShowHideButtons(true);

                gridViewUsersPermissions.ClearSelection();
                Users_Class cl = new Users_Class();
                cl.parameters = new Dictionary<string, object>
                {
                    { "UsersID", Users.UsersID }
                };

                DataTable dt = cl.Grid("UsersPermissionsGrid", cl.parameters);
                if (dt.Rows.Count == 1 && dt.Columns.Count == 1)
                {
                    gridViewUsersPermissions.ClearSelection();
                    string mensaje = dt.Rows[0][0].ToString();
                    Modals_Class.ShowInformation(mensaje);
                }
                else if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < gridViewUsersPermissions.RowCount; i++)
                    {
                        int permissionsID = (int)gridViewUsersPermissions.GetRowCellValue(i, "PermissionsID");
                        bool existsInDataTable = dt.AsEnumerable().Any(row => row.Field<int>("PermissionsID") == permissionsID);

                        if (existsInDataTable)
                            gridViewUsersPermissions.SelectRow(i);
                    }
                }
                else
                    gridViewUsersPermissions.ClearSelection();
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }

        private void Save()
        {
            try
            {
                if (Users.UsersID > 0)
                {
                    DialogResult dialog = Modals_Class.ShowAskConfirmation($"Desea editar al usuario: {Users.Name}");
                    if (dialog != DialogResult.Yes) return;
                }

                Users.Name = txtName.Text;
                Users.Login = txtLogin.Text;
                Users.Password = txtPassword.Text;
                Users.UserTypesID = Convert.ToInt32(cboUserTypesID.EditValue);
                Users.IsActive = swIsActive.IsOn ? 1 : 0;
                Users.IsOnline = 0;
                Users.IsRemembering = 0;
                Users.LastActive = DateTime.Now;
                Users.CreateAt = DateTime.Now;
                Users.UpdateAt = DateTime.Now;

                List<UsersPermissions_Model> list = new List<UsersPermissions_Model>();
                foreach (var row in gridViewUsersPermissions.GetSelectedRows())
                {
                    var permissionsId = gridViewUsersPermissions.GetRowCellValue(row, gridColumnUserPermissions_PermissionsID);
                    var userTypePermission = new UsersPermissions_Model
                    {
                        UsersID = (int)Users.UsersID,
                        PermissionsID = (int)permissionsId
                    };
                    list.Add(userTypePermission);
                };

                Users_Class cl = new Users_Class();
                cl.parameters = new Dictionary<string, object>
                {
                    { "UsersPermissions", list }
                };
                if (cl.Crud("UsersCrud", Users, cl.parameters))
                    gridControlUsers.DataSource = cl.Grid("UsersGrid", new Dictionary<string, object> { });

            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        
        private void Delete()
        {
            try
            {
                DialogResult dialog = Modals_Class.ShowAskConfirmation($"Desea eliminar el usuario {Users.Name}");
                if (dialog != DialogResult.Yes) return;

                Users_Class cl = new Users_Class();
                if (cl.Delete("UsersDelete", Users, cl.parameters))
                    gridControlUsers.DataSource = cl.Grid("UsersGrid", cl.parameters);
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
    }
}