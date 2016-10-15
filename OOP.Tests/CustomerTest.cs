using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP.BL;

namespace OOP.Tests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void ValidateBlankLastName()
        {
            //Arrange
            var customer = new Customer();
            customer.EmailAddress = "test@csharp.com";
            var expected = false;
            //Act
            var actual = customer.validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateBlankEmailAddress()
        {
            //Arrange
            var customer = new Customer();
            customer.LastName = "test";
            var expected = false;
            //Act
            var actual = customer.validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameProperty()
        {
            //Arrange
            var customer = new Customer();
            customer.FirstName = "csharp";
            customer.LastName = "test";
            var expected = "test, csharp";
            //Act
            var actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
