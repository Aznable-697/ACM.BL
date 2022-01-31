using System;

namespace ACM.Bl
{
  public  class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
       
        /// Validates the Order DATA.
        public bool Validate()
        {
            // Code that Validates the ORDER DATE.
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
