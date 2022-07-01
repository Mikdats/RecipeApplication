using Business.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace RecipeApplication.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        private readonly IUserService _userService;
        private readonly RecipeContext _recipeContext;
        RecipeContext c = new RecipeContext();

        public AdminController(IUserService userService, RecipeContext recipeContext)
        {
            _userService = userService;
            _recipeContext = recipeContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAll(User user)
        {

            var result = _userService.GetAll();
            return View(result);
        }
        [HttpGet]
        public IActionResult Add()
        {
            List<SelectListItem> RoleList = (from x in c.Roles.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.RoleName,
                                                 Value = x.RoleId.ToString()
                                             }).ToList();
            ViewBag.Role = RoleList;
            return View();
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            _userService.Add(user);
            return RedirectToAction("GetAll", "Admin");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var user = _userService.GetById(id);
            return View(user);
        }
        [HttpPost]
        public IActionResult Update(User user)
        {
            _userService.Update(user);
            return RedirectToAction("GetAll", "Admin");
        }
        public IActionResult Delete(int id)
        {
            var user = _userService.GetById(id);
            _userService.Delete(user);
            return RedirectToAction("GetAll", "Admin");
        }
    }
}
