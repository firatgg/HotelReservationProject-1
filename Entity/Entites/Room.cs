using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entites
{
    public class Room 
    {
        public int RoomId { get; set; }
        public int HotelId { get; set; }
        public string RoomNumber { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }
		public string PictureUrl { get; set; } = "";

		// Navigation Properties
		public Hotel Hotel { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
