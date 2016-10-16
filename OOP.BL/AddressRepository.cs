using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            var address = new Address(addressId);

            if (addressId == 3)
            {
                address.AddressType = 1;
                address.StreetLine1 = "142 W Hastings St";
                address.StreetLine2 = "Off Pender St";
                address.City = "Vancouver";
                address.State = "BC";
                address.PostalCode = "V1W9K3";
                address.Country = "Canada";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();

            var address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "4802",
                StreetLine2 = "Fraser St",
                City = "Vancouver",
                State = "Bc",
                PostalCode = "V2W9T3",
                Country = "Canada"
            };
            addressList.Add(address);

            address = new BL.Address(2)
            {
                AddressType = 2,
                StreetLine1 = "7659",
                StreetLine2 = "Rumble St",
                City = "Burnaby",
                State = "BC",
                PostalCode = "V5U9T9",
                Country = "Canada"
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}
