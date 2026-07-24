using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagementLibrary
{
    public class Movie : ComingSoonMovie
    {
        public string movieID { get; set; }
        public string title { get; set; }
        public Genre genre { get; set; }
        public int duration { get; set; }
        public int ageLimit { get; set; }
        public int releaseYear { get; set; }
        public string producer { get; set; }

        public string getMovieInfo()
        {
            return $"{title} ({releaseYear}) - {genre} [{duration} mins]";
        }
    }
}
