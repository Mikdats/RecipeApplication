using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RecipeApplication.Controllers
{
    public class UserController : Controller
    {
        private readonly RecipeContext _recipeContext;
        //private readonly IUserService _userService;
        

        public UserController(RecipeContext recipeContext)
        {
            _recipeContext = recipeContext;          
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index([Bind("Email", "Password")] UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                ClaimsIdentity identity = null;
                bool isAuthenticated = false;
                User user = await _recipeContext.Users.Include(k => k.Role).FirstOrDefaultAsync(m => m.Email == userViewModel.Email && m.Password == userViewModel.Password);
                if (user == null)
                {
                    ModelState.AddModelError("Error1", "Kullanıcı bulunamadı.");
                    return View();
                }

                identity = new ClaimsIdentity(
                    new[]
                    {
                        new Claim(ClaimTypes.Sid,user.UserId.ToString()),
                        new Claim(ClaimTypes.Email,user.Email),
                        new Claim(ClaimTypes.Role,user.Role.RoleName),
                    }, CookieAuthenticationDefaults.AuthenticationScheme
                    );
                isAuthenticated = true;
                if (isAuthenticated)
                {
                    var claim = new ClaimsPrincipal(identity);
                    var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claim,

                        new AuthenticationProperties
                        {
                            IsPersistent = true,
                            ExpiresUtc = DateTime.Now.AddMinutes(60)
                        });
                    var data = userViewModel.Email.ToString();
                    TempData["Email"] = data;

                    if (user.Role.RoleName == "Admin")
                    {
                        return Redirect("~/Admin/GetAll");
                    }
                    else if (user.Role.RoleName == "Moderator")
                    {                       
                        return RedirectToAction("GetAll","Recipe");
                    }
                    else
                    {
                        return Redirect("~/Home/ErrorPage");
                    }
                }

            }
            return View(userViewModel);
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index","Home");
        }
        
    }
}
