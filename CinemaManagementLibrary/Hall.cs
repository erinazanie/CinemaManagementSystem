using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagementLibrary
{
	/// <summary>
	/// Represents a cinema hall containing multiple seats.
	/// Manages seat storage and availability checking.
	/// </summary>
	public class Hall
	{
		/// <summary>
		/// Gets or sets the unique identifier of the hall.
		/// </summary>
		public string hallID { get; set; }

		/// <summary>
		/// Gets or sets the name of the cinema hall.
		/// </summary>
		public string name { get; set; }

		/// <summary>
		/// Gets or sets the total number of seats available in the hall.
		/// </summary>
		public int numberOfSeat { get; set; }

		/// <summary>
		/// Gets or sets the list of seats inside the hall.
		/// </summary>
		public List<Seat> seats { get; set; } = new List<Seat>();


		/// <summary>
		/// Initializes a new instance of the Hall class.
		/// </summary>
		/// <param name="hallID">The unique identifier of the hall.</param>
		/// <param name="name">The name of the hall.</param>
		/// <param name="numberOfSeat">The total number of seats.</param>
		public Hall(string hallID, string name, int numberOfSeat)
		{
			this.hallID = hallID;
			this.name = name;
			this.numberOfSeat = numberOfSeat;
		}


		/// <summary>
		/// Initializes a new instance of the Hall class with an existing seat list.
		/// </summary>
		/// <param name="hallID">The unique identifier of the hall.</param>
		/// <param name="name">The name of the hall.</param>
		/// <param name="numberOfSeat">The total number of seats.</param>
		/// <param name="seats">The list of seats inside the hall.</param>
		public Hall(string hallID, string name, int numberOfSeat, List<Seat> seats)
		{
			this.hallID = hallID;
			this.name = name;
			this.numberOfSeat = numberOfSeat;
			this.seats = seats;
		}


		/// <summary>
		/// Adds a new seat into the cinema hall.
		/// </summary>
		/// <param name="seat">The seat object to be added.</param>
		public void addSeat(Seat seat)
		{
			seats.Add(seat);
		}


		/// <summary>
		/// Retrieves all seats that are currently available.
		/// </summary>
		/// <returns>
		/// A list containing available seats.
		/// </returns>
		public List<Seat> getAvailabilitySeats()
		{
			return seats.FindAll(s => s.isAvailable());
		}
	}
}