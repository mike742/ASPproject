using System.ComponentModel.DataAnnotations;

namespace ASPproject.Models
{
    public class Student
    {
        public int Id { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$", 
            ErrorMessage ="Invalid Email Format")]
        public string Email { set; get; }
    }
}
