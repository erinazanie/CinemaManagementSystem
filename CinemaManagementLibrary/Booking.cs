using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagementLibrary
{
	/// <summary>
	/// Represents a customer's cinema booking.
	/// Contains customer information, selected showtime, tickets, and snacks.
	/// </summary>
	public class Booking
	{
		/// <summary>
		/// Gets or sets the unique identifier of the booking.
		/// </summary>
		public string bookingID { get; set; }

		/// <summary>
		/// Gets or sets the customer who made the booking.
		/// </summary>
		public Customer customer { get; set; }

		/// <summary>
		/// Gets or sets the selected movie showtime.
		/// </summary>
		public ShowTime showTime { get; set; }

		/// <summary>
		/// Gets or sets the list of snacks included in the booking.
		/// </summary>
		public List<Snack> snacks { get; set; } = new List<Snack>();

		/// <summary>
		/// Gets or sets the list of tickets included in the booking.
		/// </summary>
		public List<Ticket> tickets { get; set; } = new List<Ticket>();


		/// <summary>
		/// Calculates the total price of the booking.
		/// Includes ticket prices and snack prices.
		/// </summary>
		public double totalPrice
		{
			get
			{
				double sum = 0;

				foreach (var t in tickets)
					sum += t.calculatePrice();

				foreach (var s in snacks)
					sum += s.calculatePrice();

				return sum;
			}
		}


		/// <summary>
		/// Initializes a new instance of the Booking class.
		/// </summary>
		/// <param name="bookingID">The unique identifier of the booking.</param>
		/// <param name="customer">The customer making the booking.</param>
		/// <param name="showTime">The selected movie showtime.</param>
		/// <param name="tickets">The tickets included in the booking.</param>
		/// <param name="snacks">The snacks included in the booking.</param>
		public Booking(
			string bookingID,
			Customer customer,
			ShowTime showTime,
			List<Ticket> tickets,
			List<Snack> snacks)
		{
			this.bookingID = bookingID;
			this.customer = customer;
			this.showTime = showTime;
			this.tickets = tickets;
			this.snacks = snacks;
		}


		/// <summary>
		/// Confirms the booking and reserves all selected seats.
		/// </summary>
		public void confirmBooking()
		{
			foreach (var t in tickets)
			{
				if (t.seat != null)
					t.seat.bookSeat();
			}
		}


		/// <summary>
		/// Cancels the booking and releases all reserved seats.
		/// </summary>
		public void cancelBooking()
		{
			foreach (var t in tickets)
			{
				if (t.seat != null)
					t.seat.releaseSeat();
			}
		}
	}
}