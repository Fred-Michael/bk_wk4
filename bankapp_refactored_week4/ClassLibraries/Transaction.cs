using System;
using System.Collections.Generic;
using System.Text;

namespace bankapp_refactored_week4.ClassLibraries
{
    public class Transaction
    {
        public string id { get; set; }
        public string AccountNumber { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Note { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }

        //Transaction constructor
        public Transaction(decimal amount, string accNum, string note, string type, DateTime date)
        {
            AccountNumber = accNum;
            Amount = amount;
            Note = note;
            TransactionDate = date;
            Type = type;
        }
    }
}
