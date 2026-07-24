using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagementLibrary
{
    public class Snack : Item
    {
        public string snackName { get; set; }
        public SnackType snackType { get; set; }
        public int quantity { get; set; }

        public override double calculatePrice()
        {
            return itemPrice * quantity;
        }
    }
}
