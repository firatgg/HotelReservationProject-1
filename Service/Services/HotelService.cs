using AutoMapper;
using Data.Contexts;
using Data.Repositories;
using Data.UnitOfWorks;
using Entity.Entites;
using Entity.Repositories;
using Entity.Services;
using Entity.UnitOfWorks;
using Entity.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class HotelService: IHotelService
    {
        
        private readonly HotelViewModel _hotel;
        private readonly IHotelRepository hotelRepository;
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public HotelService(IUnitOfWork uow, IMapper mapper, HotelDbContext context, IHotelRepository hotelRepository)
        {
            _uow = uow;
            _mapper = mapper;
            this.hotelRepository = hotelRepository;
        }

        public async Task<IEnumerable<HotelViewModel>> GetAll()
        {
            //_uow.GetRepository<Article>(); =>Reoısitory<Artşcle> a karşılık gelir
            var list = await _uow.GetRepository<Hotel>().GetAllAsync();
            return _mapper.Map<List<HotelViewModel>>(list);
        }

       

        public Task Add(HotelViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<HotelViewModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<HotelViewModel>> GetFilteredHotels(DateTime checkInDate, DateTime checkOutDate, string City)
        {
            return await hotelRepository.GetAvailableHotelsAsync(checkInDate, checkOutDate, City);
        }

    }
}
