using IdentityGmailProject.DataAccessLayer.Abstract;
using IdentityGmailProject.DataAccessLayer.Context;
using IdentityGmailProject.DataAccessLayer.Repositories;
using IdentityGmailProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityGmailProject.DataAccessLayer.EntityFramework
{
    public class EfMessageDal : GenericRepository<Message>, IMessageDal
    {
       private readonly GmailContext context;

        public EfMessageDal(GmailContext _context) : base(_context)
        {
            context=_context;
        }

        public List<Message> GetListInbox(int id)
        {
          
            var values=context.Messages.Where(x=>x.ReceiverId==id).OrderByDescending(y=>y.MessageDate).Include(x=>x.Sender).Include(c=>c.Category).ToList();
            return values;
        }

        public List<Message> GetListSendbox(int id)
        {
            var values = context.Messages.Where(x => x.SenderId == id).OrderByDescending(y => y.MessageDate).Include(x => x.Receiver).Include(c => c.Category).ToList();
            return values;
        }
    }
}
