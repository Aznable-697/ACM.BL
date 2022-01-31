namespace ACM.Bl
{
  public  class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        /// Retrieve's ONE Order Item.
        public OrderItem Retrieve(int orderItemId)
        {
            // Code that Retrieves ONE Defined Order Item.
            return new OrderItem();
        }

        /// Saves Current Order Item.
        public bool Save()
        {
            // Code that Saves the Defined Order Item.
            return true;
        }

        /// Validates the Order Item Data
        public bool Validate()
        {
            // Code that Validates Quality, ProductId, and PurchasePrice.
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice <= 0) isValid = false;

            return isValid;

        }
    }
}
