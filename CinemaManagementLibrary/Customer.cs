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

        public Customer(string customerID, string name, string email)
        {
            this.customerID = customerID;
            this.name = name;
            this.email = email;
        }

        public void makeBooking() { }
        public void cancelBooking() { }
    }
}
