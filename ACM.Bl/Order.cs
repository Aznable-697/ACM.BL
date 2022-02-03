﻿using System;
using System.Collections.Generic;

namespace ACM.Bl
{
  public  class Order : EntityBase
    {
        public Order(): this (0)
        {
        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public int CustomerId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressId { get; set; }

        // public Override
        public override string ToString() => $"{OrderDate.Value.Date} ({OrderId})";
        

        /// Validates the Order DATA.
        public override bool Validate()
        {
            // Code that Validates the ORDER DATE.
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

  }

}
