using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagementLibrary
{
    public class Ticket : Item
    {
        public TicketType ticketType { get; set; }
        public Seat seat { get; set; }

        public override double calculatePrice()
        {
            return itemPrice;
        }
    }
}
