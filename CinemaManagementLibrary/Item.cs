using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagementLibrary
{
	/// <summary>
	/// Represents a general item in the cinema system.
	/// Serves as a base class for items such as tickets and snacks.
	/// </summary>
	public class Item
	{
		/// <summary>
		/// Gets or sets the unique identifier of the item.
		/// </summary>
		public string itemId { get; set; }

		/// <summary>
		/// Gets or sets the price of the item.
		/// </summary>
		public double itemPrice { get; set; }


		/// <summary>
		/// Initializes a new instance of the Item class.
		/// </summary>
		/// <param name="itemId">The unique identifier of the item.</param>
		/// <param name="itemPrice">The price of the item.</param>
		public Item(string itemId, double itemPrice)
		{
			this.itemId = itemId;
			this.itemPrice = itemPrice;
		}


		/// <summary>
		/// Calculates the price of the item.
		/// This method can be overridden by derived classes.
		/// </summary>
		/// <returns>
		/// The item price.
		/// </returns>
		public virtual double calculatePrice()
		{
			return itemPrice;
		}
	}
}