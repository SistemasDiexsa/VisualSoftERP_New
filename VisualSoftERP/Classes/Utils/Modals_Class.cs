using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualSoftERP.Classes.Utils
{
    public class Modals_Class
    {
        #region METHODS
        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowError(Exception ex)
        {
            var st = new System.Diagnostics.StackTrace(ex, true);
            var frame = st.GetFrame(0);
            var line = frame.GetFileLineNumber();
            string message = $"Error en línea {line}: {ex.Message}";
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowSuccess(string message)
        {
            MessageBox.Show(message, "", MessageBoxButtons.OK);
        }
        public static void ShowInformation(string message)
        {
            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowWarning(string message)
        {
            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static DialogResult ShowAskConfirmation(string message)
        {
            DialogResult dialog = MessageBox.Show(message, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return dialog;
        }
        #endregion METHODS
    }
}
