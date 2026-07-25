using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagementLibrary
{
    public class Ticket : Item
    {
        public TicketType ticketType { get; set; }
        public Seat seat { get; set; }

        public Ticket(string itemId, double itemPrice, TicketType ticketType, Seat seat) : base(itemId, itemPrice)
        {
            this.ticketType = ticketType;
            this.seat = seat;
        }

        public override double calculatePrice()
        {
            return itemPrice;
        }
    }
}
