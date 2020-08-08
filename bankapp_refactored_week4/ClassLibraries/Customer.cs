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
        }
    }
}
