using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cafe.Interfaces;
using Cafe.Models;
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
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Coffee> coffees;

            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                coffees = _coffeeRepository.Coffees.OrderBy(n => n.CoffeeId);
                currentCategory = "All products";
            }
            else
            {
                if (string.Equals("White coffees", _category, StringComparison.OrdinalIgnoreCase))
                {
                    coffees = _coffeeRepository.Coffees.Where(p => p.Category.CategoryName.Equals("White Coffees")).OrderBy(p => p.Name);
                }
                else
                {
                    coffees = _coffeeRepository.Coffees.Where(p => p.Category.CategoryName.Equals("Black Coffees")).OrderBy(p => p.Name);
                    currentCategory = _category;

                }
            }
            var coffeeListViewModel = new CoffeeListViewModel
                {
                    Coffees = coffees,
                    CurrentCategory = currentCategory
                };

                return View(coffeeListViewModel);
             }
        }
      
    }
