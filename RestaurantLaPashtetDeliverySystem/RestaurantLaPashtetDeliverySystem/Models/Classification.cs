using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantLaPashtetDeliverySystem.Models
{
    public class Classification
    {
        public int ClassificationId { get; set; }
        [Required(ErrorMessage = "Please enter classification name")]
        [DisplayName("Classification Name")]
        [Remote("VerifyClassificationName", "Food", HttpMethod = "POST", ErrorMessage = "Name of this classification already exists in database.")]
        public string ClassificationName { get; set; }
        public string Description { get; set; }
        public List<Food> Foods { get; set; }
    }
}
