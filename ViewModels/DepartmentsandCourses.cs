using Day_2.Models;

namespace Day_2.ViewModels
{
    public class DepartmentsandCourses
    {
        ITIContext Context = new ITIContext();
        public ICollection<Department> Departments { get; set; }
        public ICollection<Course> Courses { get; set; }

        public DepartmentsandCourses()
        {
            Departments = Context.Departments.ToList();
            Courses = Context.courses.ToList();
        }

    }
}
