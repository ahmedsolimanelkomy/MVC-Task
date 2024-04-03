using Day_2.Models;

namespace Day_2.Repositories
{
    public class DepartmentRepository:IDepartmentRepository
    {
        ITIContext context;
        public DepartmentRepository(ITIContext _context)
        {
            context = _context;
        }
        public List<Department> GetAll()
        {
            return context.Departments.ToList();
        }
        public Department GetById(int id)
        {
            return context.Departments.FirstOrDefault(e => e.ID == id);
        }
        public void Insert(Department obj)
        {
            context.Add(obj);
        }
        public void Update(Department obj)
        {
            context.Update(obj);
        }
        public void Delete(int id)
        {
            Department department = GetById(id);
            context.Remove(department);
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
