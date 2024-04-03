using Day_2.Models;

namespace Day_2.ViewModels
{
    public class InstructorEditViewModel
    {
        ITIContext? Context = new ITIContext();
        public ICollection<Department?> Departments { get; set; }
        public ICollection<Course?> Courses { get; set; }
        public Instructor? Instructor { get; set; }
        public InstructorEditViewModel(int ID)
        {
            Departments = Context.Departments.ToList();
            Courses = Context.courses.ToList();
            Instructor = Context?.Instructors?.FirstOrDefault(i => i.ID == ID);
        }
    }
}
