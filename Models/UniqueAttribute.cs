using System.ComponentModel.DataAnnotations;

namespace Day_2.Models
{
    public class UniqueAttribute:ValidationAttribute
    {

        protected override ValidationResult? IsValid
            (object? value, ValidationContext validationContext)
        {
            ITIContext context = new ITIContext();
            string? name = value?.ToString();
            Course CrsFromRequest = validationContext.ObjectInstance as Course;

            Course CrsFromDb = context.courses
                .FirstOrDefault(x => x.Name == name && x.DeptID == CrsFromRequest.DeptID);
            if (CrsFromDb == null)
            {
                //value valid
                return ValidationResult.Success;
            }

            return new ValidationResult("Name Already Founded");
        }
    }
}
