using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day_2.Models
{
    [Table("Courses")]
    public class Course
    {
        [Key]
        public int ID { get; set; }
        [Required,MaxLength(20),MinLength(2),Unique]
        public string Name { get; set; }
        [Required,Range(50,100)]
        public int Degree { get; set; }
        [Required,Remote("CheckMinDegree", "Course", ErrorMessage = "Please Enter Valid Min Degree Less than Degree",AdditionalFields ="Degree"),]
        public int MinDegree { get; set; }
        [Required,Remote("CheckHours", "Course", ErrorMessage ="enter number can divided by 3")]
        public int Hours { get; set; }

        [ForeignKey("Department")]
        public int DeptID { get; set; }

        //Navigation Properties
        public Department? Department { get; set; }

        public ICollection<Instructor>? Instructors { get; set; } 

        public ICollection<crsResult>? CrsResults { get; set;}
    }
}
