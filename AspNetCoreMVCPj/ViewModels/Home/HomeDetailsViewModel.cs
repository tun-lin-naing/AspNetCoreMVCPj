using AspNetCoreMVCPj.Models.Employee;

namespace AspNetCoreMVCPj.ViewModels.Home
{
    public class HomeDetailsViewModel
    {
        public Employee Employee { get; set; }

        public string PageTitle { get; set; }
    }
}
