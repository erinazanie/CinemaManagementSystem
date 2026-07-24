using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagementLibrary
{
    public class Hall
    {
        public string hallID { get; set; }
        public string name { get; set; }
        public int numberOfSeat { get; set; }
        public List<Seat> seats { get; set; } = new List<Seat>();

        public void addSeat(Seat seat)
        {
            seats.Add(seat);
        }

        public List<Seat> getAvailabilitySeats()
        {
            return seats.FindAll(s => s.isAvailable());
        }
    }
}
