using ACM.Bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }

        /// Retrieve ONE Customer.
        public Customer Retrieve(int customerId)
        {
            // Create the instance of the customer class.
            // Pass in the Requested Id
            Customer customer = new Customer(customerId);

            // code that retrieves the defined customer

            //Temporary hard-- coded vales to return
            //a Example customer
            if (customerId == 1)
            {
                customer.EmailAddress = "jwick@badass.me";
                customer.FirstName = "John";
                customer.LastName = "Wick";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        /// Saves the Current Customer.
        public bool Save(Customer customer)
        {
            // Override Save Code
            var success = true;

            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
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
