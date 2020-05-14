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
    public class ShoppingCartController : Controller
    {
        private readonly ICoffeeRepository _coffeeRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ICoffeeRepository coffeeRepository, ShoppingCart shoppingCart)
        {
            _coffeeRepository = coffeeRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var sCVM = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
               
            };
            return View(sCVM);
        }

        public RedirectToActionResult AddToShoppingCart(int coffeeId)
        {
            var selectedCoffee = _coffeeRepository.Coffees.FirstOrDefault(p => p.CoffeeId == coffeeId);
            if (selectedCoffee != null)
            {
                _shoppingCart.AddToCart(selectedCoffee, 1);
            }
            return RedirectToAction("Index");
        }


        public RedirectToActionResult RemoveFromShoppingCard(int coffeeId)
        {
            var selectedCoffee = _coffeeRepository.Coffees.FirstOrDefault(p => p.CoffeeId == coffeeId);
            if (selectedCoffee != null)
            {
                _shoppingCart.RemoveFromCart(selectedCoffee);
            }
            return RedirectToActionResult("Index");
        }

        private RedirectToActionResult RedirectToActionResult(string v)
        {
            throw new NotImplementedException();
        }
    }
}