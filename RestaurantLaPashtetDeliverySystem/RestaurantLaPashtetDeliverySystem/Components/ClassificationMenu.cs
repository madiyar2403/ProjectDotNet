using Microsoft.AspNetCore.Mvc;
using RestaurantLaPashtetDeliverySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantLaPashtetDeliverySystem.Components
{
    public class ClassificationMenu : ViewComponent
    {
        private readonly IClassificationRepository _classificationRepository;
        public ClassificationMenu(IClassificationRepository classificationRepository)
        {
            _classificationRepository = classificationRepository;
        }

        public IViewComponentResult Invoke()
        {
            var classifications = _classificationRepository.AllClassifications.OrderBy(c => c.ClassificationName);
            return View(classifications);
        }
    }
}
