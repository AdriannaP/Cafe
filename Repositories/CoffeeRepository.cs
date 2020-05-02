using Cafe.Interfaces;
using Cafe.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe.Repositories
{
    public class CoffeeRepository : ICoffeeRepository
    {
        private readonly ApplicationDbContext _applicationDbContex;
        public CoffeeRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContex = applicationDbContext;
        }
        public IEnumerable<Coffee>  Coffees => _applicationDbContex.Coffees.Include(c => c.Category);
        public IEnumerable<Coffee> PreferredCoffees => _applicationDbContex.Coffees.Where(p => p.IsPrefferrdCoffee).Include(c => c.Category);

        public Coffee GetCoffeeById(int coffeeId) => _applicationDbContex.Coffees.FirstOrDefault(p => p.CoffeeId == coffeeId);
        
    }
}
