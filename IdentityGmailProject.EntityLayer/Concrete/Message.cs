using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityGmailProject.EntityLayer.Concrete
{
    public class Message
    {
       
        public int MessageID { get; set; }
     
        public string SenderMail { get; set; }
     
        public string ReceiverMail { get; set; }
    
        public string Subject { get; set; }

        public bool Status { get; set; }

        public string MessageContent { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public DateTime MessageDate { get; set; }
    }
}
