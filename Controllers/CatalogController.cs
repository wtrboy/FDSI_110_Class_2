using Microsoft.AspNetCore.Mvc;
using PropertyRental.Models;

namespace PropertyRental.Controllers 
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterProperty ( [FromBody] Property newProp)
        {
            System.Console.WriteLine("Creating a new Property");
            newProp.Id = 1;

            // save the obj to a DB

            return Json(newProp);

        }

    }
}