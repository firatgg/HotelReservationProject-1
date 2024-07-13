using Entity.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HotelController : Controller
    {
        private readonly IHotelService _hotelService;

        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        public async Task<IActionResult> Index()
        {
            var hotel = await _hotelService.GetAll();
            return View(hotel);
        }
    }
}
