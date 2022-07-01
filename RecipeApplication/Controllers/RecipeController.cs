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
    [Authorize(Roles = "Moderator")]
    public class Material
    {
        public int IngredientsId { get; set; }
        public int Slug { get; set; }
    }
    public class RecipeController : Controller
    {
        private readonly IRecipeService _recipeService;
        private readonly RecipeContext _recipeContext;
      
        RecipeContext c = new RecipeContext();

        public RecipeController(IRecipeService recipeService, RecipeContext recipeContext)
        {
            _recipeService = recipeService;
            _recipeContext = recipeContext;       
        }

        public static List<Material> materials = new List<Material>();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAll(Recipe recipe)
        {        
            var recipes = _recipeService.GetAll();
            return View(recipes);
        }
        public IActionResult Add()
        {
            List<SelectListItem> CategoryList = (from x in c.Categories.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.CategoryName,
                                                 Value = x.CategoryId.ToString()
                                             }).ToList();
            ViewBag.List = CategoryList;
            return View();
        }
        [HttpPost]
        public IActionResult Add(Recipe recipe)
        {
            _recipeService.Add(recipe);
            return RedirectToAction("GetAll","Recipe");
        }           

        [HttpGet]
        public IActionResult Update(int id)
        {
            var user = _recipeService.GetById(id);
            return View(user);
        }
        [HttpPost]
        public IActionResult Update(Recipe recipe)
        {
            _recipeService.Update(recipe);
            return RedirectToAction("GetAll", "Recipe");
        }
        public IActionResult Delete(int id)
        {
            var recipe = _recipeService.GetById(id);
            _recipeService.Delete(recipe);
            return RedirectToAction("GetAll", "Recipe");
        }

    }
}
