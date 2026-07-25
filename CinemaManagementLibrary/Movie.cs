using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagementLibrary
{
    public class Movie
    {
        public string movieID { get; set; }
        public string title { get; set; }
        public Genre genre { get; set; }
        public int duration { get; set; }
        public int ageLimit { get; set; }
        public int releaseYear { get; set; }
        public string producer { get; set; }

        public Movie(string movieID, string title, Genre genre, int duration, int ageLimit, int releaseYear, string producer)
        {
            this.movieID = movieID;
            this.title = title;
            this.genre = genre;
            this.duration = duration;
            this.ageLimit = ageLimit;
            this.releaseYear = releaseYear;
            this.producer = producer;
        }

        public virtual string getMovieInfo()
        {
            return $"{title} ({releaseYear}) - {genre} [{duration} mins]";
        }
    }
}
