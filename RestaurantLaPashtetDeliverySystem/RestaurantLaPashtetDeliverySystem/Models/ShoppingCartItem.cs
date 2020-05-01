using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantLaPashtetDeliverySystem.Models
{
    public class ShoppingCartItem:IValidatableObject
    {
        public int ShoppingCartItemId { get; set; }
        public Food Food { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrWhiteSpace(this.ShoppingCartId))
                errors.Add(new ValidationResult("Any Cart Id is selected"));

            if (this.Amount < 0 || this.Amount > 100)
                errors.Add(new ValidationResult("Invalid item quantity"));

            return errors;
        }
    }
}
