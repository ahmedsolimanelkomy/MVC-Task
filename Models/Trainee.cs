using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day_2.Models
{
    [Table("Trainees")]
    public class Trainee
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }

        public string? ImageURL { get; set; }

        public int Grade { get; set; }

        public string? Address { get; set; }

        [ForeignKey("Department")]
        public int DeptID { get; set; }

        //Navigation Properties
        public Department? Department {  get; set; } 

        public ICollection<crsResult>? CrsResults { get; set; }   
    }
}
