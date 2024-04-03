using Day_2.Models;

namespace Day_2.Repositories
{
    public interface ITraineeRepository
    {
        public List<Trainee> GetAll();

        Trainee GetById(int id);

        void Insert(Trainee obj);

        void Update(Trainee obj);

        void Delete(int id);

        void Save();
    }
}
