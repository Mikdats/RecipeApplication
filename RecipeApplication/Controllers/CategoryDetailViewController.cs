using Business.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace RecipeApplication.Controllers
{
    public class CategoryDetailViewController : Controller
    {
        ICategoryService _categoryService;
        RecipeContext _recipeContext;

        public CategoryDetailViewController(ICategoryService categoryService, RecipeContext recipeContext)
        {
            _categoryService = categoryService;
            _recipeContext = recipeContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CategoryDetailViews(int id)
        {
            ViewBag.categories = _categoryService.GetAll();
            var result = _recipeContext.Set<Recipe>().Where(r => r.CategoryId == id).ToList();
            return View(result);
        }
    }
}
