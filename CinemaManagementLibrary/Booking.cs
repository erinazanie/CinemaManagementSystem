using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagementLibrary
{
    public class Booking
    {
        public string bookingID { get; set; }
        public Customer customer { get; set; }
        public ShowTime showTime { get; set; }
        public List<Snack> snack { get; set; } = new List<Snack>();
        public List<Ticket> tickets { get; set; } = new List<Ticket>();
        public double totalPrice { get; set; }

        public double calculateTotalPrice()
        {
            double sum = 0;
            foreach (var t in tickets) sum += t.calculatePrice();
            foreach (var s in snack) sum += s.calculatePrice();
            totalPrice = sum;
            return totalPrice;
        }

        public void confirmBooking()
        {
            foreach (var t in tickets)
            {
                if (t.seat != null) t.seat.bookSeat();
            }
        }

        public void cancelBooking()
        {
            foreach (var t in tickets)
            {
                if (t.seat != null) t.seat.releaseSeat();
            }
        }
    }
}
