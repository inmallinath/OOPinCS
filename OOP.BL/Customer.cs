﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    public class Customer
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Customer()
        {

        }

        /// <summary>
        /// Pass in a customer Id parameter while instantiating
        /// the customer class. Provide the opportunity for the
        /// user to set the customer ID
        /// </summary>
        /// <param name="customerId"></param>
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
        /// <summary>
        /// Backing field for the LastName Property
        /// </summary>
        private string _lastName;

        /// <summary>
        /// LastName Property with getter and a setter
        /// </summary>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        /// <summary>
        /// Auto Implemented Properties
        /// </summary>
        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        /// <summary>
        /// Since CustomerID will be a PK in DB
        /// Allow only private set
        /// </summary>
        public int CustomerId { get; private set; }

        /// <summary>
        /// To Demo the use of static properties
        /// </summary>
        public static int InstanceCount { get; set; }

        /// <summary>
        /// Full Name property concatenates LastName and Firstname
        /// "test, csharp"
        /// </summary>
        public string FullName
        {
            get
            {
                var fullName = LastName + ", ";

                if (!String.IsNullOrWhiteSpace(FirstName))
                {
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        /// <summary>
        /// Validate if the user has put in a last name or email address
        /// Will be required fields
        /// </summary>
        /// <returns></returns>
        public bool validate()
        {
            var isValid = true;

            if (String.IsNullOrWhiteSpace(LastName) || String.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// Code to retrieve one single customer from DB
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer retrieve(int customerId)
        {
            var customer = new Customer(customerId);
            return customer;
        }

        /// <summary>
        /// Code to retrieve a list of customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> retrieve()
        {
            var customers = new List<Customer>();
            return customers;
        }
    }
}
