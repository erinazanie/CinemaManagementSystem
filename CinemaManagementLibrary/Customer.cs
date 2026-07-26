using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagementLibrary
{
	/// <summary>
	/// Represents a cinema customer who can make and cancel bookings.
	/// Stores customer personal information.
	/// </summary>
	public class Customer
	{
		/// <summary>
		/// Gets or sets the unique identifier of the customer.
		/// </summary>
		public string customerID { get; set; }

		/// <summary>
		/// Gets or sets the customer's name.
		/// </summary>
		public string name { get; set; }

		/// <summary>
		/// Gets or sets the customer's email address.
		/// </summary>
		public string email { get; set; }


		/// <summary>
		/// Initializes a new instance of the Customer class.
		/// </summary>
		/// <param name="customerID">The unique identifier of the customer.</param>
		/// <param name="name">The name of the customer.</param>
		/// <param name="email">The email address of the customer.</param>
		public Customer(string customerID, string name, string email)
		{
			this.customerID = customerID;
			this.name = name;
			this.email = email;
		}


		/// <summary>
		/// Creates a booking for the customer.
		/// This method can be implemented with booking creation logic.
		/// </summary>
		public void makeBooking()
		{
		}


		/// <summary>
		/// Cancels an existing booking made by the customer.
		/// This method can be implemented with booking cancellation logic.
		/// </summary>
		public void cancelBooking()
		{
		}
	}
}