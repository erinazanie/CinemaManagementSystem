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
        public List<Snack> snacks { get; set; } = new List<Snack>();
        public List<Ticket> tickets { get; set; } = new List<Ticket>();
        public double totalPrice 
        {
            get
            {
                double sum = 0;
                foreach (var t in tickets) sum += t.calculatePrice();
                foreach (var s in snacks) sum += s.calculatePrice();
                return sum;
            }
        }

        public Booking(string bookingID, Customer customer, ShowTime showTime, List<Ticket> tickets, List<Snack> snacks)
        {
            this.bookingID = bookingID;
            this.customer = customer;
            this.showTime = showTime;
            this.tickets = tickets;
            this.snacks = snacks;
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
