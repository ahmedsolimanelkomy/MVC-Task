namespace Day_2.Models
{
    public class TraineeResult
    {
        public string? TraineeName { get; set; }
        public string? CourseName { get; set; }
        public int? CourseHours { get; set; }
    }
    public class TraineeBL
    {
        public ITIContext Context { get; set; } = new ITIContext();
        public ICollection<Trainee> Trainees { get; set; }

        public TraineeBL()
        {
            Trainees = Context.Trainees.ToList();
        }

        public TraineeResult ShowResult(int TraineeID, int CourseID)
        {
            
            crsResult? Result = Context.CrsResults?.
                FirstOrDefault(t => t.TraineeID == TraineeID && t.CourseID == CourseID );

            string? Name = Context.Trainees?.FirstOrDefault(t => t.ID == Result.TraineeID)?.Name;
            string? CrsName = Context.courses?.FirstOrDefault(c => c.ID == Result.CourseID)?.Name;
            int? Hours = Context.courses?.FirstOrDefault(c => c.ID == Result.CourseID)?.Hours;


            return new TraineeResult { TraineeName = Name, CourseName = CrsName, CourseHours = Result?.Degree };
        }
    }
}
