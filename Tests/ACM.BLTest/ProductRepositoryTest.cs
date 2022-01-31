﻿using ACM.BL;
using ACM.Bl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass()]
    public class ProductRepositoryTest
    {
        [TestMethod()]
        public void RetrieveTest()
        {
            // -- Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 99.99M,
                ProductDescription = "Johns Favorite Gun",
                ProductName = "Colt .45"
            };

            // -- Act
            var actual = productRepository.Retrieve(2);

            // -- Assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }
    }
}