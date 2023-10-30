using System.ComponentModel.DataAnnotations;
namespace Assign1.Models

{
    public class User1
    {
        //assignment 6
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Employee Name")]
        [MaxLength(40)]
        [MinLength(4)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
   
        public string City { get; set; }



    }
}
