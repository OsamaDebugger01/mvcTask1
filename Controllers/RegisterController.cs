using Microsoft.AspNetCore.Mvc;

namespace mvcLab1.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View("registerForm");
        }
    }
}
