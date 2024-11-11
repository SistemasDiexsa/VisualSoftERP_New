using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VisualSoftERP.Models
{
    public class Users_Model : Base_Model
    {
        public int UsersID { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int UserTypesID { get; set; }
        public int IsActive { get; set; }
        public int IsOnline { get; set; }
        public int IsRemembering { get; set; }
        public DateTime LastActive { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
