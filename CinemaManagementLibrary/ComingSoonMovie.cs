using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagementLibrary
{
	/// <summary>
	/// Represents a movie that has not been released yet.
	/// Inherits movie information from the Movie class and adds expected release details.
	/// </summary>
	public class ComingSoonMovie : Movie
	{
		/// <summary>
		/// Gets or sets the expected release date of the movie.
		/// </summary>
		public DateTime expectedRelease { get; set; }


		/// <summary>
		/// Initializes a new instance of the ComingSoonMovie class.
		/// </summary>
		/// <param name="movieID">The unique identifier of the movie.</param>
		/// <param name="title">The title of the movie.</param>
		/// <param name="genre">The genre of the movie.</param>
		/// <param name="duration">The duration of the movie in minutes.</param>
		/// <param name="ageLimit">The minimum age requirement to watch the movie.</param>
		/// <param name="releaseYear">The movie release year.</param>
		/// <param name="producer">The producer of the movie.</param>
		/// <param name="description">The description of the movie.</param>
		/// <param name="expectedRelease">The expected movie release date.</param>
		public ComingSoonMovie(
			string movieID,
			string title,
			Genre genre,
			int duration,
			int ageLimit,
			int releaseYear,
			string producer,
			string description,
			DateTime expectedRelease)
			: base(movieID, title, genre, duration, ageLimit, releaseYear, producer, description)
		{
			this.expectedRelease = expectedRelease;
		}


		/// <summary>
		/// Notifies customers when the movie becomes available.
		/// The notification logic can be implemented in this method.
		/// </summary>
		public void notifyCustomer()
		{
			// Notification logic
		}


		/// <summary>
		/// Overrides the movie information display by adding coming soon details.
		/// </summary>
		/// <returns>
		/// Movie information including the expected release date.
		/// </returns>
		public override string getMovieInfo()
		{
			return base.getMovieInfo() +
				$" - Coming Soon (Expected Release: {expectedRelease.ToShortDateString()})";
		}
	}
}