using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualSoftERP.Classes.Utils
{
    public class GridViewHelper_Class
    {
        public static void SetColumnWidthsByPercentage(GridView gridView, Dictionary<string, int> columnWidths)
        {
            try
            {
                int totalWidth = gridView.GridControl.Width;

                foreach (var columnWidth in columnWidths)
                {
                    var columnName = columnWidth.Key;
                    var percentage = columnWidth.Value;

                    var column = gridView.Columns.ColumnByFieldName(columnName);
                    if (column != null)
                    {
                        column.Width = (int)(totalWidth * (percentage / 100.0));
                    }
                }
            }
            catch (Exception ex )
            {
                Modals_Class.ShowError(ex);
            }
        }

    }
}
