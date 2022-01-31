using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.Bl;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass()]
    public class OrderRepositoryTest
    {
        [TestMethod()]
        public void RetrieveOrderDiplayTest()
        {
            // -- Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 1, 31, 14, 15, 30, new TimeSpan(7, 0, 0)),
            };

            // -- Act
            var actual = orderRepository.Retrieve(10);

            // -- Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);

        }
    }
}
