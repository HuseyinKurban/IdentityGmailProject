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
       

        public EfMessageDal(GmailContext context) : base(context)
        {
        }

        public List<Message> GetListInbox(string mail)
        {
            GmailContext context = new GmailContext();
            var values=context.Messages.Where(x=>x.ReceiverMail==mail).ToList();
            return values;
        }
    }
}
