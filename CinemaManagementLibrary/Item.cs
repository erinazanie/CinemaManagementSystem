using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagementLibrary
{
    public class Item
    {
        public string itemId { get; set; }
        public double itemPrice { get; set; }

        public virtual double calculatePrice()
        {
            return itemPrice;
        }
    }
}
