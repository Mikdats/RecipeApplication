using Business.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace RecipeApplication.Controllers
{
    [Authorize(Roles ="Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly RecipeContext _recipeContext;
        private readonly IRecipeService _recipeService;

        public CategoryController(ICategoryService categoryService, RecipeContext recipeContext, IRecipeService recipeService)
        {
            _categoryService = categoryService;
            _recipeContext = recipeContext;
            _recipeService = recipeService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CategoryDetail(int id)
        {
            var result = _recipeContext.Set<Recipe>().Where(r=>r.CategoryId==id).ToList();
            return View(result);
        }
     
        [HttpGet]
        public IActionResult GetAll(User user)
        {
            var result = _categoryService.GetAll();
            return View(result);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            _categoryService.Add(category);
            return RedirectToAction("GetAll","Category");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var user = _categoryService.GetById(id);
            return View(user);
        }
        [HttpPost]
        public IActionResult Update(Category category)
        {
            _categoryService.Update(category);
            return RedirectToAction("GetAll", "Category");
        }
        public IActionResult Delete(int id)
        {
            var category = _categoryService.GetById(id);
            _categoryService.Delete(category);
            return RedirectToAction("GetAll", "Category");
        }

    }
}
