using AspNetCoreMVCPj.Models;
using AspNetCoreMVCPj.Repositories;
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

        public string Index()
        {
            return _employeeRepository.GetEmployee(1).Name;
        }

        public IActionResult Privacy()
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