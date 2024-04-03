using Microsoft.AspNetCore.Mvc;

namespace Day_2.Controllers
{
    public class StateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SetSession()
        {
            HttpContext.Session.SetString("Name", "Ahmed");
            HttpContext.Session.SetInt32("Age", 22);
            HttpContext.Session.SetString("Track", "PWD");
            return Content("Session Data Saved");
        }
        public IActionResult GetSession()
        {
            string? Name = HttpContext.Session.GetString("Name");
            int? Age = HttpContext.Session.GetInt32("Age");
            string? Track = HttpContext.Session.GetString("Track");

            return Content($"Name : {Name} \t Age : {Age} \t Track : {Track}");
        }
    }
}
