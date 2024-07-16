using Data.Contexts;
using Entity.Entites;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace HotelReservation.Controllers
{
	[Authorize]
    [Route("[controller]/[action]")]
    public class ReservationController : Controller
    {
        private readonly HotelDbContext _context;

		public ReservationController(HotelDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create(int roomId)
        {
			// Oturum açmış kullanıcının kimliğini al
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

			// Kullanıcının müşteri kimliğini al
			var customer = await _context.Customers.FirstOrDefaultAsync(c => c.IdentityUserId == userId);
			if (customer == null)
			{
				return NotFound("Customer not found for the current user.");
			}

			// Room ID'ye göre odanın fiyatını ve diğer bilgilerini al
			var room = await _context.Rooms.FindAsync(roomId);
			if (room == null)
			{
				return NotFound();
			}

			// Yeni rezervasyon oluşturulması
			var reservation = new Reservation
			{
				RoomId = roomId,
				CheckInDate = DateTime.Now,
				CheckOutDate = DateTime.Now.AddDays(1),
				CustomerId = customer.CustomerId,
				TotalPrice = room.Price, // Odanın fiyatını kullanıyoruz
				ReservationStatus = "Pending"
			};

			_context.Reservations.Add(reservation);
			await _context.SaveChangesAsync();

			// Payment sayfasına yönlendirme
			return RedirectToAction("Create", "Payments", new { reservationId = reservation.ReservationId });
		}

        [HttpGet]
        public async Task<IActionResult> MyReservations()
        {
            // Oturum açmış kullanıcının kimliğini al
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Kullanıcının müşteri kimliğini al
            var customer = await _context.Customers.FirstOrDefaultAsync(c => c.IdentityUserId == userId);
            if (customer == null)
            {
                return NotFound("Customer not found for the current user.");
            }

            // Kullanıcının rezervasyonlarını al
            var reservations = await _context.Reservations
                .Where(r => r.CustomerId == customer.CustomerId)
                .Include(r => r.Room)
                .ThenInclude(r => r.Hotel)
                .ToListAsync();

            return View(reservations);
        }
    }
}
