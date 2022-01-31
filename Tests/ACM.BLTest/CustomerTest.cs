using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // -- Arrange
            Customer customer = new Customer
            {
                FirstName = "John",
                LastName = "Wick"
            };
            string expected = "Wick, John";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // -- Arrange
            Customer customer = new Customer
            {
                LastName = "Wick"
            };
            string expected = "Wick";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // -- Arrange
            Customer customer = new Customer
            {
                FirstName = "John"
            };
            string expected = "John";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            // -- Arrange
            var c1 = new Customer();
            c1.FirstName = "John";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Matthew";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Eden";
            Customer.InstanceCount += 1;

            // -- Act

            // -- Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // -- Arrange
            var customer = new Customer
            {
                LastName = "Wick",
                EmailAddress = "jwick@badass.me"
            };

            var expected = true;

            // -- Act
            var actual = customer.Validate();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingLastName()
        {
            // -- Arrange
            var customer = new Customer
            {
                EmailAddress = "jwick@badass.me"
            };
            var expected = false;

            // -- Act
            var actual = customer.Validate();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
            
    }
}
