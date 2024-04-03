using Microsoft.Data.SqlClient;

namespace Day_2.Models
{
    public class InstructorBL
    {
        public ITIContext context = new ITIContext();
        public List<Instructor> Instructors;
        public InstructorBL()
        {
            Instructors = context.Instructors.ToList();
        }

        public List<Instructor> GetInstructors()
        {
            return Instructors;
        }

        public Instructor GetInstructorByID(int id)
        {
            Instructor instructor = Instructors.FirstOrDefault(inst => inst.ID == id);
            return instructor;
        }
    }
}
