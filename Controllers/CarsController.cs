//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using UnblockMe.Data;

//namespace UnblockMe.Controllers
//{
//    public class CarsController : Controller
//    {
//        private readonly ApplicationDbContext _context;

//        public CarsController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        public IActionResult SearchResult(string searchTerm)
//        {
//            var car = _context.Cars.Where(c => c.license_plate.Equals(searchTerm, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

//            if (car == null)
//            {
//                return NotFound();
//            }

//            return View(car);
//        }

//        [NonAction]
//        public string ViewImage(string licensePlate)
//        {
//            var car = _context.Cars.Find(licensePlate);

//            string base64String = Convert.ToBase64String(car.image, 0, car.image.Length);

//            return "data:image/png;base64," + base64String;
//        }
//    }
//}
