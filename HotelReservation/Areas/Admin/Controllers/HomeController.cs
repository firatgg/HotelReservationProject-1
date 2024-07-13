using Microsoft.AspNetCore.Mvc;

namespace HotelReservation.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
    }
}
