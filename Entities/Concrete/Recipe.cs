using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Recipe: IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }     
        public string Image { get; set; }
        public string Detail { get; set; }
        public Category Category { get; set; }
        
    }
}
