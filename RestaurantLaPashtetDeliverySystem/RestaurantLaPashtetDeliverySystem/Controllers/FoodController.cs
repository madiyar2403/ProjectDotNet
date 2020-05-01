using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestaurantLaPashtetDeliverySystem.Models;
using RestaurantLaPashtetDeliverySystem.ViewModels;

namespace RestaurantLaPashtetDeliverySystem.Controllers
{
    public class FoodController : Controller
    {
        private readonly IFoodRepository _foodRepository;
        private readonly IClassificationRepository _classificationRepository;

        public FoodController(IFoodRepository foodRepository, IClassificationRepository classificationRepository) 
        {
            _foodRepository = foodRepository;
            _classificationRepository = classificationRepository;
        }
        [HttpPost]
        public ActionResult VerifyName(string name)
        {
            try
            {
                return Json(!IsNameExists(name));
            }
            catch (Exception ex)
            {
                return Json(false);
            }
        }

        private bool IsNameExists(string name)
            => _foodRepository.GetFoodByName(name) != null;

        [HttpPost]
        public ActionResult VerifyClassificationName(string name)
        {
            try
            {
                return Json(!IsClassificationNameExists(name));
            }
            catch (Exception ex)
            {
                return Json(false);
            }
        }

        private bool IsClassificationNameExists(string name)
            => _classificationRepository.GetClassificationByName(name) != null;
        /*public ViewResult Catalogue() 
        {
            FoodCatalogueViewModel foodCatalogueViewModel = new FoodCatalogueViewModel();
            foodCatalogueViewModel.Foods = _foodRepository.AllFood;

            foodCatalogueViewModel.CurrentClassification = "Salads";
            return View(foodCatalogueViewModel);
        }*/

        public ViewResult Catalogue(string classification)
        {
            IEnumerable<Food> food;
            string currentClassification;

            if (string.IsNullOrEmpty(classification))
            {
                food = _foodRepository.AllFood.OrderBy(p => p.FoodId);
                currentClassification = "All menu";
            }
            else
            {
                food = _foodRepository.AllFood.Where(p => p.Classification.ClassificationName == classification)
                    .OrderBy(p => p.FoodId);
                currentClassification = _classificationRepository.AllClassifications.FirstOrDefault(c => c.ClassificationName == classification)?.ClassificationName;
            }

            return View(new FoodCatalogueViewModel
            {
                Foods = food,
                CurrentClassification = currentClassification
            });
        }

        public IActionResult Details(int id)
        {
            var food = _foodRepository.GetFoodById(id);
            if (food == null)
                return NotFound();

            return View(food);
        }

    }
}