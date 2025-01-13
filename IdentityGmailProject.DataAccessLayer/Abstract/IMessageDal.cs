using IdentityGmailProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityGmailProject.DataAccessLayer.Abstract
{
    public interface IMessageDal:IGenericDal<Message>
    {
        List<Message> GetListInbox(int id);
        List<Message> GetListSendbox(int id);

        Message GetInboxMessageDetails(int id);
        Message GetSendboxMessageDetails(int id);

    }
}
