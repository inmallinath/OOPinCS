using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP.BL;
using System.Collections.Generic;

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
            var expected = new Order(5)
            {
                OrderDate = new DateTimeOffset(2016, 10, 15, 08, 30, 00, new TimeSpan(-6, 0, 0))
            };

            //Act
            var actual = orderData.Retrieve(5);

            //Assert
            Assert.AreEqual(expected.OrderId, actual.OrderId);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }

        [TestMethod]
        public void RetrieveOrderDisplay()
        {
            //Arrange
            var orderRepository = new OrderRepository();
            var expected = new OrderDisplay()
            {
                FirstName = "CSharp",
                LastName = "Test",
                OrderDate = new DateTimeOffset(2016, 10, 15, 08, 30, 00, new TimeSpan(-6, 0, 0)),
                ShippingAddress = new Address()
                {
                    AddressType = 3,
                    StreetLine1 = "8134",
                    StreetLine2 = "152 St",
                    City = "Surrey",
                    State = "BC",
                    PostalCode = "V2W1T1",
                    Country = "Canada"
                },
                OrderDisplayItemList = new List<OrderDisplayItem>()
                {
                    new OrderDisplayItem()
                    {
                        ProductName = "XBox one",
                        OrderQuantity = 1,
                        PurchasePrice = 565.50M
                    },
                    new OrderDisplayItem()
                    {
                        ProductName = "Sony Playstation",
                        OrderQuantity = 3,
                        PurchasePrice = 426.35M
                    }
                }
            };
            //Act
            var actual = orderRepository.RetrieveOrderDisplay(5);

            //Assert
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);

            Assert.AreEqual(expected.ShippingAddress.AddressType, actual.ShippingAddress.AddressType);
            Assert.AreEqual(expected.ShippingAddress.StreetLine1, actual.ShippingAddress.StreetLine1);
            Assert.AreEqual(expected.ShippingAddress.StreetLine2, actual.ShippingAddress.StreetLine2);
            Assert.AreEqual(expected.ShippingAddress.City, actual.ShippingAddress.City);
            Assert.AreEqual(expected.ShippingAddress.State, actual.ShippingAddress.State);
            Assert.AreEqual(expected.ShippingAddress.PostalCode, actual.ShippingAddress.PostalCode);
            Assert.AreEqual(expected.ShippingAddress.Country, actual.ShippingAddress.Country);

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(expected.OrderDisplayItemList[i].OrderQuantity, actual.OrderDisplayItemList[i].OrderQuantity);
                Assert.AreEqual(expected.OrderDisplayItemList[i].ProductName, actual.OrderDisplayItemList[i].ProductName);
                Assert.AreEqual(expected.OrderDisplayItemList[i].PurchasePrice, actual.OrderDisplayItemList[i].PurchasePrice);
            }
        }
    }
}
