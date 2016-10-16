using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP.BL;

namespace OOP.Tests
{
    [TestClass]
    public class ProductTest
    {
        /// <summary>
        /// Test to validate if the current price is null
        /// </summary>
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

        /// <summary>
        /// Test to Validate the presence of a Product Name
        /// </summary>
        [TestMethod]
        public void TestValidateNoProductName()
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
