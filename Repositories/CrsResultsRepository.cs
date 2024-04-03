using Day_2.Models;

namespace Day_2.Repositories
{
    public class CrsResultsRepository:ICrsResultsRepository
    {
        ITIContext context;
        public CrsResultsRepository(ITIContext _context)
        {
            context = _context;
        }
        public List<crsResult> GetAll()
        {
            return context.CrsResults.ToList();
        }
        public crsResult GetById(int id)
        {
            return context.CrsResults.FirstOrDefault(e => e.ID == id);
        }
        public void Insert(crsResult obj)
        {
            context.Add(obj);
        }
        public void Update(crsResult obj)
        {
            context.Update(obj);
        }
        public void Delete(int id)
        {
            crsResult result = GetById(id);
            context.Remove(result);
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
