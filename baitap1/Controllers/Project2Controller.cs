using baitap1.Models;
using Microsoft.AspNetCore.Mvc;

namespace baitap1.Controllers
{
    public class Project2Controller : Controller
    {
        public IActionResult Function1()
        {
            var model = new Model2 { Property2 = "Data from Model2" };
            return View(model);
        }

        public IActionResult Function2()
        {
            var model = new Model2 { Property2 = "Data from Model2" };
            return View(model);
        }
    }
}
