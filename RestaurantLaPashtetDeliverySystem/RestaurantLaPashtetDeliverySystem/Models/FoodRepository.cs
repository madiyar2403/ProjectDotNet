using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantLaPashtetDeliverySystem.Models
{
    public class FoodRepository : IFoodRepository
    {
        private readonly AppDbContext _appDbContext;
        public FoodRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Food> AllFood
        {
            get
            {
                return _appDbContext.Foods.Include(c => c.Classification);
            }
        }
        public IEnumerable<Food> PopularFood
        {
            get
            {
                return _appDbContext.Foods.Include(c => c.Classification).Where(p => p.PopularFood);
            }
        }
        public Food GetFoodById(int foodId)
        {
            return _appDbContext.Foods.FirstOrDefault(p => p.FoodId == foodId);
        }
        public Food GetFoodByName(string name)
        {
            return _appDbContext.Foods.FirstOrDefault(p => p.Name == name);
        }
    }
}
