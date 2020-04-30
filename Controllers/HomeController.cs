using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cafe.Models;
using Cafe.Interfaces;

namespace Cafe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryRepository _categoryRepsitory;
        private readonly ICoffeeRepository _coffeeRepository;

        public HomeController(ICoffeeRepository coffeeRepository,ICategoryRepository categoryRepository)
        {
            _categoryRepsitory = categoryRepository;
            _coffeeRepository = coffeeRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ViewResult List()
        {
            var coffees = _coffeeRepository.Coffees;
            return View(coffees);
        }
    }
}
