using Day_2.Models;

namespace Day_2.Repositories
{
    public interface IInstructorRepository
    {
        public List<Instructor> GetAll();

        Instructor GetById(int id);

        void Insert(Instructor obj);

        void Update(Instructor obj);

        void Delete(int id);

        void Save();

        List<Instructor> GetByDeptID(int deptid);
    }
}
