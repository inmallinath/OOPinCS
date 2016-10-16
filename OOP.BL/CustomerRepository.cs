using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        
        /// <summary>
        /// Saves the customer to DB
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            var success = true;
            if (customer.HasChanges && customer.IsValid)
            {
                if (customer.IsNew)
                {
                    //CREATE the new Customer record in DB
                }
                else
                {
                    //UPDATE the edited customer record in DB
                }
            }
            return success;
        }

        /// <summary>
        /// Code to retrieve one single customer from DB
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);
            customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();

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
