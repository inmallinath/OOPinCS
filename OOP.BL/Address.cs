using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    public class Address : EntityBase
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Address()
        {

        }

        /// <summary>
        /// Constructor that allows the instance to set the AddressId property
        /// </summary>
        /// <param name="addressId"></param>
        public Address(int addressId)
        {
            this.AddressId = addressId;
        }

        /// <summary>
        /// Auto Implemented properties
        /// </summary>
        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public override bool Validate()
        {
            var isValid = true;
            if (String.IsNullOrWhiteSpace(StreetLine1) || String.IsNullOrWhiteSpace(City) || String.IsNullOrWhiteSpace(Country) || String.IsNullOrWhiteSpace(State) || String.IsNullOrWhiteSpace(PostalCode))
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
