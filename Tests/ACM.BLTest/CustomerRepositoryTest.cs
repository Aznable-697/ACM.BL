using ACM.Bl;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            // -- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {

                EmailAddress = "jwick@badass.me",
                FirstName = "John",
                LastName = "Wick",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                         AddressType = 1,
                         StreetLine1 = "9999 Badass Street",
                         StreetLine2 = "Badass row",
                         City = "Long Island",
                         State = "New York",
                         Country = "United States of America",
                         PostalCode = "10001"
                    },
                    new Address()
                    {

                        AddressType = 2,
                        StreetLine1 = "Green Dragon",
                        StreetLine2 = "Pete's Way",
                        City = "Bywater",
                        State = "Shire",
                        Country = "Fairy Tail Land",
                        PostalCode = "111"

                    }
                }

            };

            // -- Act
            var actual = customerRepository.Retrieve(1);

            // -- Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i <1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);

            }
        }
    }
}
