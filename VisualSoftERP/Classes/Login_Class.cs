using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualSoftERP.Classes.Utils;
using VisualSoftERP.Models;

namespace VisualSoftERP.Classes
{
    public class Login_Class : Base_Class
    {
        #region PROPERTIES
        public Users_Model User;
        #endregion PROPERTIES


        #region METHODS
        public bool UsersCheckLogIn()
        {
            try
            {
                User = this.Read<Users_Model>("UsersCheckLogIn", null, parameters);

                if (User.UsersID > 0) return true;
                else return false;
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
                return false;
            }
        }

        public bool LogIn()
        {
            try
            {
                User = this.Read<Users_Model>("UsersLogIn", null, parameters);

                if (User.UsersID > 0) return true;
                else return false;
            }
            catch (Exception ex)
            {
                Modals_Class.ShowError(ex);
                return false;
            }
        }
        #endregion METHODS
    }
}
