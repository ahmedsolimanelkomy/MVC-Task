using Day_2.Models;
using Day_2.Repositories;
using Day_2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day_2.Controllers
{
    public class FileUploadModel
    {
        public IFormFile File { get; set; }
    }
    public class DepartmentsandCourses{
        ITIContext Context = new ITIContext();
        public ICollection<Department> Departments { get; set; }
        public ICollection<Course> Courses { get; set; }

        public DepartmentsandCourses()
        {
            Departments = Context.Departments.ToList();
            Courses = Context.courses.ToList();
        }

    }
    /// <summary>
    /// ////////////////////
    /// </summary>
    public class InstructorController : Controller
    {
        IInstructorRepository InstructorRepository;
        IDepartmentRepository DepartmentRepository;
        public InstructorController(IInstructorRepository instructorRepository, IDepartmentRepository departmentRepository)
        {
            InstructorRepository = instructorRepository;
            DepartmentRepository = departmentRepository;
        }


        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult GetAll()
        {
            var Instructors = InstructorRepository.GetAll();
            return View("GetAll", Instructors);
        }

        public IActionResult Details(int id) {
            var Instructor = InstructorRepository.GetById(id);
            return View("Details", Instructor);
        
        }
        [HttpGet]
        public IActionResult Add(FileUploadModel Image) {
            DepartmentsandCourses Data = new DepartmentsandCourses();
            return View("Add", Data);
        }
        public IActionResult DataSaved(Instructor Instructor)
        {
            if (Instructor.Name != null)
            {
                InstructorRepository.Update(Instructor);
                InstructorRepository.Save();
                return RedirectToAction("GetAll");
            }
            return View("Add",Instructor);
        }
        public IActionResult Delete(int id) {
            InstructorRepository.Delete(id);
            InstructorRepository.Save();
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(int ID)
        {
            InstructorEditViewModel Data = new InstructorEditViewModel(ID);
            return View("Edit", Data);
        }
        [HttpPost]
        public IActionResult DataEdited(Instructor Instructor)
        {
            Instructor? OldInstructor = InstructorRepository.GetById(Instructor.ID);
            if(Instructor.Name != null && Instructor.Name != null)
            {
                OldInstructor.Name = Instructor.Name;
                OldInstructor.Address = Instructor.Address;
                OldInstructor.Salary = Instructor.Salary;
                OldInstructor.ImageURL =Instructor.ImageURL;
                OldInstructor.DeptID = Instructor.DeptID;
                OldInstructor.CourseID = Instructor.CourseID;
                InstructorRepository.Save();
            }
            else
            {
                return View("Edit", Instructor.ID);
            }

            return RedirectToAction("GetAll");
        }

        
    }
}
