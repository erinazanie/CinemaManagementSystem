using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagementLibrary
{
    public class Snack : Item
    {
        public string snackName { get; set; }
        public int quantity { get; set; }

        public Snack(string itemId, double itemPrice, string snackName, int quantity) : base(itemId, itemPrice)
        {
            this.snackName = snackName;
            this.quantity = quantity;
        }

        public override double calculatePrice()
        {
            return itemPrice * quantity;
        }
    }
}
