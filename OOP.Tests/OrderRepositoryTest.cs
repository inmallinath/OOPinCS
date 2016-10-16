using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP.BL;

namespace OOP.Tests
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveExistingOrder()
        {
            //Arrange
            var orderData = new OrderRepository();
            var expected = new Order(1)
            {
                OrderDate = new DateTimeOffset(2016, 10, 15, 08, 30, 00, new TimeSpan(-6, 0, 0))
            };

            //Act
            var actual = orderData.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.OrderId, actual.OrderId);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
