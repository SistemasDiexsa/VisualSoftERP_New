using DevExpress.Utils;
using DevExpress.XtraBars;
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
    public partial class UserTypes_Form : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private UserTypes_Model UserTypes = new UserTypes_Model();
        public UserTypes_Form()
        {
            InitializeComponent();
        }


        #region USER INTERACTIONS
        private void UserTypes_Form_Load(object sender, EventArgs e)
        {
            LoadCombos();
            ShowHideButtons(false);
            InitGrid();
            LoadGrid();
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseDefaultWaitForm();
        }
        private void gridViewUserTypes_Click(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                if (view != null)
                {
                    UserTypes.UserTypesID = Convert.ToInt32(view.GetRowCellValue(view.FocusedRowHandle, gridColumnUserTypesID));
                    UserTypes.Name = view.GetRowCellValue(view.FocusedRowHandle, gridColumnName).ToString();
                    UserTypes.Description = view.GetRowCellValue(view.FocusedRowHandle, gridColumnDescription).ToString();
                    UserTypes.CreateAt = Convert.ToDateTime(view.GetRowCellValue(view.FocusedRowHandle, gridColumnCreateAt));
                    UserTypes.UpdateAt = Convert.ToDateTime(view.GetRowCellValue(view.FocusedRowHandle, gridColumnUpdateAt));

                    if (tablePanelGeneral.Rows[0].Height > 0) Read();
                }
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        private void gridViewUserTypes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                if (view != null)
                {
                    UserTypes.UserTypesID = Convert.ToInt32(view.GetRowCellValue(view.FocusedRowHandle, gridColumnUserTypesID));
                    UserTypes.Name = view.GetRowCellValue(view.FocusedRowHandle, gridColumnName).ToString();
                    UserTypes.Description = view.GetRowCellValue(view.FocusedRowHandle, gridColumnDescription).ToString();
                    UserTypes.CreateAt = Convert.ToDateTime(view.GetRowCellValue(view.FocusedRowHandle, gridColumnCreateAt));
                    UserTypes.UpdateAt = Convert.ToDateTime(view.GetRowCellValue(view.FocusedRowHandle, gridColumnUpdateAt));
                    Read();
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
                if (UserTypes.UserTypesID < 0)
                    Modals_Class.ShowWarning("Seleccione un rol de usuario para ver");
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
                if (UserTypes.UserTypesID < 0)
                    Modals_Class.ShowWarning("Seleccione un rol de usuario para eliminar");
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
                #endregion USER TYPES

                #region PERMISSIONS
                #endregion PERMISSIONS
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
                gridViewUserTypes.OptionsView.ShowViewCaption = true;
                gridViewUserTypes.ViewCaption = "Roles de Usuario";
                var columnWidths = new Dictionary<string, int>
                {
                    { gridColumnUserTypesID.FieldName, 5 },
                    { gridColumnName.FieldName, 35 },
                    { gridColumnDescription.FieldName, 30 },
                    { gridColumnCreateAt.FieldName, 15 },
                    { gridColumnUpdateAt.FieldName, 15 }
                };
                GridViewHelper_Class.SetColumnWidthsByPercentage(gridViewUserTypes, columnWidths);
                
                gridViewUserTypesPermissions.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                gridViewUserTypesPermissions.OptionsSelection.MultiSelect = true;
                gridViewUserTypesPermissions.OptionsView.ShowViewCaption = true;
                gridViewUserTypesPermissions.ViewCaption = "Permisos asignados al Rol de Usuario";
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
                gridControlUserTypes.DataSource = cl.Grid("UserTypesGrid", cl.parameters);
                gridControlUserTypesPermissions.DataSource = cl.Grid("PermissionsGrid", cl.parameters);
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
                UserTypes = new UserTypes_Model();
                txtName.Text = string.Empty;
                txtDescription.Text = string.Empty;
                gridViewUserTypesPermissions.ClearSelection();
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
                UserTypes.UserTypesID = 0;
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
                txtName.Text = UserTypes.Name;
                txtDescription.Text = UserTypes.Description;
                ShowHideButtons(true);

                gridViewUserTypesPermissions.ClearSelection();

                UserTypes_Class cl = new UserTypes_Class();
                cl.parameters = new Dictionary<string, object>
                {
                    { "UserTypesID", UserTypes.UserTypesID }
                };

                DataTable dt = cl.Grid("UserTypesPermissionsGrid", cl.parameters);
                if (dt.Rows.Count == 1 && dt.Columns.Count == 1)
                {
                    gridViewUserTypesPermissions.ClearSelection();
                    string mensaje = dt.Rows[0][0].ToString();
                    Modals_Class.ShowInformation(mensaje);
                }
                else if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < gridViewUserTypesPermissions.RowCount; i++)
                    {
                        int permissionsID = (int)gridViewUserTypesPermissions.GetRowCellValue(i, "PermissionsID");
                        bool existsInDataTable = dt.AsEnumerable().Any(row => row.Field<int>("PermissionsID") == permissionsID);

                        if (existsInDataTable)
                            gridViewUserTypesPermissions.SelectRow(i);
                    }
                }
                else
                    gridViewUserTypesPermissions.ClearSelection();
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
                if (UserTypes.UserTypesID > 0)
                {
                    DialogResult dialog = Modals_Class.ShowAskConfirmation($"Desea editar el rol de usuario {UserTypes.Name}");
                    if (dialog != DialogResult.Yes) return;
                }


                UserTypes.Name = txtName.Text;
                UserTypes.Description = txtDescription.Text;
                UserTypes.CreateAt = DateTime.Now;
                UserTypes.UpdateAt = DateTime.Now;

                List<UserTypesPermissions_Model> list = new List<UserTypesPermissions_Model>();
                foreach (var row in gridViewUserTypesPermissions.GetSelectedRows())
                {
                    var permissionsId = gridViewUserTypesPermissions.GetRowCellValue(row, gridColumnUserTypePermissions_PermissionsID);
                    var userTypePermission = new UserTypesPermissions_Model
                    {
                        UserTypesID = (int)UserTypes.UserTypesID,
                        PermissionsID = (int)permissionsId
                    };
                    list.Add(userTypePermission);
                };

                UserTypes_Class cl = new UserTypes_Class();
                cl.parameters = new Dictionary<string, object>
                {
                    { "UserTypesPermissions", list }
                };
                if (cl.Crud("UserTypesCrud", UserTypes, cl.parameters))
                    gridControlUserTypes.DataSource = cl.Grid("UserTypesGrid", new Dictionary<string, object> { });
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
                DialogResult dialog = Modals_Class.ShowAskConfirmation($"Desea eliminar el rol de usuario {UserTypes.Name}");
                if (dialog != DialogResult.Yes) return;
                
                Permissions_Class cl = new Permissions_Class();
                if (cl.Delete("UserTypesDelete", UserTypes, cl.parameters))
                    gridControlUserTypes.DataSource = cl.Grid("UserTypesGrid", cl.parameters);
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
    }
}