using IdentityGmailProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityGmailProject.BusinessLayer.Abstract
{
    public interface IMessageService : IGenericService<Message>
    {
        List<Message> TGetListInbox(int id);
        List<Message> TGetListSendbox(int id);

        Message TGetInboxMessageDetails(int id);
        Message TGetSendboxMessageDetails(int id);
    }
}
