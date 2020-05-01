using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantLaPashtetDeliverySystem.Models
{
    public class ExampleClassificationRepository : IClassificationRepository
    {
    public IEnumerable<Classification> AllClassifications =>
        new List<Classification>
        {
                    new Classification{ClassificationId=1, ClassificationName="Snacks", Description="Can't just pass around snacks like a backyard hootenanny."},
                    new Classification{ClassificationId=2, ClassificationName="Salads", Description="A salad is a dish consisting of a mixture of small pieces of food, usually vegetables or fruit."},
                    new Classification{ClassificationId=3, ClassificationName="Soups", Description="Soup, what is it? Soup, that's what it is, it's soup."}
        };
        public Classification GetClassificationByName(string name)
        {
            return AllClassifications.FirstOrDefault(p => p.ClassificationName == name);
        }
    }
}
