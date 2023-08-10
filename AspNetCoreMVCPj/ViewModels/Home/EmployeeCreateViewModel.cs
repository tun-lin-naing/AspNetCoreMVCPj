using AspNetCoreMVCPj.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AspNetCoreMVCPj.ViewModels.Home
{
    public class EmployeeCreateViewModel
    {
        [Required, MaxLength(20, ErrorMessage = "Name can not exceed 20 character!")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Office Email")]
        public string Email { get; set; }

        public Dept? Department { get; set; }

        public List<IFormFile>? Photo { get; set; }
    }
}
