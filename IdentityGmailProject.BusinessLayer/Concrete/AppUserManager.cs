﻿using IdentityGmailProject.BusinessLayer.Abstract;
using IdentityGmailProject.DataAccessLayer.Abstract;
using IdentityGmailProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityGmailProject.BusinessLayer.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void TDelete(int id)
        {
           _appUserDal.Delete(id);
        }

        public List<AppUser> TGetAll()
        {
           return _appUserDal.GetAll();
        }

        public AppUser TGetById(int id)
        {
            return _appUserDal.GetById(id);
        }

        public void TInsert(AppUser entity)
        {
           _appUserDal.Insert(entity);
        }

        public void TUpdate(AppUser entity)
        {
           _appUserDal.Update(entity);
        }
    }
}
