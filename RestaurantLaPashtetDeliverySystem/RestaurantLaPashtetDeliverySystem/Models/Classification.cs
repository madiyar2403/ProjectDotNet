using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantLaPashtetDeliverySystem.Models
{
    public class Classification
    {
        public int ClassificationId { get; set; }
        public string ClassificationName { get; set; }
        public string Description { get; set; }
        public List<Food> Foods { get; set; }
    }
}
