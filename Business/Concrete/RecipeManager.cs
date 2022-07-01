using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RecipeManager : IRecipeService
    {
        IRecipeDal _recipeDal;

        public RecipeManager(IRecipeDal recipeDal)
        {
            _recipeDal = recipeDal;
        }

        public int Add(Recipe recipe)
        {
            _recipeDal.Add(recipe);
            return recipe.Id;
        }

        public void Delete(Recipe recipe)
        {
            _recipeDal.Delete(recipe);
        }

        public List<Recipe> GetAll()
        {
            return _recipeDal.GetAll();
        }

        public Recipe GetById(int recipeId)
        {
            return _recipeDal.Get(r=>r.Id==recipeId);
        }

        public void Update(Recipe recipe)
        {
            _recipeDal.Update(recipe);
        }
    }
}
