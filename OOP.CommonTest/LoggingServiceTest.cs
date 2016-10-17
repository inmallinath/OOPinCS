using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP.Common;
using OOP.BL;
using System.Collections.Generic;

namespace OOP.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //Arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "test@csharp.com",
                FirstName = "CSharp",
                LastName = "Test",
                AddressList = null
            };
            changedItems.Add(customer as ILoggable);

            var product = new Product(1)
            {
                ProductName = "Terminal SP-800",
                ProductDescription = "End user terminal",
                CurrentPrice = 100.4m
            };
            changedItems.Add(product as ILoggable);

            //Act
            LoggingService.WriteToFile(changedItems);
            //Assert
            //NOT NEEDED
        }
    }
}
