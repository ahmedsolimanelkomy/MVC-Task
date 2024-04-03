using Day_2.Models;
using Day_2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day_2.Controllers
{
    public class CourseController : Controller
    {
        public List<Course> Courses;
        public Course Course;
       CourseBL CourseBL = new CourseBL();
        ITIContext Context = new ITIContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll(int? page, string searchQuery)
        {
            int pageSize = 10;
            int pageNumber = page ?? 1;

            List<Course> courses = CourseBL.Getcourses();

            // Apply search query if provided
            if (!string.IsNullOrEmpty(searchQuery))
            {
                courses = courses.Where(c => c.Name.Contains(searchQuery)).ToList();
            }

            int totalItems = courses.Count();
            var paginatedData = courses.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.TotalItems = totalItems;
            ViewBag.PageNumber = pageNumber;
            ViewBag.PageSize = pageSize;
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            return View("GetAll", paginatedData);
        }


        public IActionResult Details(int id)
        {
            Course = CourseBL.GetCourseByID(id);
            return View("Details", Course);

        }
        [HttpGet]
        public IActionResult Add()
        {
                CourseDepartmentInstructorViewModel Data = new CourseDepartmentInstructorViewModel();
                return View("Add", Data);
            
        }
        [HttpPost]
        public IActionResult DataSaved(Course course)
        {
            if (ModelState.IsValid)
            {
                Context.Update(course);
                Context.SaveChanges();
                return RedirectToAction("GetAll");
            }

            else
            {
                CourseDepartmentInstructorViewModel Data = new CourseDepartmentInstructorViewModel();
                Data.Course = course;
                return View("Add", Data);
            }
        }

        public IActionResult CheckHours(Course course)
       {
            int Hours = course.Hours;
            if (Hours % 3 == 0)
            {
                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }

        public IActionResult CheckMinDegree(Course course)
        {
            int MinDegree = course.MinDegree;
            int Degree = course.Degree;
            if(MinDegree < Degree)
            {
                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }
    }
}
