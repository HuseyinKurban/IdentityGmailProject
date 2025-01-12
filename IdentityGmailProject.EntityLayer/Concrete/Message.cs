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

        public string Title { get; set; }

        public bool IsRead { get; set; }

        public string MessageContent { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public DateTime MessageDate { get; set; }

        public int SenderId { get; set; }
        public AppUser Sender { get; set; }

        public int ReceiverId { get; set; }
        public AppUser Receiver { get; set; }
    }
}
