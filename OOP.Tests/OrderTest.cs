using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP.BL;

namespace OOP.Tests
{
    [TestClass]
    public class OrderTest
    {
        /// <summary>
        /// Test for a Valid Order with an Order Date defined
        /// </summary>
        [TestMethod]
        public void TestValidOrderDate()
        {
            //Arrange
            var order = new Order();
            var expected = false;

            //Act
            var actual = order.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
