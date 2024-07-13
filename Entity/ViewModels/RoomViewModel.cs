using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class RoomViewModel
    {
        public int RoomId { get; set; }
        public int HotelId { get; set; }
        public string RoomNumber { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }
        public string PictureUrl { get; set; } = "";
        public string City { get; set; }
        public string Country { get; set; }
    }
}
