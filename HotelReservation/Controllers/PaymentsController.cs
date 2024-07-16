using Data.Contexts;
using Entity.Entites;
using Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation.Controllers
{
    public class PaymentsController : Controller
    {
        private readonly HotelDbContext _context;

        public PaymentsController(HotelDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Create(int reservationId)
        {
            var reservation = await _context.Reservations
                .Include(r => r.Room)
                .ThenInclude(r => r.Hotel)
                .FirstOrDefaultAsync(r => r.ReservationId == reservationId);

            if (reservation == null)
            {
                return NotFound();
            }

            var model = new PaymentViewModel
            {
                ReservationId = reservationId,
                Amount = reservation.TotalPrice,
                PaymentDate = DateTime.Now
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PaymentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var payment = new Payment
                {
                    ReservationId = model.ReservationId,
                    PaymentDate = model.PaymentDate,
                    Amount = model.Amount,
                    PaymentMethod = model.PaymentMethod
                };

                _context.Payments.Add(payment);

                // Rezervasyon durumunu güncelle
                var reservation = await _context.Reservations.FindAsync(model.ReservationId);
                if (reservation != null)
                {
                    reservation.ReservationStatus = "Onaylandı";
                }

                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Reservations", new { id = model.ReservationId });
            }

            return View(model);
        }

    }
}
