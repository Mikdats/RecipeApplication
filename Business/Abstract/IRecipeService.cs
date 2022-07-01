using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRecipeService
    {
        List<Recipe> GetAll();
        Recipe GetById(int recipeId);
        int Add(Recipe recipe);
        void Delete(Recipe recipe);
        void Update(Recipe recipe);
    }
}
