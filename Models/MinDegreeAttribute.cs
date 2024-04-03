using System.ComponentModel.DataAnnotations;

namespace Day_2.Models
{
    public class MinDegreeAttribute:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            ITIContext context = new ITIContext();
            int MinDegree = (int)value;
            Course? CrsFromRequest = validationContext.ObjectInstance as Course;

            if  (CrsFromRequest.Degree > MinDegree) { 
                return ValidationResult.Success;
            }

            return new ValidationResult("Degree doesnt met the condtion");

        }
    }
}
