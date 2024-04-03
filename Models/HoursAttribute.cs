using System.ComponentModel.DataAnnotations;

namespace Day_2.Models
{
    public class HoursAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            int V = int.Parse(value.ToString());

            if (V % 3 == 0 )
            {
                return  ValidationResult.Success;
            }

            return new ValidationResult("Course Hourse Must be dividable by 3");
        }
    }
}
