using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using VisualSoftERP.Classes.Utils;
using VisualSoftERP.Models;

namespace VisualSoftERP.Classes
{
    public class Wizzard_Class : Base_Class
    {
        #region METHODS
        public bool CreateFirstUser()
        {
            try
            {
                Users_Model firstUser = new Users_Model{
                    UsersID = 0,
                    Name = "Administrator",
                    Login = "Admin",
                    Password = "Admin",
                    UserTypesID = 1,
                    IsActive = 1,
                    IsRemembering = 0,
                    LastActive = DateTime.Now,
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now
                };
                List<UserTypesPermissions_Model> list = new List<UserTypesPermissions_Model>();
                this.parameters = new Dictionary<string, object>
                {
                    { "UsersPermissions", list }
                };

                if (!this.Crud("UsersCrud", firstUser, this.parameters)) { return false; }
                else { return true; }
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
