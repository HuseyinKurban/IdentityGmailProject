﻿using IdentityGmailProject.EntityLayer.Concrete;
using IdentityGmailProject.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityGmailProject.PresentationLayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(LoginViewModel model)
        {
            //persistent= beni hatırla , cookie kısmında saklıyor.
            //lockoutonfailure=belli hatalı girişten sonra belli bir süre tanımlama, bu süre aktif olsunmu demek
            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, true);
            if (result.Succeeded)
            {
                return RedirectToAction("MyProfile", "Profile");
          

            }
            else
            {
                return View();
            }
        }
    }
}