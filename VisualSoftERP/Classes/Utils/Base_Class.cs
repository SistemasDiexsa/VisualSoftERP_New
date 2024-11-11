using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VisualSoftERP.Classes.Utils
{
    public abstract class Base_Class
    {
        public Dictionary<string, object> parameters;

        #region METHODS
        //GRID
        public DataTable Grid(string storedProcedure, Dictionary<string, object> parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection cnn = new SqlConnection(Program_Class.cnnString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(storedProcedure, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agrega los parámetros extra
                        if (parameters != null && parameters.Count > 0)
                        {
                            foreach (var param in parameters)
                            {
                                string paramName = "@prm" + param.Key;
                                object paramValue = param.Value ?? DBNull.Value;
                                cmd.Parameters.AddWithValue(paramName, paramValue);
                            }
                        }

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                dt.Columns.Add("ERROR", typeof(string));
                DataRow row = dt.NewRow();
                row["ERROR"] = $"{ex.Message} at line \n\n {new System.Diagnostics.StackTrace(ex, true).GetFrame(0).GetFileLineNumber()}";
                dt.Rows.Add(row);
            }
            return dt;
        }
        //CREATE / UPDATE
        public bool Crud<T>(string storedProcedure, T model, Dictionary<string, object> parameters)
        {
            string prmName = string.Empty;
            string result = string.Empty;
            try
            {
                using (SqlConnection cnn = new SqlConnection(Program_Class.cnnString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(storedProcedure, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agrega el parámetro type
                        if (model != null)
                        {
                            Type modelType = typeof(T);
                            string typeName = modelType.Name.Replace("_Model", "") + "_Type";
                            prmName = modelType.Name.Replace("_Model", "");

                            DataTable table = new DataTable();
                            PropertyInfo[] properties = modelType.GetProperties();
                            foreach (var property in properties)
                            {
                                table.Columns.Add(property.Name, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType);
                            }

                            DataRow row = table.NewRow();
                            foreach (var property in properties)
                            {
                                row[property.Name] = property.GetValue(model, null) ?? DBNull.Value;
                            }
                            table.Rows.Add(row);

                            SqlParameter param = new SqlParameter
                            {
                                ParameterName = "@prm" + prmName,
                                SqlDbType = SqlDbType.Structured,
                                TypeName = "dbo." + typeName,
                                Value = table
                            };

                            cmd.Parameters.Add(param);
                        }

                        // Agrega los parámetros extra
                        if (parameters != null && parameters.Count > 0)
                        {
                            foreach (var param in parameters)
                            {
                                string paramName = "@prm" + param.Key;
                                object paramValue = param.Value ?? DBNull.Value;

                                // Detecta si el parámetro extra es un modelo o una lista de modelos
                                if (paramValue != null)
                                {
                                    Type paramType = paramValue.GetType();
                                    if (paramType.IsClass && paramType != typeof(string))
                                    {
                                        DataTable table = new DataTable();
                                        string typeName;

                                        // Si es una lista de modelos
                                        if (paramValue is IEnumerable<object> paramList)
                                        {
                                            typeName = paramType.GenericTypeArguments[0].Name.Replace("_Model", "") + "_Type";
                                            var properties = paramType.GenericTypeArguments[0].GetProperties();

                                            // Configura columnas
                                            foreach (var property in properties)
                                            {
                                                table.Columns.Add(property.Name, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType);
                                            }

                                            // Agrega cada modelo de la lista al DataTable
                                            foreach (var item in paramList)
                                            {
                                                DataRow row = table.NewRow();
                                                foreach (var property in properties)
                                                {
                                                    row[property.Name] = property.GetValue(item, null) ?? DBNull.Value;
                                                }
                                                table.Rows.Add(row);
                                            }
                                        }
                                        else // Si es un único modelo
                                        {
                                            typeName = paramType.Name.Replace("_Model", "") + "_Type";
                                            var properties = paramType.GetProperties();

                                            // Configura columnas
                                            foreach (var property in properties)
                                            {
                                                table.Columns.Add(property.Name, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType);
                                            }

                                            // Agrega el modelo único al DataTable
                                            DataRow row = table.NewRow();
                                            foreach (var property in properties)
                                            {
                                                row[property.Name] = property.GetValue(paramValue, null) ?? DBNull.Value;
                                            }
                                            table.Rows.Add(row);
                                        }

                                        // Configura el parámetro como Structured
                                        SqlParameter sqlParam = new SqlParameter
                                        {
                                            ParameterName = paramName,
                                            SqlDbType = SqlDbType.Structured,
                                            TypeName = "dbo." + typeName,
                                            Value = table
                                        };
                                        cmd.Parameters.Add(sqlParam);
                                    }
                                    else
                                    {
                                        // Agrega los demás parámetros de forma normal
                                        cmd.Parameters.AddWithValue(paramName, paramValue);
                                    }
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue(paramName, paramValue);
                                }
                            }
                        }

                        // Agrega el parámetro de salida
                        SqlParameter resultParam = new SqlParameter("@result", SqlDbType.NVarChar, -1)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(resultParam);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            result = resultParam.Value.ToString();
                        }
                    }
                }
                if (result == "OK")
                {
                    Modals_Class.ShowSuccess("Guardado Correctamente");
                    return true;
                }
                else
                {
                    Modals_Class.ShowError(result);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
                return false;
            }
        }
        //CREATE / UPDATE --> NO MESSAGE
        public bool CrudNoMessage<T>(string storedProcedure, T model, Dictionary<string, object> parameters)
        {
            string prmName = string.Empty;
            string result = string.Empty;
            try
            {
                using (SqlConnection cnn = new SqlConnection(Program_Class.cnnString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(storedProcedure, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agrega el parámetro type
                        if (model != null)
                        {
                            Type modelType = typeof(T);
                            string typeName = modelType.Name.Replace("_Model", "") + "_Type";
                            prmName = modelType.Name.Replace("_Model", "");

                            DataTable table = new DataTable();
                            PropertyInfo[] properties = modelType.GetProperties();
                            foreach (var property in properties)
                            {
                                table.Columns.Add(property.Name, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType);
                            }

                            DataRow row = table.NewRow();
                            foreach (var property in properties)
                            {
                                row[property.Name] = property.GetValue(model, null) ?? DBNull.Value;
                            }
                            table.Rows.Add(row);

                            SqlParameter param = new SqlParameter
                            {
                                ParameterName = "@prm" + prmName,
                                SqlDbType = SqlDbType.Structured,
                                TypeName = "dbo." + typeName,
                                Value = table
                            };

                            cmd.Parameters.Add(param);
                        }

                        // Agrega los parámetros extra
                        if (parameters != null && parameters.Count > 0)
                        {
                            foreach (var param in parameters)
                            {
                                string paramName = "@prm" + param.Key;
                                object paramValue = param.Value ?? DBNull.Value;

                                // Detecta si el parámetro extra es un modelo o una lista de modelos
                                if (paramValue != null)
                                {
                                    Type paramType = paramValue.GetType();
                                    if (paramType.IsClass && paramType != typeof(string))
                                    {
                                        DataTable table = new DataTable();
                                        string typeName;

                                        // Si es una lista de modelos
                                        if (paramValue is IEnumerable<object> paramList)
                                        {
                                            typeName = paramType.GenericTypeArguments[0].Name.Replace("_Model", "") + "_Type";
                                            var properties = paramType.GenericTypeArguments[0].GetProperties();

                                            // Configura columnas
                                            foreach (var property in properties)
                                            {
                                                table.Columns.Add(property.Name, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType);
                                            }

                                            // Agrega cada modelo de la lista al DataTable
                                            foreach (var item in paramList)
                                            {
                                                DataRow row = table.NewRow();
                                                foreach (var property in properties)
                                                {
                                                    row[property.Name] = property.GetValue(item, null) ?? DBNull.Value;
                                                }
                                                table.Rows.Add(row);
                                            }
                                        }
                                        else // Si es un único modelo
                                        {
                                            typeName = paramType.Name.Replace("_Model", "") + "_Type";
                                            var properties = paramType.GetProperties();

                                            // Configura columnas
                                            foreach (var property in properties)
                                            {
                                                table.Columns.Add(property.Name, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType);
                                            }

                                            // Agrega el modelo único al DataTable
                                            DataRow row = table.NewRow();
                                            foreach (var property in properties)
                                            {
                                                row[property.Name] = property.GetValue(paramValue, null) ?? DBNull.Value;
                                            }
                                            table.Rows.Add(row);
                                        }

                                        // Configura el parámetro como Structured
                                        SqlParameter sqlParam = new SqlParameter
                                        {
                                            ParameterName = paramName,
                                            SqlDbType = SqlDbType.Structured,
                                            TypeName = "dbo." + typeName,
                                            Value = table
                                        };
                                        cmd.Parameters.Add(sqlParam);
                                    }
                                    else
                                    {
                                        // Agrega los demás parámetros de forma normal
                                        cmd.Parameters.AddWithValue(paramName, paramValue);
                                    }
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue(paramName, paramValue);
                                }
                            }
                        }

                        // Agrega el parámetro de salida
                        SqlParameter resultParam = new SqlParameter("@result", SqlDbType.NVarChar, -1)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(resultParam);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            result = resultParam.Value.ToString();
                        }
                    }
                }
                if (result == "OK")
                {
                    return true;
                }
                else
                {
                    Modals_Class.ShowError(result);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
                return false;
            }
        }
        //DELETE
        public bool Delete<T>(string storedProcedure, T model, Dictionary<string, object> parameters)
        {
            string prmName = string.Empty;
            string result = string.Empty;
            try
            {
                using (SqlConnection cnn = new SqlConnection(Program_Class.cnnString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(storedProcedure, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agrega el parámetro type
                        if (model != null)
                        {
                            Type modelType = typeof(T);
                            string typeName = modelType.Name.Replace("_Model", "") + "_Type";
                            prmName = modelType.Name.Replace("_Model", "");

                            DataTable table = new DataTable();
                            PropertyInfo[] properties = modelType.GetProperties();
                            foreach (var property in properties)
                            {
                                table.Columns.Add(property.Name, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType);
                            }

                            DataRow row = table.NewRow();
                            foreach (var property in properties)
                            {
                                row[property.Name] = property.GetValue(model, null) ?? DBNull.Value;
                            }
                            table.Rows.Add(row);

                            SqlParameter param = new SqlParameter
                            {
                                ParameterName = "@prm" + prmName,
                                SqlDbType = SqlDbType.Structured,
                                TypeName = "dbo." + typeName,
                                Value = table
                            };

                            cmd.Parameters.Add(param);
                        }

                        // Agrega los parámetros extra
                        if (parameters != null && parameters.Count > 0)
                        {
                            foreach (var param in parameters)
                            {
                                string paramName = "@prm" + param.Key;
                                object paramValue = param.Value ?? DBNull.Value;
                                cmd.Parameters.AddWithValue(paramName, paramValue);
                            }
                        }

                        // Agrega el parámetro de salida
                        SqlParameter resultParam = new SqlParameter("@result", SqlDbType.NVarChar, 50)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(resultParam);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            result = resultParam.Value.ToString();
                        }
                    }
                }
                if (result == "OK")
                {
                    Modals_Class.ShowSuccess("Eliminado Correctamente");
                    return true;
                }
                else
                {
                    Modals_Class.ShowError(result);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
                return false;
            }

        }
        //READ
        public T Read<T>(string storedProcedure, T model, Dictionary<string, object> parameters) where T : new()
        {
            DataTable dt = new DataTable();
            string prmName = string.Empty;
            try
            {
                using (SqlConnection cnn = new SqlConnection(Program_Class.cnnString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(storedProcedure, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agrega el parámetro type
                        if (model != null)
                        {
                            Type modelType = typeof(T);
                            string typeName = modelType.Name.Replace("_Model", "") + "_Type";
                            prmName = modelType.Name.Replace("_Model", "");

                            DataTable table = new DataTable();
                            PropertyInfo[] properties = modelType.GetProperties();
                            foreach (var property in properties)
                            {
                                table.Columns.Add(property.Name, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType);
                            }

                            DataRow row = table.NewRow();
                            foreach (var property in properties)
                            {
                                row[property.Name] = property.GetValue(model, null) ?? DBNull.Value;
                            }
                            table.Rows.Add(row);

                            SqlParameter param = new SqlParameter
                            {
                                ParameterName = "@prm" + prmName,
                                SqlDbType = SqlDbType.Structured,
                                TypeName = "dbo." + typeName,
                                Value = table
                            };

                            cmd.Parameters.Add(param);
                        }

                        // Agrega los parámetros extra
                        if (parameters != null && parameters.Count > 0)
                        {
                            foreach (var param in parameters)
                            {
                                string paramName = "@prm" + param.Key;
                                object paramValue = param.Value ?? DBNull.Value;
                                cmd.Parameters.AddWithValue(paramName, paramValue);
                            }
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }

                        if (model == null)
                            model = new T();

                        if (dt.Rows.Count == 1 && dt.Columns.Count == 1)
                        {
                            string mensaje = dt.Rows[0][0].ToString();
                            Modals_Class.ShowInformation(mensaje);
                        }
                        else if (dt.Rows.Count > 0)
                        {
                            DataRow row = dt.Rows[0];
                            foreach (var prop in typeof(T).GetProperties())
                            {
                                if (row.Table.Columns.Contains(prop.Name) && row[prop.Name] != DBNull.Value)
                                    prop.SetValue(model, Convert.ChangeType(row[prop.Name], prop.PropertyType));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                var st = new System.Diagnostics.StackTrace(ex, true);
                var frame = st.GetFrame(0);
                var line = frame.GetFileLineNumber();
                throw new Exception($"Error en línea {line}: {ex.Message}", ex);
            }

            return model;
        }
        #endregion METHODS
    }
}
