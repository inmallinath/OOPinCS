using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP.BL;

namespace OOP.Tests
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        /// <summary>
        /// Test to retrieve a known customer
        /// For testing purposes we have hard coded the customer details
        /// </summary>
        [TestMethod]
        public void RetrieveExistingCustomer()
        {
            //Arrange
            var customerData = new CustomerRepository();
            var expected = new Customer(1)
            {
                FirstName = "CSharp",
                LastName = "test",
                EmailAddress = "csharp@test.com"
            };
            
            //Act
            var actual = customerData.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        }
    }
}
