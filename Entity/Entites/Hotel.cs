using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entites
{
    public class Hotel 
    {
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
		public string PictureUrl { get; set; }

        // Navigation Property
        public ICollection<Room> Rooms { get; set; }
        
    }
}
