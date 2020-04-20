using RestaurantLaPashtetDeliverySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantLaPashtetDeliverySystem.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Food> PopularFood { get; set; }
    }
}
