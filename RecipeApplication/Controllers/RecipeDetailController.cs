using DataAccess.Concrete.Context;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace RecipeApplication.Controllers
{
    public class RecipeDetailController : Controller
    {
        RecipeContext _recipeContext;

        public RecipeDetailController(RecipeContext recipeContext)
        {
            _recipeContext = recipeContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RecipeDetails(int id)
        {
            var result = _recipeContext.Set<Recipe>().Where(r => r.Id == id).ToList();
            return View(result);
        }
    }
}
