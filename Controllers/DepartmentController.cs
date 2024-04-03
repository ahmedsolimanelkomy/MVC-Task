using Day_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_2.Controllers
{
    public class DepartmentController : Controller
    {
        ITIContext context  = new ITIContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Display(int id)
        {
            var Departments = context?.Departments?.ToList();
            return View("Display",Departments);
        }
        public IActionResult DisplayCrs(int id)
        {
            var DeptCourses =  context?.courses?.Where(c => c.DeptID == id).ToList();
            return Json(DeptCourses);
        }

    }
}
