using Acme.Common;

namespace ACM.Bl
{
   public class Product : EntityBase
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
                var stringHandler = new StringHandler();
                return stringHandler.InsertSpaces(_productName);
            }
            set
            {
                _productName = value;
            }
        }
       
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
