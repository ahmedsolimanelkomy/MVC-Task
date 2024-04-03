using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day_2.Models
{
    [Table("crsResult")]
    public class crsResult
    {
        [Key]
        public int ID { get; set; }

        public int Degree { get; set; }

        [ForeignKey("Course")]
        public int CourseID { get; set; }
        [ForeignKey("Trainee")]
        public int TraineeID { get; set; }

        //Navigation Properties
        public Trainee? Trainee { get; set; }
        public Course? Course { get; set; }
    }
}
