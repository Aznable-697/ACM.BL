using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // -- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {               
                EmailAddress = "jwick@badass.me",
                FirstName = "John",
                LastName = "Wick"
            };

            // -- Act
            var actual = customerRepository.Retrieve(1);

            // -- Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

        }
    }
}
