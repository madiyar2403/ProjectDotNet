using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantLaPashtetDeliverySystem.Models
{
    public interface IClassificationRepository
    {
        IEnumerable<Classification> AllClassifications { get; }
        Classification GetClassificationByName(string name);
    }
}
