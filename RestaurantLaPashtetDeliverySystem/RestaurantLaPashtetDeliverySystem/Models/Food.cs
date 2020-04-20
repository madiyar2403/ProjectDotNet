using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantLaPashtetDeliverySystem.Models
{
    public class Food
    {
        public int FoodId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool PopularFood { get; set; }
        public bool InStock { get; set; }
        public int ClassificationId { get; set; }
        public Classification Classification { get; set; }
    }
}
