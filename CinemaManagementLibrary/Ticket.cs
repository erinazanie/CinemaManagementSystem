namespace CinemaManagementLibrary
{
	/// <summary>
	/// Represents a cinema ticket purchased by a customer.
	/// Stores ticket information including the assigned seat and ticket type.
	/// </summary>
	public class Ticket
	{
		/// <summary>
		/// Gets or sets the unique identifier of the ticket.
		/// </summary>
		public string ticketID { get; set; }

		/// <summary>
		/// Gets or sets the seat assigned to the ticket.
		/// </summary>
		public Seat seat { get; set; }

		/// <summary>
		/// Gets or sets the type of ticket.
		/// The ticket type can be adult, child, or student.
		/// </summary>
		public TicketType ticketType { get; set; }


		/// <summary>
		/// Initializes a new instance of the Ticket class.
		/// </summary>
		/// <param name="ticketID">The unique identifier of the ticket.</param>
		/// <param name="seat">The seat assigned to the ticket.</param>
		/// <param name="ticketType">
		/// The type of ticket purchased.
		/// The default ticket type is adult.
		/// </param>
		public Ticket(string ticketID, Seat seat, TicketType ticketType = TicketType.adult)
		{
			this.ticketID = ticketID;
			this.seat = seat;
			this.ticketType = ticketType;
		}


		/// <summary>
		/// Calculates the ticket price based on the ticket type.
		/// </summary>
		/// <returns>
		/// Returns the ticket price:
		/// Adult = $15.00,
		/// Student = $12.00,
		/// Child = $10.00.
		/// </returns>
		public double calculatePrice()
		{
			switch (ticketType)
			{
				case TicketType.child:
					return 10.00;

				case TicketType.student:
					return 12.00;

				case TicketType.adult:
				default:
					return 15.00;
			}
		}
	}
}