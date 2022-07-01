using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Ingredients: IEntity
    {
        public int IngredientsId { get; set; }
        public string IngredientsName { get; set; }      
    }
}
