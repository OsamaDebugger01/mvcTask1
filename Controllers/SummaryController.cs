using Microsoft.AspNetCore.Mvc;
using mvcLab1.Models;
namespace mvcLab1.Controllers
{
    public class SummaryController : Controller
    {
        public IActionResult Index()
        {
            return View("summary",DataModel.getAll());
        }
    }
}
