using ACM.Bl;
using System;

namespace ACM.BL
{
   public class OrderRepository
    {
        /// Retrieves ONE Order.
        public Order Retrieve(int orderId)
        {
            // Create the instance of the order class
            //Pass in the requested Id
            Order order = new Order(orderId);

            // Code that Retrieves the Defined Order

            // Temporary Hard-Coded values to return
            // A Example Order
            if (orderId == 10)
            {
                // Use Current Year in Hard-Coded Data.
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 1, 31, 14, 15, 30, new TimeSpan(7, 0, 0));
            }
            return order;
        }

        /// Saves the Current Order
         public bool Save(Order order)
        {
            // Code that Saves The Passed in order
            return true;
        }
        

    }
}
