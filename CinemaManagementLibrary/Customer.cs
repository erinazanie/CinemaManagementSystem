using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagementLibrary
{
    public class Customer
    {
        public string customerID { get; set; }
        public string name { get; set; }
        public string email { get; set; }

        public void makeBooking() { }
        public void cancelBooking() { }
    }
}
