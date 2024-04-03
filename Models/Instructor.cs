using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day_2.Models
{
    [Table("Instructors")]
    public class Instructor
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }

        public string? ImageURL { get; set; }   

        public decimal Salary { get; set; }

        public string? Address { get; set; }

        [ForeignKey("Department")]
        public int DeptID { get; set; }

        [ForeignKey("Course")]
        public int CourseID { get; set; }
        public bool IsDeleted { get; set; } // Soft delete flag

        //Navigation Properties
        public Department? Department { get; set; }

        public Course? Course { get; set; }
    }
}
