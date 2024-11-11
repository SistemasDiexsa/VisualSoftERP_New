using DevExpress.Utils.DirectXPaint.Svg;
using DevExpress.XtraBars;
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
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace VisualSoftERP.Forms.Tools.ProgramControl
{
    public partial class Programs_Form : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Programs_Model Programs = new Programs_Model();
        private class Item
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
        private List<Item> Pages = new List<Item>
        {
            new Item { ID = 1, Name = "ribbonPagePurchases"},
            new Item { ID = 2, Name = "ribbonPageAccountsPayable"},
            new Item { ID = 3, Name = "ribbonPageInventory"},
            new Item { ID = 4, Name = "ribbonPageSales"},
            new Item { ID = 5, Name = "ribbonPageAccountsReceivable"},
            new Item { ID = 6, Name = "ribbonPageAccounting"},
            new Item { ID = 7, Name = "ribbonPageBI"},
            new Item { ID = 8, Name = "ribbonPageStore"},
            new Item { ID = 9, Name = "ribbonPageCCP"},
            new Item { ID = 10, Name = "ribbonPageTools"}
        };
        private Dictionary<int, List<Item>> Groups = new Dictionary<int, List<Item>>
        {
            {
                1, new List<Item>
                {
                    new Item { ID = 1, Name = "ribbonPageGroupPurchaseOperations" },
                    new Item { ID = 2, Name = "ribbonPageGroupPurchaseReports" }
                }
            },
            {
                2, new List<Item>
                {
                    new Item { ID = 1, Name = "ribbonPageGroupAccountsPayableCatalog" },
                    new Item { ID = 2, Name = "ribbonPageGroupAccountsPayableOperations" },
                    new Item { ID = 3, Name = "ribbonPageGroupAccountsPayableReports"}
                }
            },
            {
                3, new List<Item>
                {
                    new Item { ID = 1, Name = "ribbonPageGroupInventoryCatalogs" },
                    new Item { ID = 2, Name = "ribbonPageGroupInventoryOperations"},
                    new Item { ID = 3, Name = "ribbonPageGroupInventoryReports" },
                }
            },
            {
                4, new List<Item>
                {
                    new Item { ID = 1, Name = "ribbonPageGroupSalesCatalogs" },
                    new Item { ID = 2, Name = "ribbonPageGroupSalesOperations" },
                    new Item { ID = 3, Name = "ribbonPageGroupSalesReports"}
                }
            },
            {
                5, new List<Item>
                {
                    new Item { ID = 1, Name = "ribbonPageGroupAccountsReceivableCatalogs" },
                    new Item { ID = 2, Name = "ribbonPageGroupAccountsReceivableOperations" },
                    new Item { ID = 3, Name = "ribbonPageGroupAccountsReceivableReports"}
                }
            },
            {
                6, new List<Item>
                {
                    new Item { ID = 1, Name = "ribbonPageGroupAccountingCatalogs" }
                }
            },
            {
                7, new List<Item>
                {
                    new Item { ID = 1, Name = "ribbonPageGroupBusinessInteligence" }
                }
            },
            {
                8, new List<Item>
                {
                    new Item { ID = 1, Name = "ribbonPageGroupStoreCatalogs" },
                    new Item { ID = 2, Name = "ribbonPageGroupOperations" }
                }
            },
            {
                9, new List<Item>
                {
                    new Item { ID = 1, Name = "ribbonPageGroupCCP" }
                }
            },
            {
                10, new List<Item>
                {
                    new Item { ID = 1, Name = "ribbonPageGroupSoftwareControl" },
                    new Item { ID = 2, Name = "ribbonPageGroupInformationSending" },
                    new Item { ID = 3, Name = "ribbonPageGroupSAT" },
                    new Item { ID = 4, Name = "ribbonPageGroupInquiries" }
                }
            }
        };

        public Programs_Form()
        {
            InitializeComponent();
        }


        #region USER INTERACTIONS
        private void Programs_Form_Load(object sender, EventArgs e)
        {
            LoadCombos();
            ShowHideButtons(false);
            InitGrid();
            LoadGrid();
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseDefaultWaitForm();
        }
        private void gridViewPrograms_Click(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                if (view != null)
                {
                    if (view.FocusedRowHandle >= 0)
                    {
                        Programs.ProgramsID = Convert.ToInt32(view.GetRowCellValue(view.FocusedRowHandle, gridColumnProgramsID));
                        Programs.Name = view.GetRowCellValue(view.FocusedRowHandle, gridColumnName).ToString();
                        Programs.RibbonPage = view.GetRowCellValue(view.FocusedRowHandle, gridColumnRibbonPage).ToString();
                        Programs.RibbonPageGroup = view.GetRowCellValue(view.FocusedRowHandle, gridColumnRibbonPageGroup).ToString();
                        Programs.IsActive = Convert.ToInt32(view.GetRowCellValue(view.FocusedRowHandle, gridColumnIsActive));
                        Programs.CreateAt = Convert.ToDateTime(view.GetRowCellValue(view.FocusedRowHandle, gridColumnCreateAt));
                        Programs.UpdateAt = Convert.ToDateTime(view.GetRowCellValue(view.FocusedRowHandle, gridColumnUpdateAt));

                        if (tablePanelGeneral.Rows[0].Height > 0) Read();
                    }
                }
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        private void gridViewPrograms_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                if (view != null)
                {
                    Programs.ProgramsID = Convert.ToInt32(view.GetRowCellValue(view.FocusedRowHandle, gridColumnProgramsID));
                    Programs.Name = view.GetRowCellValue(view.FocusedRowHandle, gridColumnName).ToString();
                    Programs.RibbonPage = view.GetRowCellValue(view.FocusedRowHandle, gridColumnRibbonPage).ToString();
                    Programs.RibbonPageGroup = view.GetRowCellValue(view.FocusedRowHandle, gridColumnRibbonPageGroup).ToString();
                    Programs.IsActive = Convert.ToInt32(view.GetRowCellValue(view.FocusedRowHandle, gridColumnIsActive));
                    Programs.CreateAt = Convert.ToDateTime(view.GetRowCellValue(view.FocusedRowHandle, gridColumnCreateAt));
                    Programs.UpdateAt = Convert.ToDateTime(view.GetRowCellValue(view.FocusedRowHandle, gridColumnUpdateAt)); 
                    
                    Read();
                }
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }
        private void cboRibbonPage_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                LookUpEdit cbo = (LookUpEdit)sender;
                if (cbo != null)
                {
                    int selectedID = Convert.ToInt32(cbo.EditValue);
                    if (Groups.ContainsKey(selectedID))
                    {
                        cboRibbonPageGroup.Properties.DataSource = Groups[selectedID];
                        cboRibbonPageGroup.Properties.ValueMember = "ID";
                        cboRibbonPageGroup.Properties.DisplayMember = "Name";
                        cboRibbonPageGroup.Properties.PopulateColumns();
                        cboRibbonPageGroup.Properties.ForceInitialize();
                        cboRibbonPageGroup.Properties.Columns["ID"].Visible = false;
                        cboRibbonPageGroup.Properties.NullText = "Seleccione un Grupo";
                        cboRibbonPageGroup.EditValue = null;
                    }
                    else
                        cboRibbonPageGroup.Properties.DataSource = null;
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
                if (Programs.ProgramsID <= 0)
                    Modals_Class.ShowWarning("Seleccione un programa para ver");
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
                if (Programs.ProgramsID <= 0)
                    Modals_Class.ShowWarning("Seleccione un programa para eliminar");
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
                #region RIBBON PAGE
                cboRibbonPage.Properties.ValueMember = "ID";
                cboRibbonPage.Properties.DisplayMember = "Name";
                cboRibbonPage.Properties.DataSource = Pages;
                cboRibbonPage.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
                cboRibbonPage.Properties.ForceInitialize();
                cboRibbonPage.Properties.PopulateColumns();
                cboRibbonPage.Properties.NullText = "Seleccione una pestaña";
                cboRibbonPage.EditValue = null;
                cboRibbonPage.Properties.Columns["ID"].Visible = false;
                #endregion RIBBON PAGE

                #region RIBBON PAGE GROUP
                cboRibbonPageGroup.Properties.NullText = "Primero seleccione una pestaña";
                cboRibbonPageGroup.EditValue = null;
                #endregion RIBBON PAGE GROUP
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
                gridViewPrograms.OptionsView.ShowViewCaption = true;
                gridViewPrograms.ViewCaption = "Programas";
                var columnWidths = new Dictionary<string, int>
                {
                    { gridColumnProgramsID.FieldName, 5 },
                    { gridColumnName.FieldName, 35 },
                    { gridColumnRibbonPage.FieldName, 15 },
                    { gridColumnRibbonPageGroup.FieldName, 15 },
                    { gridColumnTextIsActive.FieldName, 10 },
                    { gridColumnCreateAt.FieldName, 10 },
                    { gridColumnUpdateAt.FieldName, 10 }
                };
                GridViewHelper_Class.SetColumnWidthsByPercentage(gridViewPrograms, columnWidths);
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
                gridControlPrograms.DataSource = cl.Grid("ProgramsGrid", cl.parameters);
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
                Programs = new Programs_Model();
                txtName.Text = string.Empty;
                cboRibbonPage.EditValue = null;
                cboRibbonPageGroup.EditValue = null;
                swIsActive.IsOn = false;
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
                Programs.ProgramsID = 0;
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
                txtName.Text = Programs.Name;
                
                Item match = Pages.FirstOrDefault(item => item.Name == Programs.RibbonPage);
                if (match != null)
                    cboRibbonPage.EditValue = match.ID;

                Item matchs = Groups[match.ID].FirstOrDefault(item => item.Name == Programs.RibbonPageGroup);
                if (matchs != null)
                    cboRibbonPageGroup.EditValue = matchs.ID;

                swIsActive.IsOn = Programs.IsActive == 1;
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

            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
            }
        }

        
    }
}