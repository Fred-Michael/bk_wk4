using System;
using System.Collections.Generic;
using System.Text;

namespace bankapp_refactored_week4.ClassLibraries
{
    public class Accounts
    {
        private int accountNumberGenerator = 100001;
        public AccountTypes AccountType { get; private set; }
        public string AccountNumber { get; private set; }
        public DateTime AccountDateCreation { get; set; }
        public string AccountOwnerID { get; set; }
        public int Balance { get; set; }
        public List<Transaction> AccountTransactions { get; set; }

        public Accounts(string ownerID, int typeOfAccount, decimal firstDeposit)
        {
            AccountNumber = accountNumberGenerator.ToString();
            accountNumberGenerator++;
            AccountOwnerID = ownerID;
            AccountType = (AccountTypes)typeOfAccount;
            AccountDateCreation = DateTime.Now;
        }

        public void MakeDeposit()
        {
            //
        }
        public void MakeWithdrawal()
        {
            //
        }
        public void MakeTransfer()
        {
            //
        }
    }

}