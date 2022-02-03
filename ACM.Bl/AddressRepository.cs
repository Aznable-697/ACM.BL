using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Bl
{
   public class AddressRepository
    {
        /// Retrieves ONE Address
        public Address Retrieve(int addressId)
        {
            // Create's the instance of the Address Class
            //Pass in the Requested Id
            Address address = new Address(addressId);

            // Code that Retrieves the Defined Address.

            // Temp. Hard-Coded Values to return.
            // An Example Address
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "9999 Badass Street";
                address.StreetLine2 = "Badass row";
                address.City = "Long Island";
                address.State = "New York";
                address.Country = "United States of America";
                address.PostalCode = "10001";

            }
            return address;
        }
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // Code That Retrieves the Defined Addresses for the Customer

            //Temp. Hard-Coded Values to return a set of Addresses for a Customer
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
            StreetLine1 = "9999 Badass Street",
            StreetLine2 = "Badass row",
            City = "Long Island",
            State = "New York",
            Country = "United States of America",
            PostalCode = "10001"
        };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                StreetLine2 = "Pete's Way",
                City = "Bywater",
                State = "Shire",
                Country = "Fairy Tail Land",
                PostalCode = "111"
            };
            addressList.Add(address);

            return addressList;
        }

        /// Saves The Current Address.
        public bool Save(Address address)
        {
            // Override Save Code
            var success = true;

            if (address.HasChanges)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
                    {
                        // Call an Insert Stored Procedure
                    }
                    else
                    {
                        // Call an Update Stored Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
