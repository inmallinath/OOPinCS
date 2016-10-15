using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerId)
        {

        }
        private string _lastName;

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

        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        public int CustomerId { get; private set; }

        public static int InstanceCount { get; set; }

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

        public bool validate()
        {
            var isValid = true;

            if (String.IsNullOrWhiteSpace(LastName) || String.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }
            return isValid;
        }

        public Customer retrieve(int customerId)
        {
            var customer = new Customer(customerId);
            return customer;
        }

        public List<Customer> retrieve()
        {
            var customers = new List<Customer>();
            return customers;
        }
    }
}
