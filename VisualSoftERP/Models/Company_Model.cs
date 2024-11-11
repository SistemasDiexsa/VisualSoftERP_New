using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualSoftERP.Models
{
    public class Company_Model : Base_Model
    {
		public int CompanyID { get; set; }
		public string CompanyName { get; set; }
		public string CompanyRFC { get; set; }
		public string CompanyAddress { get; set; }
		public string CompanyPhone { get; set; }
		public string CompanyEmail { get; set; }
		public string CompanyPage { get; set; }
		public string CompanyBusinessName { get; set; }
		public string CompanyBottonEmail { get; set; }
		public string CompanyEmailCxC { get; set; }
		public string CompanyStoreAddress { get; set; }
		public DateTime CreateAt { get; set; }
		public DateTime UpdateAt { get; set; }
    }
}
