using RestaurantLaPashtetDeliverySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantLaPashtetDeliverySystem.ViewModels
{
    public class FoodCatalogueViewModel
    {
        public IEnumerable<Food> Foods { get; set; }
        public string CurrentClassification { get; set; }
    }
}
