using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenarateQuizWebUI.Identity;
using GenarateQuizWebUI.Models;


using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GenarateQuizWebUI.Controllers
{
    //[Authorize]
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Register()
        {

            return View(new RegisterModel());
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
          
                return View(model);
            }
            var user = new ApplicationUser
            {
                UserName = model.Username,
                Email = model.EmailAdress,
                FullName = model.FullName,

            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {

                return RedirectToAction("Login", "Account");
            }
            else
            {
                TempData["sifre"] = "Şifre en az 6 Karekter olmalı!  Sayısal değer ve özel karekter içermeli!";
                return View(model);
            }

          
        }
        public IActionResult Login()
        {


            return View(new LoginModel());
          

        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model,string returnUrl)
        {
            returnUrl = returnUrl ?? "~/";
            if (!ModelState.IsValid)
            {

                ModelState.AddModelError("", "Bu kullanıcı Adı ile Daha önce Hessap Oluşturulmamış.");
                return View(model);
            }
            var user = await _userManager.FindByNameAsync(model.Username);
            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password,false,false);

            if (result.Succeeded)
            {
           
                 return  Redirect(returnUrl);

            }
            else
            {
                TempData["Hata"] = "Kullanıcı Adı Veya Şifre Hatalı.";
                return View(model);
            }
            
        }

    }
} 
