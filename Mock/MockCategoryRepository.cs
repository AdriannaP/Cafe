using Cafe.Interfaces;
using Cafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe.Mock
{ 
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{ CategoryName = "WhiteCoffee", Descripition = "All White Coffees"},
                    new Category{ CategoryName = "BlackCoffee", Descripition = "All Black Coffees"},
                };
            }
        }
    }
}

