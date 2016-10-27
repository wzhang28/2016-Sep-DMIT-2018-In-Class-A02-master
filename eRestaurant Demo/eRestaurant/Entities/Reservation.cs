using System;
using System.ComponentModel.DataAnnotations;

namespace eRestaurant.Entities
{
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }

        public string CustomerName { get; set; }
        public DateTime ReservationDate { get; set; }
        public int NumberInParty { get; set; }
        public string ContactPhone { get; set; }
        public string ReservationStatus { get; set; }
        public string EventCode { get; set; }

        // Navigation Properties
        public virtual SpecialEvent Event { get; set; }
    }
}
