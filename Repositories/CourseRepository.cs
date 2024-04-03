using Day_2.Models;

namespace Day_2.Repositories
{
    public class CourseRepository:ICourseRepository
    {
        ITIContext context;
        public CourseRepository(ITIContext _context)
        {
            context = _context;
        }
        public List<Course> GetAll()
        {
            return context.courses.ToList();
        }
        public Course GetById(int id)
        {
            return context.courses.FirstOrDefault(e => e.ID == id);
        }
        public void Insert(Course obj)
        {
            context.Add(obj);
        }
        public void Update(Course obj)
        {
            context.Update(obj);
        }
        public void Delete(int id)
        {
            Course Crs = GetById(id);
            context.Remove(Crs);
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
