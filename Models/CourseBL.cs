using Microsoft.EntityFrameworkCore;

namespace Day_2.Models
{
    public class CourseBL
    {
        public ITIContext context = new ITIContext();
        public List<Course> courses;
        public CourseBL()
        {
            courses = context.courses.Include("Department").ToList();
        }

        public List<Course> Getcourses()
        {
            return courses;
        }

        public Course? GetCourseByID(int id)
        {
            Course course = courses.FirstOrDefault(crs => crs.ID == id);
            return course;
        }
    }
}
