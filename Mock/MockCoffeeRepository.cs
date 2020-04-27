using Cafe.Interfaces;
using Cafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe.Mock
{
    public class MockCoffeeRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Coffee> Coffees => new List<Coffee>
        {
            new Coffee
            {

            }
        };
       
    }
}
