using Day_2.Models;

namespace Day_2.ViewModels
{
    public class CourseDepartmentInstructorViewModel
    {
            ITIContext Context = new ITIContext();
            public ICollection<Department> Departments { get; set; }
            public Course? Course { get; set; }


        public CourseDepartmentInstructorViewModel()
            {
                Departments = Context.Departments.ToList();
                Course = new Course();
            }
    }
}
