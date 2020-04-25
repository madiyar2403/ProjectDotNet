using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantLaPashtetDeliverySystem.Models
{
    public class Food
    {
        public int FoodId { get; set; }
        [Required(ErrorMessage = "Please enter food's name")]
        [Display(Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter food's short description")]
        [Display(Name = "Short Description")]
        public string ShortDescription { get; set; }
        [Required(ErrorMessage = "Please enter food's long description")]
        [Display(Name = "Long Description")]
        public string LongDescription { get; set; }
        [Required(ErrorMessage = "Please enter food's price")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please enter food's image url")]
        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; }
        public bool PopularFood { get; set; }
        public bool InStock { get; set; }
        public int ClassificationId { get; set; }
        public Classification Classification { get; set; }
    }
}
