using Entity.Entites;
using Entity.Services;
using Entity.ViewModels;
using HotelReservation.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Services;
using System.Diagnostics;

namespace HotelReservation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHotelService _hotelService;
        private readonly IRoomService _roomService;

		public HomeController(ILogger<HomeController> logger, IHotelService hotelService, IRoomService roomService)
		{
			_logger = logger;
			_hotelService = hotelService;
			_roomService = roomService;
		}

		public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Filter(DateTime checkInDate, DateTime checkOutDate, string City)
        {
			var hotel = await _hotelService.GetFilteredHotels( checkInDate,  checkOutDate, City);
			return View(hotel);
		}
        public  async Task<IActionResult> Detail(int Id)
        {

        

            var rooms = await _roomService.Get(Id);
            return View(rooms); // List<RoomViewModel> döndürüyoruz
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
