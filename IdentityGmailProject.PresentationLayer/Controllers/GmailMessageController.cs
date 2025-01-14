using IdentityGmailProject.BusinessLayer.Abstract;
using IdentityGmailProject.BusinessLayer.Concrete;
using IdentityGmailProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace IdentityGmailProject.PresentationLayer.Controllers
{
    public class GmailMessageController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMessageService _messageService;
        private readonly ICategoryService _categoryService;
        private readonly IAppUserService _userService;

        public GmailMessageController(UserManager<AppUser> userManager, IMessageService messageService, ICategoryService categoryService, IAppUserService userService)
        {
            _userManager = userManager;
            _messageService = messageService;
            _categoryService = categoryService;
            _userService = userService;
        }

        public async Task<IActionResult> Inbox()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var id=user.Id;
            
           
            if (user != null)
            {
                var values = _messageService.TGetListInbox(id);
                return View(values);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public async Task<IActionResult> Sendbox()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var id = user.Id;

            if (user != null)
            {
                var values = _messageService.TGetListSendbox(id);
                return View(values);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        [HttpGet]
        public async Task<IActionResult> NewMessage()
        {
            var categoryList = _categoryService.TGetAll();
            List<SelectListItem> values1 = (from x in categoryList
                                            select new SelectListItem
                                            {
                                                Text = x.CategoryName,
                                                Value = x.CategoryId.ToString()
                                            }).ToList();

            //giriş yapan kullanıcı bilgilerini almıyorum
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var userList = _userService.TGetAll().Where(x => x.Id != user.Id).ToList(); ;
            List<SelectListItem> values2 = (from x in userList
                                            select new SelectListItem
                                            {
                                                Text = x.Email,
                                                Value = x.Id.ToString()
                                            }).ToList();

          
            ViewBag.v1 = values1;
            ViewBag.v2 = values2;
            return View();
        }

   

        [HttpPost]
        public async Task<IActionResult> NewMessage(Message message)
        {
            var userValue = await _userManager.FindByNameAsync(User.Identity.Name);
            message.SenderId=userValue.Id;
            message.MessageDate=DateTime.Now;

            _messageService.TInsert(message);
            return RedirectToAction("Sendbox");
        }

        public  IActionResult InboxMessageDetails(int id)
        {
        
            var values = _messageService.TGetInboxMessageDetails(id);
            return View(values);
        }

        public IActionResult SendboxMessageDetails(int id)
        {
        
            var values = _messageService.TGetSendboxMessageDetails(id);
            return View(values);
        }
    }
}
