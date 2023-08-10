using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
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

        [Route("Error")]
        [AllowAnonymous]
        public IActionResult Error()
        {
            var exceptionDetail = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            ViewBag.ExceptionDetail = exceptionDetail.Path;
            ViewBag.ExceptionMessage = exceptionDetail.Error.Message;
            ViewBag.StackTrace = exceptionDetail.Error.StackTrace;

            return View("Error");
        }
    }
}
