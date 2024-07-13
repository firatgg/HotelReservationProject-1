using AutoMapper;
using Data.Identity;
using Entity.Entites;
using Entity.Services;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
         CreateMap<Hotel, HotelViewModel>().ReverseMap();
         CreateMap<Reservation, ReservationViewModel>().ReverseMap();
			CreateMap<AppUser, UserViewModel>().ReverseMap();
			CreateMap<AppUser, LoginViewModel>().ReverseMap();
            CreateMap<AppRole, RoleViewModel>().ReverseMap();
            CreateMap<Room, RoomViewModel>().ReverseMap();

        }
    }
}
