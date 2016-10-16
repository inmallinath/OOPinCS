using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP.BL;

namespace OOP.Tests
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveExistingProduct()
        {
            //Arrange
            var productData = new ProductRepository();
            var expected = new Product(1)
            {
                ProductName = "Terminal SP-630",
                ProductDescription = "Windows 10 Terminal",
                CurrentPrice = 299.89M
            };

            //Act
            var actual = productData.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }
    }
}
