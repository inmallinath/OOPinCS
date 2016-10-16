using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    public class CustomerRepository
    {
        /// <summary>
        /// Saves the customer to DB
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Code to retrieve one single customer from DB
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);
            if (customerId == 1)
            {
                customer.FirstName = "CSharp";
                customer.LastName = "test";
                customer.EmailAddress = "csharp@test.com";
            }
            return customer;
        }

        /// <summary>
        /// Code to retrieve a list of customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
    }
}
