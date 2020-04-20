using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestaurantLaPashtetDeliverySystem.Models;
using RestaurantLaPashtetDeliverySystem.ViewModels;

namespace RestaurantLaPashtetDeliverySystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFoodRepository _foodRepository;

        public HomeController(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PopularFood = _foodRepository.PopularFood
            };

            return View(homeViewModel);
        }
    }
}