using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entites
{
    public class Payment 
    {

        public int PaymentId { get; set; }
        public int ReservationId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }

        // Navigation Property
        public Reservation Reservation { get; set; }
    }
}
