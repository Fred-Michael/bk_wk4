using bankapp_refactored_week4.BankStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace bankapp_refactored_week4.ClassLibraries
{
    public class Customer
    {
        private int customerIDGenerator = 1;
        public string customerName { get; set; }
        public string customerID { get; set; }
        public string customerEmail { get; set; }

        public List<Accounts> customersAccounts { get; set; }

        //customer constructor class
        public Customer(string name, string email)
        {
            customerEmail = email;
            customerID = customerIDGenerator.ToString();
            customerIDGenerator++;
            customerName = name;
            var newCustomer = new Customer(customerName, customerEmail, customerID);
            BankData.Customers.Add(newCustomer);
        }

        //overloaded customer class that takes ALL necessary parameters and adds it to the BankData store for newly added customers
        public Customer(string name, string email, string customerID) : this(name, email)
        {
            this.customerID = customerID;
        }

        //once a customer is created (i.e. the customer registers), the person should be pushed into the BankData.customer list as reference.
        //same with accounts and transactions (already taken care of)
    }
}
