using Day_2.Models;

namespace Day_2.Repositories
{
    public class InstructorRepository:IInstructorRepository
    {
        ITIContext context;
        public InstructorRepository(ITIContext _context)
        {
            context = _context;
        }
        public List<Instructor> GetAll()
        {
            return context.Instructors.ToList();
        }
        public Instructor GetById(int id)
        {
            return context.Instructors.FirstOrDefault(e => e.ID == id);
        }
        public void Insert(Instructor obj)
        {
            context.Add(obj);
        }
        public void Update(Instructor obj)
        {
            context.Update(obj);
        }
        public void Delete(int id)
        {
            Instructor instructor = GetById(id);
            context.Remove(instructor);
        }
        public List<Instructor> GetByDeptID(int deptid)
        {
            return context.Instructors.Where(e => e.DeptID == deptid).ToList();
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
