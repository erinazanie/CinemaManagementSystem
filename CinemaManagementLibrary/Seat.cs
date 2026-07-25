using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagementLibrary
{
    public class Seat
    {
        public string seatNumber { get; set; }
        public bool isBooked { get; set; }

        public Seat(string seatNumber)
        {
            this.seatNumber = seatNumber;
            this.isBooked = false;
        }

        public void bookSeat() => isBooked = true;
        public void releaseSeat() => isBooked = false;
        public bool isAvailable() => !isBooked;
    }
}
