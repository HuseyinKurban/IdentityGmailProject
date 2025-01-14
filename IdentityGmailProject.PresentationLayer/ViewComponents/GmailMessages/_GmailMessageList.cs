using IdentityGmailProject.BusinessLayer.Abstract;
using IdentityGmailProject.DataAccessLayer.Context;
using IdentityGmailProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityGmailProject.PresentationLayer.ViewComponents.GmailMessages
{

    public class _GmailMessageList : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}