using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCPj.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch(statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sorry, this page could not be found!";
                    break;
            }

            return View("NotFound");
        }
    }
}
