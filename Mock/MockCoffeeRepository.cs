using Cafe.Interfaces;
using Cafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe.Mock
{
    public class MockCoffeeRepository : ICoffeeRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Coffee> Coffees => new List<Coffee>
        {
            new Coffee
            {

            }
        };

        public IEnumerable<Coffee> PreferredCoffees { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IEnumerable<Coffee> ICoffeeRepository.Coffees { get => throw new NotImplementedException();  }

        public Coffee GetCoffeeById(int coffeeId)
        {
            throw new NotImplementedException();
        }
    }
}
