using System.ComponentModel.DataAnnotations;

namespace CRUD_Application.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name cannot be empty")]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string province { get; set; }
        [Required]
        public decimal Salary { get; set; }
    }
}
