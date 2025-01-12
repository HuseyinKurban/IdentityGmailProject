using IdentityGmailProject.BusinessLayer.Concrete;
using IdentityGmailProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityGmailProject.PresentationLayer.Controllers
{
    public class GmailMessageController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly MessageManager _messageManager;

        public GmailMessageController(MessageManager messageManager, UserManager<AppUser> userManager)
        {
            _messageManager = messageManager;
            _userManager = userManager;
        }

        public async Task<IActionResult> Inbox()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (user != null)
            {
                var values = _messageManager.TGetListInbox(user.Email);
                return View(values);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}
