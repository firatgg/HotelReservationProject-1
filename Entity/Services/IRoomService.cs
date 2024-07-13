using Entity.Entites;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Services
{
	public interface IRoomService
	{
		Task<IEnumerable<RoomViewModel>> GetAll();

		Task<List<RoomViewModel>> Get(int HotelId);
		Task Add(RoomViewModel model);
       

    }
}
