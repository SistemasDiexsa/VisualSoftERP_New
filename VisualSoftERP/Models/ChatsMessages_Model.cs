using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualSoftERP.Models
{
    public class ChatsMessages_Model
    {
        public int ChatsMessagesID { get; set; }
        public int ChatsID { get; set; }
        public int UsersIDSender { get; set; }
        public int UsersIDReceiver { get; set; }
        public string MessageText { get; set; }
        public DateTime SentAt { get; set; }
        public int Seen { get; set; }
    }
}
