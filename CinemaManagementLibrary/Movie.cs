using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagementLibrary
{
	/// <summary>
	/// Represents a movie available in the cinema system.
	/// Stores movie information such as title, genre, duration, and production details.
	/// </summary>
	public class Movie
	{
		/// <summary>
		/// Gets or sets the unique identifier of the movie.
		/// </summary>
		public string movieID { get; set; }

		/// <summary>
		/// Gets or sets the title of the movie.
		/// </summary>
		public string title { get; set; }

		/// <summary>
		/// Gets or sets the genre category of the movie.
		/// </summary>
		public Genre genre { get; set; }

		/// <summary>
		/// Gets or sets the duration of the movie in minutes.
		/// </summary>
		public int duration { get; set; }

		/// <summary>
		/// Gets or sets the minimum age requirement to watch the movie.
		/// </summary>
		public int ageLimit { get; set; }

		/// <summary>
		/// Gets or sets the year the movie was released.
		/// </summary>
		public int releaseYear { get; set; }

		/// <summary>
		/// Gets or sets the producer of the movie.
		/// </summary>
		public string producer { get; set; }

		/// <summary>
		/// Gets or sets the description of the movie.
		/// </summary>
		public string description { get; set; }


		/// <summary>
		/// Initializes a new instance of the Movie class.
		/// </summary>
		/// <param name="movieID">The unique identifier of the movie.</param>
		/// <param name="title">The title of the movie.</param>
		/// <param name="genre">The movie genre.</param>
		/// <param name="duration">The duration of the movie in minutes.</param>
		/// <param name="ageLimit">The minimum age requirement.</param>
		/// <param name="releaseYear">The movie release year.</param>
		/// <param name="producer">The producer of the movie.</param>
		/// <param name="description">The movie description.</param>
		public Movie(
			string movieID,
			string title,
			Genre genre,
			int duration,
			int ageLimit,
			int releaseYear,
			string producer,
			string description)
		{
			this.movieID = movieID;
			this.title = title;
			this.genre = genre;
			this.duration = duration;
			this.ageLimit = ageLimit;
			this.releaseYear = releaseYear;
			this.producer = producer;
			this.description = description;
		}


		/// <summary>
		/// Retrieves basic information about the movie.
		/// </summary>
		/// <returns>
		/// A string containing the movie title, release year, genre, and duration.
		/// </returns>
		public virtual string getMovieInfo()
		{
			return $"{title} ({releaseYear}) - {genre} [{duration} mins]";
		}
	}
}