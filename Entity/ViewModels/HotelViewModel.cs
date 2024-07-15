using Entity.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
	public class HotelViewModel
	{
		public int HotelId { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
		public string Description { get; set; }
		public double Rating { get; set; }
		public string PictureUrl { get; set; }

        public string Type { get; set; }
    }
}
