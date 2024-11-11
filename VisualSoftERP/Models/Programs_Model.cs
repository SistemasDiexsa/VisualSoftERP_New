using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualSoftERP.Models
{
    public class Programs_Model
    {
        public int ProgramsID { get; set; }
        public string Name { get; set; }
        public string RibbonPage { get; set; }
        public string RibbonPageGroup { get; set; }
        public int IsActive { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
