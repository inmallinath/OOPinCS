using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP.BL;

namespace OOP.Tests
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void TestValidateCurrentPriceWithNull()
        {
            //Arrange
            var product = new Product();
            product.ProductName = "Terminal SP-630";
            var expected = false;

            //Act
            var actual = product.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestValidateCurrentPriceWithNoProductName()
        {
            //Arrange
            var product = new Product();
            product.CurrentPrice = 280;
            var expected = false;

            //Act
            var actual = product.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
