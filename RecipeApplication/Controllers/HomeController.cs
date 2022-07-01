using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace RecipeApplication.Controllers
{
    public class HomeController : Controller
    {
        ICategoryService _categoryService;
        IRecipeService _recipeService;

        public HomeController(IRecipeService recipeService, ICategoryService categoryService)
        {
            _recipeService = recipeService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            ViewBag.categories = _categoryService.GetAll();
            var result = _recipeService.GetAll();
            return View(result);
        }

    }
}
