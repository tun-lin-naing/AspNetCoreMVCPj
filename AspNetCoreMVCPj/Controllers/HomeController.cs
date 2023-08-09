using AspNetCoreMVCPj.Models;
using AspNetCoreMVCPj.Models.Employee;
using AspNetCoreMVCPj.Repositories;
using AspNetCoreMVCPj.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCoreMVCPj.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IEmployeeRepository _employeeRepository;

        public HomeController(ILogger<HomeController> logger, IEmployeeRepository employeeRepository)
        {
            _logger = logger;
            _employeeRepository = employeeRepository;
        }

        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployee();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {

                Employee = _employeeRepository.GetEmployee( id == null || id == 0 ? 1 : id),
                PageTitle = "Home Details"
            };
            return View(homeDetailsViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}