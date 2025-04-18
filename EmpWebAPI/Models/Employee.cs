using System.ComponentModel.DataAnnotations;

namespace EmpWebAPI.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Position { get; set; }

        public decimal Salary { get; set; }
    }
}
