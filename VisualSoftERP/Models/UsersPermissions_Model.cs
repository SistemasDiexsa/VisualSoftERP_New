using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualSoftERP.Models
{
    public class UsersPermissions_Model : Base_Model
    {
        public int UsersID { get; set; }
        public int PermissionsID { get; set; }
    }
}
