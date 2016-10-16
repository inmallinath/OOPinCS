using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP.BL;

namespace OOP.Tests
{
    [TestClass]
    public class OrderItemTest
    {
        [TestMethod]
        public void TestValidOrderItemWithoutAnyValues()
        {
            //Arrange
            var orderItem = new OrderItem();
            var expected = false;

            //Act
            var actual = orderItem.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestValidOrderItemWithoutPurchasePrice()
        {
            //Arrange
            var orderItem = new OrderItem();
            orderItem.OrderQuantity = 2;
            orderItem.ProductId = 1;
            var expected = false;

            //Act
            var actual = orderItem.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestValidOrderItemWithNegativePurchaseId()
        {
            //Arrange
            var orderItem = new OrderItem();
            orderItem.OrderQuantity = 2;
            orderItem.ProductId = -1;
            orderItem.PurchasePrice = 100;
            var expected = false;

            //Act
            var actual = orderItem.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestValidOrderItemWithNegativeOrderQuantity()
        {
            //Arrange
            var orderItem = new OrderItem();
            orderItem.OrderQuantity = -2;
            orderItem.ProductId = 1;
            orderItem.PurchasePrice = 100;
            var expected = false;

            //Act
            var actual = orderItem.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestValidOrderItemWithZeroOrderQuantity()
        {
            //Arrange
            var orderItem = new OrderItem();
            orderItem.OrderQuantity = 0;
            orderItem.ProductId = 1;
            orderItem.PurchasePrice = 100;
            var expected = false;

            //Act
            var actual = orderItem.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestValidOrderItemWithZeroAsProductId()
        {
            //Arrange
            var orderItem = new OrderItem();
            orderItem.OrderQuantity = 10;
            orderItem.ProductId = 0;
            orderItem.PurchasePrice = 100;
            var expected = false;

            //Act
            var actual = orderItem.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
