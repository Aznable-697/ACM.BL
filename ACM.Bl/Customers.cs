using ACM.Bl;
using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer(): this(0)
        {
        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public List<Address> AddressList { get; set; }         

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public static int InstanceCount { get; set; }

        /// Retrieve ONE Customer.
        public Customer Retrieve(int customerId)
        {
            // Code that retrieves the Define's ONE Customer.

            return new Customer();
        }

        /// <summary>
        /// Creates a Logging Method for the Interface ILoggable. Long form of doing it.
        //  public string Log()
        //  {
        //       var logString = CustomerId + ": " +
        //           FullName + " " +
        //           "Email: " + EmailAddress + " " +
        //           "Status: " + EntityState.ToString();
        //       return logString;
        //   }
        /// <returns></returns>
        
        /// Short Form of Logging Method.
        public string Log() => $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";

    // Override
    public override string ToString() => FullName;

        /// Validates the Customer Data.
        public override bool Validate()
        {
            // Code that Validates the Customers DATA. i.e.. FIELDS THAT MUST HAVE AN INPUT
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
       }

    }   

}
