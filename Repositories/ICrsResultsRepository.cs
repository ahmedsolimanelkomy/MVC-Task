using Day_2.Models;

namespace Day_2.Repositories
{
    public interface ICrsResultsRepository
    {
        public List<crsResult> GetAll();//string includes=null)

        crsResult GetById(int id);

        void Insert(crsResult obj);

        void Update(crsResult obj);

        void Delete(int id);

        void Save();
    }
}
