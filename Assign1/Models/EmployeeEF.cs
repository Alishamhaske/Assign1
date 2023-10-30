using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Assign1.Models

{
    [Table("EmployeeEF")]
    public class EmployeeEF
    {
 
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Dept { get; set; }
        [Required]
        public int Salary { get; set; }
    }
}
