using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP.BL;
using System.Collections.Generic;

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
                EmailAddress = "csharp@test.com",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "4802",
                        StreetLine2 = "Fraser St",
                        City = "Vancouver",
                        State = "Bc",
                        PostalCode = "V2W9T3",
                        Country = "Canada"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "7659",
                        StreetLine2 = "Rumble St",
                        City = "Burnaby",
                        State = "BC",
                        PostalCode = "V5U9T9",
                        Country = "Canada"
                    }
                }
            };
            
            //Act
            var actual = customerData.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);

            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
            }
        }
    }
}
