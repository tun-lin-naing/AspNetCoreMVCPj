using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMVCPj.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required, MaxLength (20, ErrorMessage = "Name can not exceed 20 character!")]
        public string Name { get; set; }

        [Required]
        [Display(Name ="Office Email")]
        public string Email { get; set; }

        public Dept? Department { get; set; }
    }
}
