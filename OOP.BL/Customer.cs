using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    public class Customer
    {
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

        public static int InstanceCount { get; }

        public string FullName
        {
            get
            {
                var fullName = LastName;

                if (!String.IsNullOrWhiteSpace(LastName))
                {
                    if (!String.IsNullOrWhiteSpace(FirstName))
                    {
                        fullName += FirstName;
                    }
                }
                return fullName;
            }
        }
    }
}
