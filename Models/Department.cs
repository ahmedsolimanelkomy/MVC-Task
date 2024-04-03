using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day_2.Models
{
    [Table("Departments")]
    public class Department
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Manager { get; set; }

        //Navigation Properties
        public ICollection<Instructor>? Instructors { get; set; }
        public ICollection<Trainee>? Trainees { get; set; }
        public ICollection<Course>? Courses { get; set; }    

    }
}
