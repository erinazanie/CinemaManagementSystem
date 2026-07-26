using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagementLibrary
{
    public class ComingSoonMovie : Movie
    {
        public DateTime expectedRelease { get; set; }

        public ComingSoonMovie(string movieID, string title, Genre genre, int duration, int ageLimit, int releaseYear, string producer, string description, DateTime expectedRelease)
            : base(movieID, title, genre, duration, ageLimit, releaseYear, producer, description)
        {
            this.expectedRelease = expectedRelease;
        }

        public void notifyCustomer()
        {
            // Logic to notify customers when movie is released
        }

        public override string getMovieInfo()
        {
            return base.getMovieInfo() + $" - Coming Soon (Expected Release: {expectedRelease.ToShortDateString()})";
        }
    }
}
