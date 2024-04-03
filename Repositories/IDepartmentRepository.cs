using Day_2.Models;

namespace Day_2.Repositories
{
    public interface IDepartmentRepository
    {
        public List<Department> GetAll();

        Department GetById(int id);

        void Insert(Department obj);

        void Update(Department obj);

        void Delete(int id);

        void Save();
    }
}
