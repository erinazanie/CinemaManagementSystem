namespace CinemaManagementLibrary
{
    public class Ticket
    {
        public string ticketID { get; set; }
        public Seat seat { get; set; }
        public TicketType ticketType { get; set; }

        public Ticket(string ticketID, Seat seat, TicketType ticketType = TicketType.adult)
        {
            this.ticketID = ticketID;
            this.seat = seat;
            this.ticketType = ticketType;
        }

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