namespace ACM.Bl
{
   public class Product
    {
        public Product()
        {

        }
        public Product (int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }

        /// Retrieve ONE Product.
        public Product Retrieve(int productId)
        {
            // Code that Retrieves ONE Defined Product.
            return new Product();
        }

        /// Saves The CURRENT Product.
        public bool Save()
        {
            // Code That Saves the Defined Product.
            return true;
        }

        /// Validates the Product DATA.
        public bool Validate()
        {
            // Code that Validates the Product NAME and CURRENT PRICE.
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
