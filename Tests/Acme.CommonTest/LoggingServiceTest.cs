using ACM.Bl;
using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //-- Arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "jwick@badass.me",
                FirstName = "John",
                LastName = "Wick",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Colt 1911",
                ProductDescription = "Johns Second Favorite Gun",
                CurrentPrice = 89M
            };
            changedItems.Add(product);

            // -- Act
            LoggingService.WriteToFile(changedItems);

            // -- Assert
            // Nothing to Assert Here. You would write CODE here TO Validate information in file.

        }
    }
}
