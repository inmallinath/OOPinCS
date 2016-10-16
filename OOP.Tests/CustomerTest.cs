using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP.BL;

namespace OOP.Tests
{
    [TestClass]
    public class CustomerTest
    {
        /// <summary>
        /// Test for Blank LastName of the Validate Method
        /// </summary>
        [TestMethod]
        public void ValidateBlankLastName()
        {
            //Arrange
            var customer = new Customer();
            customer.EmailAddress = "test@csharp.com";
            var expected = false;
            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test for Blank EmailAddress of the Validate Method
        /// </summary>
        [TestMethod]
        public void ValidateBlankEmailAddress()
        {
            //Arrange
            var customer = new Customer();
            customer.LastName = "test";
            var expected = false;
            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test for Full Name property with valid values
        /// </summary>
        [TestMethod]
        public void FullNamePropertyValid()
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

        /// <summary>
        /// Test for Full Name Property with no first name
        /// </summary>
        [TestMethod]
        public void FullNamePropertyNoFirstName()
        {
            //Arrange
            var customer = new Customer();
            customer.LastName = "test";
            var expected = "test";
            //Act
            var actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test for Full Name Property with no last name
        /// </summary>
        [TestMethod]
        public void FullNamePropertyNoLastName()
        {
            //Arrange
            var customer = new Customer();
            customer.FirstName = "csharp";
            var expected = "csharp";
            //Act
            var actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test for Full Name Property with no first or last name
        /// </summary>
        [TestMethod]
        public void FullNamePropertyNoFirstOrLastName()
        {
            //Arrange
            var customer = new Customer();
            //var expected = ;
            //Act
            var actual = customer.FullName;

            //Assert
            Assert.IsNull(actual);
        }

        /// <summary>
        /// Test for static property
        /// </summary>
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
