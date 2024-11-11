using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraExport.Helpers;
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
    public partial class Permissions_Form : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Permissions_Model Permissions = new Permissions_Model();
        public Permissions_Form()
        {
            InitializeComponent();
        }


        #region USER INTERACTIONS
        private void Permissions_Form_Load(object sender, EventArgs e)
        {
            ShowHideButtons(false);
            InitGrid();
            LoadGrid();
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseDefaultWaitForm();
        }
        private void gridViewPermissions_Click(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                if (view != null)
                {
                    Permissions.PermissionsID = Convert.ToInt32(view.GetRowCellValue(view.FocusedRowHandle, gridColumnPermissionsID));
                    Permissions.Name = view.GetRowCellValue(view.FocusedRowHandle, gridColumnName).ToString();
                    Permissions.Description = view.GetRowCellValue(view.FocusedRowHandle, gridColumnDescription).ToString();
                    Permissions.IsActive = view.GetRowCellValue(view.FocusedRowHandle, gridColumnIsActive).ToString() == "Activo" ? 1 : 0;
                    Permissions.CreateAt = Convert.ToDateTime(view.GetRowCellValue(view.FocusedRowHandle, gridColumnCreateAt));
                    Permissions.UpdateAt = Convert.ToDateTime(view.GetRowCellValue(view.FocusedRowHandle, gridColumnUpdateAt));
                    
                    if (tablePanelGeneral.Rows[0].Height > 0) Read();
                }
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        private void gridViewPermissions_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                if (view != null)
                {
                    Permissions.PermissionsID = Convert.ToInt32(view.GetRowCellValue(view.FocusedRowHandle, gridColumnPermissionsID));
                    Permissions.Name = view.GetRowCellValue(view.FocusedRowHandle, gridColumnName).ToString();
                    Permissions.Description = view.GetRowCellValue(view.FocusedRowHandle, gridColumnDescription).ToString();
                    Permissions.IsActive = view.GetRowCellValue(view.FocusedRowHandle, gridColumnIsActive).ToString() == "Activo" ? 1 : 0;
                    Permissions.CreateAt = Convert.ToDateTime(view.GetRowCellValue(view.FocusedRowHandle, gridColumnCreateAt));
                    Permissions.UpdateAt = Convert.ToDateTime(view.GetRowCellValue(view.FocusedRowHandle, gridColumnUpdateAt));
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
                if (Permissions.PermissionsID < 0)
                    Modals_Class.ShowWarning("Seleccione un Permiso para ver");
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
            if (Permissions.PermissionsID < 0)
                Modals_Class.ShowWarning("Seleccione un Permiso para eliminar");
            else
                Delete();
        }
        private void bbiReturn_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowHideButtons(false);
            ClearBoxes();
        }
        #endregion BUTTONS


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
                gridViewPermissions.OptionsView.ShowViewCaption = true;
                gridViewPermissions.ViewCaption = "Permisos";
                var columnWidths = new Dictionary<string, int>
                {
                    { gridColumnPermissionsID.FieldName, 5 },
                    { gridColumnName.FieldName, 30 },
                    { gridColumnDescription.FieldName, 30 },
                    { gridColumnIsActive.FieldName, 5 },
                    { gridColumnCreateAt.FieldName, 15 },
                    { gridColumnUpdateAt.FieldName, 15 }
                };
                GridViewHelper_Class.SetColumnWidthsByPercentage(gridViewPermissions, columnWidths);
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
                Permissions_Class cl = new Permissions_Class();
                gridControlPermissions.DataSource = cl.Grid("PermissionsGrid", cl.parameters);
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
                Permissions = new Permissions_Model();
                txtName.Text = string.Empty;
                swIsActive.IsOn = true;
                txtDescription.Text = string.Empty;
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
                Permissions.PermissionsID = 0;
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
                txtName.Text = Permissions.Name;
                swIsActive.IsOn = Permissions.IsActive == 1 ? true : false;
                txtDescription.Text = Permissions.Description;
                ShowHideButtons(true);
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
                Permissions.Name = txtName.Text;
                Permissions.Description = txtDescription.Text;
                Permissions.IsActive = swIsActive.IsOn ? 1 : 0;
                Permissions.CreateAt = Permissions.PermissionsID == 0 ? DateTime.Now : Permissions.CreateAt;
                Permissions.UpdateAt = DateTime.Now;

                Permissions_Class cl = new Permissions_Class();
                if (cl.Crud("PermissionsCrud", Permissions, cl.parameters))
                    gridControlPermissions.DataSource = cl.Grid("PermissionsGrid", cl.parameters);
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
                DialogResult dialog = Modals_Class.ShowAskConfirmation($"Desea eliminar el permiso {Permissions.PermissionsID.ToString()}");
                if (dialog == DialogResult.Yes)
                {
                    Permissions_Class cl = new Permissions_Class();
                    if (cl.Delete("PermissionsDelete", Permissions, cl.parameters))
                        gridControlPermissions.DataSource = cl.Grid("PermissionsGrid", cl.parameters);
                }
                else return;
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
    }
}