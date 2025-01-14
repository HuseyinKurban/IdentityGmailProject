using IdentityGmailProject.BusinessLayer.Abstract;
using IdentityGmailProject.EntityLayer.Concrete;
using IdentityGmailProject.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging.Signing;

namespace IdentityGmailProject.PresentationLayer.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IMessageService _messageService;

        public ProfileController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IMessageService messageService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
           _messageService = messageService;
        }

        [HttpGet]
        public async Task<IActionResult> MyProfile()
        {
           

            var values = await _userManager.FindByNameAsync(User.Identity.Name);

           AppUserEdit appUserEdit=new AppUserEdit();
            appUserEdit.Name = values.Name;
            appUserEdit.Surname = values.Surname;
            appUserEdit.ProfilImageUrl = values.ProfilImageUrl;
            appUserEdit.CoverImageUrl = values.CoverImageUrl;
            appUserEdit.Job= values.Job;
            appUserEdit.Detail=values.Detail;
            appUserEdit.UserName=values.UserName;
            appUserEdit.Email=values.Email;
       
           
            return View(appUserEdit);
        }

        [HttpPost]
        public async Task<IActionResult> MyProfile(AppUserEdit model)
        {
          
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.Name = model.Name;
                user.Surname = model.Surname;
                user.ProfilImageUrl = model.ProfilImageUrl;
                user.CoverImageUrl = model.CoverImageUrl;
                user.Job = model.Job;
                user.Detail = model.Detail;
                user.Email = model.Email;
                user.UserName = model.UserName;
               
                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
            

            return View();

        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    }
}
