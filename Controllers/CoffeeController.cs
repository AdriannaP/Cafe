using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cafe.Interfaces;
using Cafe.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Cafe.Controllers
{
    public class CoffeeController : Controller
    {
        private readonly ICategoryRepository _categoryRepsitory;
        private readonly ICoffeeRepository _coffeeRepository;

        public CoffeeController(ICoffeeRepository coffeeRepository, ICategoryRepository categoryRepository)
        {
            _categoryRepsitory = categoryRepository;
            _coffeeRepository = coffeeRepository;
        }
        public ViewResult List()
        {
            CoffeeListViewModel vm = new CoffeeListViewModel();
            vm.Coffees = _coffeeRepository.Coffees;
            vm.CurrentCategory = "CoffeeCategory";

            return View(vm);
        }
    }
}
