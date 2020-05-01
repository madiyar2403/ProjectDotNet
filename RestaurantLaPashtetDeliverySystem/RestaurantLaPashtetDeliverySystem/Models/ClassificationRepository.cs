using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantLaPashtetDeliverySystem.Models
{
    public class ClassificationRepository : IClassificationRepository
    {
        private readonly AppDbContext _appDbContext;

        public ClassificationRepository(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Classification> AllClassifications => _appDbContext.Classifications;
        public Classification GetClassificationByName(string name)
        {
            return _appDbContext.Classifications.FirstOrDefault(p => p.ClassificationName == name);
        }
    }
}
