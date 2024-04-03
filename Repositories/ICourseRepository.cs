using Day_2.Models;

namespace Day_2.Repositories
{
    public interface ICourseRepository
    {
        public List<Course> GetAll();

        Course GetById(int id);

        void Insert(Course obj);

        void Update(Course obj);

        void Delete(int id);

        void Save();
    }
}
