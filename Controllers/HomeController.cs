using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cafe.Interfaces;
using Cafe.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Cafe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICoffeeRepository _coffeeRepository;
        public HomeController(ICoffeeRepository coffeeRepository)
        {
            _coffeeRepository = coffeeRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredCoffees = _coffeeRepository.PreferredCoffees
            };

            return View(homeViewModel);
        }
    }
}