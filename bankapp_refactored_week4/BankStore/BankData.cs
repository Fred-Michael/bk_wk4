using bankapp_refactored_week4.ClassLibraries;
using System.Collections.Generic;

namespace bankapp_refactored_week4.BankStore
{
    public static class BankData
    {
        //This BankData class holds the lists of Accounts, Customers and Transactions
        public static List<Accounts> Accounts { get; set; } = new List<Accounts>();
        public static List<Customer> Customers { get; set; } = new List<Customer>();
        public static List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}