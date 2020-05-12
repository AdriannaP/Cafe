using Cafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe.ViewModels
{
    public class CoffeeListViewModel
    {
        public IEnumerable<Coffee> Coffees { get; set; }
        public string CurrentCategory { get; set; }
    }
}
