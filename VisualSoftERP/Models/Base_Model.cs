using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualSoftERP.Models
{
    public abstract class Base_Model
    {
        #region METHODS
        // CREATE AND RETURNS A NEW MODEL
        public static T Fill<T>(Control container) where T : new()
        {
            T model = new T(); 
            Type modelType = typeof(T);
            PropertyInfo[] properties = modelType.GetProperties();
            string[] prefixes = { "txt", "cbo", "chk", "dtp", "lu", "grid", "edit" };

            foreach (Control ctrl in container.Controls)
            {
                string controlName = ctrl.Name;
                foreach (var prefix in prefixes)
                {
                    if (controlName.StartsWith(prefix, StringComparison.InvariantCultureIgnoreCase))
                    {
                        controlName = controlName.Substring(prefix.Length);
                        break;
                    }
                }

                foreach (var property in properties)
                {
                    if (controlName.Equals(property.Name, StringComparison.InvariantCultureIgnoreCase))
                    {
                        if (property.CanWrite)
                        {
                            object value = null;

                            if (ctrl is TextBox)
                                value = ((TextBox)ctrl).Text;

                            else if (ctrl is TextEdit)
                                value = ((TextEdit)ctrl).Text;
                            
                            else if (ctrl is LookUpEdit)
                                value = ((LookUpEdit)ctrl).EditValue;

                            else if (ctrl is System.Windows.Forms.ComboBox)
                                value = ((System.Windows.Forms.ComboBox)ctrl).SelectedItem;

                            else if (ctrl is ComboBoxEdit)
                                value = ((ComboBoxEdit)ctrl).EditValue;

                            else if (ctrl is CheckBox)
                                value = ((CheckBox)ctrl).Checked;
                            
                            else if (ctrl is DateTimePicker)
                                value = ((DateTimePicker)ctrl).Value;
                            
                            if (value != null && property.PropertyType.IsAssignableFrom(value.GetType()))
                                property.SetValue(model, value);
                        }
                    }
                }
            }
            return model;
        }

        // RETURNS THE EXISTING MODEL BUT FILLING THE NULL PROPERTIES
        public static T Fill<T>(Control container, T existingModel) where T : new()
        {
            Type modelType = typeof(T);
            PropertyInfo[] properties = modelType.GetProperties();
            string[] prefixes = { "txt", "cbo", "chk", "dtp", "lu", "grid", "edit" };

            foreach (Control ctrl in container.Controls)
            {
                string controlName = ctrl.Name;

                // Quitar prefijos del nombre del control
                foreach (var prefix in prefixes)
                {
                    if (controlName.StartsWith(prefix, StringComparison.InvariantCultureIgnoreCase))
                    {
                        controlName = controlName.Substring(prefix.Length);
                        break;
                    }
                }

                foreach (var property in properties)
                {
                    if (controlName.Equals(property.Name, StringComparison.InvariantCultureIgnoreCase))
                    {
                        if (property.CanWrite)
                        {
                            object value = null;

                            if (ctrl is TextBox)
                                value = ((TextBox)ctrl).Text;

                            else if (ctrl is TextEdit)
                                value = ((TextEdit)ctrl).Text;

                            else if (ctrl is LookUpEdit)
                                value = ((LookUpEdit)ctrl).EditValue;

                            else if (ctrl is System.Windows.Forms.ComboBox)
                                value = ((System.Windows.Forms.ComboBox)ctrl).SelectedItem;

                            else if (ctrl is ComboBoxEdit)
                                value = ((ComboBoxEdit)ctrl).EditValue;

                            else if (ctrl is CheckBox)
                                value = ((CheckBox)ctrl).Checked;

                            else if (ctrl is DateTimePicker)
                                value = ((DateTimePicker)ctrl).Value;

                            object currentValue = property.GetValue(existingModel);

                            if (IsDefaultValue(currentValue, property.PropertyType))
                            {
                                if (value != null && property.PropertyType.IsAssignableFrom(value.GetType()))
                                {
                                    property.SetValue(existingModel, value);
                                }
                            }
                        }
                    }
                }
            }
            return existingModel;
        }

        private static bool IsDefaultValue(object value, Type targetType)
        {
            if (value == null) return true;
            
            if (targetType.IsValueType) return value.Equals(Activator.CreateInstance(targetType));
            
            return false;
        }
        #endregion METHODS
    }
}
