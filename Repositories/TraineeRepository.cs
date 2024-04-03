using Day_2.Models;

namespace Day_2.Repositories
{
    public class TraineeRepository:ITraineeRepository
    {
        ITIContext context;
        public TraineeRepository(ITIContext _context)
        {
            context = _context;
        }
        public List<Trainee> GetAll()
        {
            return context.Trainees.ToList();
        }
        public Trainee GetById(int id)
        {
            return context.Trainees.FirstOrDefault(e => e.ID == id);
        }
        public void Insert(Trainee obj)
        {
            context.Add(obj);
        }
        public void Update(Trainee obj)
        {
            context.Update(obj);
        }
        public void Delete(int id)
        {
            Trainee Trainee = GetById(id);
            context.Remove(Trainee);
        }
        public List<Trainee> GetByDeptID(int deptid)
        {
            return context.Trainees.Where(e => e.DeptID == deptid).ToList();
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
