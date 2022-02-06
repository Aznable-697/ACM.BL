using Acme.Common;

namespace ACM.Bl
{
   public class Product : EntityBase, ILoggable
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
        // public string ProductName { get; set; }
        private string _productName;
        public string ProductName
        {
            get
            {
                
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }

        // Logging Method for Product.
        public string Log() => $"{ProductId}: {ProductName} Details: {ProductDescription} Status: {EntityState.ToString()}";
       
        // Adds an Override to the base class using the ToString in Expressions form of the method.
        public override string ToString() => ProductName;

        /// Validates the Product DATA.
        public override bool Validate()
        {
            // Code that Validates the Product NAME and CURRENT PRICE.
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
