using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestaurantLaPashtetDeliverySystem.Models;
using RestaurantLaPashtetDeliverySystem.ViewModels;

namespace RestaurantLaPashtetDeliverySystem.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IFoodRepository _foodRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IFoodRepository foodRepository, ShoppingCart shoppingCart)
        {
            _foodRepository = foodRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int foodId)
        {
            var selectedFood = _foodRepository.AllFood.FirstOrDefault(p => p.FoodId == foodId);

            if (selectedFood != null)
            {
                _shoppingCart.AddToCart(selectedFood, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int foodId)
        {
            var selectedFood = _foodRepository.AllFood.FirstOrDefault(p => p.FoodId == foodId);

            if (selectedFood != null)
            {
                _shoppingCart.RemoveFromCart(selectedFood);
            }
            return RedirectToAction("Index");
        }
    }
}