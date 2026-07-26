using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagementLibrary
{
	/// <summary>
	/// Represents an individual cinema seat.
	/// Handles seat booking and releasing operations.
	/// </summary>
	public class Seat
	{
		/// <summary>
		/// Gets or sets the seat number.
		/// </summary>
		public string seatNumber { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the seat is booked.
		/// True means the seat is already reserved.
		/// </summary>
		public bool isBooked { get; set; }


		/// <summary>
		/// Initializes a new instance of the Seat class.
		/// </summary>
		/// <param name="seatNumber">The seat number assigned to the seat.</param>
		public Seat(string seatNumber)
		{
			this.seatNumber = seatNumber;
			this.isBooked = false;
		}


		/// <summary>
		/// Books the seat by changing its status to booked.
		/// </summary>
		public void bookSeat() => isBooked = true;


		/// <summary>
		/// Releases the seat by changing its status to available.
		/// </summary>
		public void releaseSeat() => isBooked = false;


		/// <summary>
		/// Checks whether the seat is available for booking.
		/// </summary>
		/// <returns>
		/// True if the seat is available; otherwise false.
		/// </returns>
		public bool isAvailable() => !isBooked;
	}
}