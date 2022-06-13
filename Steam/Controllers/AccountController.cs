using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Steam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Steam.Controllers
{
    [Authorize]
    public class AccountController:Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
       
        public AccountController(UserManager<User>userMgr,SignInManager<User>signinMgr)
        {
            userManager = userMgr;
            signInManager = signinMgr;
        }

        [AllowAnonymous]
        public IActionResult Login(String returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View(new LoginViewModel());
        }
        [AllowAnonymous]
        public IActionResult Reg(String returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View(new RegViewModel());
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Reg(RegViewModel model,string returnUrl)
        {
            if(ModelState.IsValid)
            {
                if(model.Username!=null&& model.Password != null&& model.RepeatPassword != null&&model.Agreement!=false)
                {
                    var user = await userManager.FindByNameAsync(model.Username);
                    if(user==null)
                    {
                        user = new User { UserName = model.Username };
                        var res = await userManager.CreateAsync(user,model.Password );
                        if(res.Succeeded)
                        {
                            await userManager.AddToRoleAsync(user, "user");
                            return RedirectToAction("Login", "Account");
                        }
                        else
                        {
                            ModelState.AddModelError(nameof(RegViewModel.Agreement), "Неизвестная ошибка, попробуйте еще раз.");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError(nameof(RegViewModel.Agreement), "Это имя пользователя уже используется, введите другое.");
                    }
                }
                ModelState.AddModelError(nameof(RegViewModel.Agreement), "Корректно заполните все поля.");
            }
            return View(model);
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                User user = await userManager.FindByNameAsync(model.Username);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
                    var res = userManager.IsInRoleAsync(user, "admin");
                    if (result.Succeeded&&res.Result)
                    {
                        return RedirectToAction("Index","admin");
                    }
                    else if(result.Succeeded)
                    {
                        return Redirect(returnUrl ?? "/");
                    }
                }
                ModelState.AddModelError(nameof(LoginViewModel.Username), "");
            }
            return View(model);
        }
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
