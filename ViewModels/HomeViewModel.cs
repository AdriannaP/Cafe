using Cafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Coffee> PreferredCoffees { get; set; }
    }
}
