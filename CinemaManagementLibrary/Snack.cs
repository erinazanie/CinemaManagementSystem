using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagementLibrary
{
	/// <summary>
	/// Represents a snack item purchased during a cinema booking.
	/// Inherits from the Item class and calculates the total price based on quantity.
	/// </summary>
	public class Snack : Item
	{
		/// <summary>
		/// Gets or sets the name of the snack item.
		/// </summary>
		public string snackName { get; set; }

		/// <summary>
		/// Gets or sets the quantity of snacks purchased.
		/// </summary>
		public int quantity { get; set; }


		/// <summary>
		/// Initializes a new instance of the Snack class.
		/// </summary>
		/// <param name="itemId">The unique identifier of the snack item.</param>
		/// <param name="itemPrice">The price of a single snack item.</param>
		/// <param name="snackName">The name of the snack.</param>
		/// <param name="quantity">The quantity of snacks purchased.</param>
		public Snack(string itemId, double itemPrice, string snackName, int quantity)
			: base(itemId, itemPrice)
		{
			this.snackName = snackName;
			this.quantity = quantity;
		}


		/// <summary>
		/// Calculates the total price of the snack based on the quantity purchased.
		/// </summary>
		/// <returns>The total price of all snacks.</returns>
		public override double calculatePrice()
		{
			return itemPrice * quantity;
		}
	}
}