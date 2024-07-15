using Data.Contexts;
using Entity.Entites;
using Entity.Repositories;
using Entity.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        private readonly HotelDbContext _context;

        public HotelRepository(HotelDbContext context)
        {
            _context = context;
        }

        public async Task<List<HotelViewModel>> GetAvailableHotelsAsync(DateTime CheckInDate, DateTime CheckOutDate, string City, string Type)
        {
            var availableHotels = await _context.Hotels
                .Include(h => h.Rooms)
                .ThenInclude(r => r.Reservations)
                .Where(h => h.City == City && h.Rooms.Any(r => r.Type == Type && r.Reservations.All(rez => rez.CheckOutDate <= CheckInDate || rez.CheckInDate >= CheckOutDate)))
                .ToListAsync();

            var hotelViewModels = availableHotels.Select(h => new HotelViewModel
            {
                HotelId = h.HotelId,
                Name = h.Name,
                City = h.City,
                PictureUrl = h.PictureUrl,
                Type = Type 
            }).ToList();

            return hotelViewModels;
        }

    }
}


