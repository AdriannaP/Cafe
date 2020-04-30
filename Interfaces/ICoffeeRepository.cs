using Cafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe.Interfaces
{
    public interface ICoffeeRepository
    {
        IEnumerable<Coffee> Coffees { get; set; }
        IEnumerable<Coffee> PreferredCoffees { get; set; }
        Coffee GetCoffeeById(int coffeeId);
    }
}
