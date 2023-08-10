using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCPj.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
