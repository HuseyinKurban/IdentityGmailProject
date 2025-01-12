using IdentityGmailProject.DataAccessLayer.Abstract;
using IdentityGmailProject.DataAccessLayer.Context;
using IdentityGmailProject.DataAccessLayer.Repositories;
using IdentityGmailProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityGmailProject.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(GmailContext context) : base(context)
        {
        }
    }
}
