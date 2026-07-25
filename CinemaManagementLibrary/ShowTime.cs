using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagementLibrary
{
    public class ShowTime
    {
        public string showID { get; set; }
        public Movie movie { get; set; }
        public Hall hall { get; set; }
        public DateTime startTime { get; set; }

        public ShowTime(string showID, Movie movie, Hall hall, DateTime startTime)
        {
            this.showID = showID;
            this.movie = movie;
            this.hall = hall;
            this.startTime = startTime;
        }

        public bool checkSeatAvailability()
        {
            return hall != null && hall.getAvailabilitySeats().Count > 0;
        }
    }
}
