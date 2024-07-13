using Entity.Entites;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Services
{
    public interface IHotelService
    {
        Task<IEnumerable<HotelViewModel>> GetAll();

        Task<HotelViewModel> Get(int id);
        Task Add(HotelViewModel model);
        Task<List<HotelViewModel>> GetFilteredHotels(DateTime checkInDate, DateTime checkOutDate);
    }
}
