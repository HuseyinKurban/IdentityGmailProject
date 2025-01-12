using IdentityGmailProject.EntityLayer.Concrete;
using IdentityGmailProject.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityGmailProject.PresentationLayer.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public ProfileController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
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
