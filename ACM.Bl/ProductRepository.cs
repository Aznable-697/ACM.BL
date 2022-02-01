using System;

namespace ACM.Bl
{
    public class ProductRepository
    {
        /// Retrieve ONE Product.
        public Product Retrieve(int productId)
        {
            // Create the instance of the product class 
            // Pass in the Request Id
            Product product = new Product(productId);

            // Code that Retrieves the Defined Product

            // Temporary hard-coded vales to return
            // An Example Product
            if (productId == 2)
            {
                product.ProductName = "Colt .45";
                product.ProductDescription = "Johns Favorite Gun";
                product.CurrentPrice = 99.99M;
            }
            // .NET Class & Interpolation Example
            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            return product;
        }

        /// Saves the current Product.
        public bool Save(Product product)
        {
            // Code that Saves the Passed in Product.
            return true;
        }


    }
}
