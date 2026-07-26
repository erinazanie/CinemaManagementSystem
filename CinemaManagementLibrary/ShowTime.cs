using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagementLibrary
{
	/// <summary>
	/// Represents a movie screening schedule in the cinema.
	/// Stores information about the movie, hall, and starting time.
	/// </summary>
	public class ShowTime
	{
		/// <summary>
		/// Gets or sets the unique identifier of the showtime.
		/// </summary>
		public string showID { get; set; }

		/// <summary>
		/// Gets or sets the movie assigned to this showtime.
		/// </summary>
		public Movie movie { get; set; }

		/// <summary>
		/// Gets or sets the cinema hall where the movie is shown.
		/// </summary>
		public Hall hall { get; set; }

		/// <summary>
		/// Gets or sets the starting date and time of the movie.
		/// </summary>
		public DateTime startTime { get; set; }


		/// <summary>
		/// Initializes a new instance of the ShowTime class.
		/// </summary>
		/// <param name="showID">The unique identifier of the showtime.</param>
		/// <param name="movie">The movie being screened.</param>
		/// <param name="hall">The cinema hall assigned for screening.</param>
		/// <param name="startTime">The starting date and time of the movie.</param>
		public ShowTime(string showID, Movie movie, Hall hall, DateTime startTime)
		{
			this.showID = showID;
			this.movie = movie;
			this.hall = hall;
			this.startTime = startTime;
		}


		/// <summary>
		/// Checks whether there are available seats in the cinema hall.
		/// </summary>
		/// <returns>
		/// True if available seats exist; otherwise false.
		/// </returns>
		public bool checkSeatAvailability()
		{
			return hall != null && hall.getAvailabilitySeats().Count > 0;
		}
	}
}