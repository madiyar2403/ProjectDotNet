using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantLaPashtetDeliverySystem.Models
{
    public interface IFoodRepository
    {
        IEnumerable<Food> AllFood { get; }
        IEnumerable<Food> PopularFood { get; }
        Food GetFoodById(int foodId);
        Food GetFoodByName(string name);
    }
}
