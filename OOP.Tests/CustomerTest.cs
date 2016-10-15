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

        [TestMethod]
        public void FullNamePropertyNoFirstName()
        {
            //Arrange
            var customer = new Customer();
            customer.LastName = "test";
            var expected = "test, ";
            //Act
            var actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNamePropertyNoLastName()
        {
            //Arrange
            var customer = new Customer();
            customer.FirstName = "csharp";
            var expected = ", csharp";
            //Act
            var actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNamePropertyNoFirstOrLastName()
        {
            //Arrange
            var customer = new Customer();
            var expected = ", ";
            //Act
            var actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestStaticProperty()
        {
            //Arrange
            var customer1 = new Customer();
            Customer.InstanceCount += 1;
            var customer2 = new Customer();
            Customer.InstanceCount += 1;
            var expected = Customer.InstanceCount;
            //Act
            var actual = 2;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
