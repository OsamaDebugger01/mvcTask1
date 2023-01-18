using Microsoft.AspNetCore.Mvc;
using mvcLab1.Models;

namespace mvcLab1.Controllers
{
    public class ThanksController : Controller
    {
        public IActionResult AddGuest(Guest guest)
        {
            if(guest.willAttend == "True")
            {
                DataModel.AddGuest(guest);
                return View("thanks",guest);
            }
            return Content("See You Later");
        }
    }
}
