using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualSoftERP.Models
{
    public class Chats_Model
    {
        public int ChatsID { get; set; }
        public int UserID1 { get; set; }
        public int UserID2 { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime LastMessageAt { get; set; }
    }
}
