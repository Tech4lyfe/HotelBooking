using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelBooking.Models
{
    public class RoomBooking
    {
        public int RoomBookingId { get; set; }
        public int RoomId { get; set; }
        public string BookedTo { get; set; }
        public string BookedFrom { get; set; }
        public string BookingStatus { get; set; }
        public string AdvancePayed { get; set; }
        public string TotalAmountPayed { get; set; }
        public string PaymentStatus { get; set; }
    }
}