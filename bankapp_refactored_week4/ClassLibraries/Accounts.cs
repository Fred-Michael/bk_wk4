using bankapp_refactored_week4.BankStore;
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

        //getting the balance of this particular account from the BankData store
        public decimal Balance { 
            get {
                decimal currentBal = 0;
                foreach (var item in BankData.Transactions)
                {
                    if (item.AccountNumber == AccountNumber)
                    {
                        currentBal += item.Amount;
                    }
                }
                return currentBal;
            }
        }
        
        //List of transactions done on the instance of this account
        public List<Transaction> AccountTransactions { 
            get {
                var accTransaction = new List<Transaction>();
                foreach (var item in BankData.Transactions)
                {
                    if (item.AccountNumber == AccountNumber)
                    {
                        accTransaction.Add(item);
                    }
                }
                return accTransaction;
            }
        }

        //constructor of the account object
        public Accounts(string ownerID, int typeOfAccount, decimal firstDeposit)
        {
            AccountNumber = accountNumberGenerator.ToString();
            accountNumberGenerator++;
            AccountOwnerID = ownerID;
            AccountType = (AccountTypes)typeOfAccount;
            AccountDateCreation = DateTime.Now;
            var newAccount = new Accounts(AccountNumber, AccountOwnerID, AccountType, AccountDateCreation);
            BankData.Accounts.Add(newAccount);
        }

        //overloaded account class that takes necessary parameters and adds it to the BankData store for accounts
        public Accounts(string accountNumber, string accountOwnerID, AccountTypes accountType, DateTime accountDateCreation)
        {
            AccountNumber = accountNumber;
            AccountOwnerID = accountOwnerID;
            AccountType = accountType;
            AccountDateCreation = accountDateCreation;
        }

        //making deposits on this account
        public void MakeDeposit(string accNum, decimal amountToDeposit, string description, AccountTypes typeOfAccount)
        {
            //verify that the minimum deposit amount is from #100 above
            if (amountToDeposit < 100)
            {
                throw new ArgumentOutOfRangeException(nameof(amountToDeposit), "Deposit amount must be from #100 upwards");
            }

            //add a new deposit to the account in the Bank store
            var deposit = new Transaction(amountToDeposit, accNum, description, typeOfAccount.ToString(), DateTime.Now);
            BankData.Transactions.Add(deposit);
        }

        //making withdrawals on this account
        public void MakeWithdrawal(string accNum, decimal amountToWithdraw, string description, AccountTypes typeOfAccount)
        {
            if (amountToWithdraw <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amountToWithdraw), "Invalid operation: You cannot withdraw such an amount. Enter a valid amount next time");
            }
            if (Balance - amountToWithdraw <= 0)
            {
                throw new InvalidOperationException("Invalid Operation: The amount you want to withdraw exceeds the minimum amount that should be left in your account");
            }

            //make a withdrawal from the account in the Bank store
            var withdrawalChanges = new Transaction(-amountToWithdraw, accNum, description, typeOfAccount.ToString(), DateTime.Now);
            BankData.Transactions.Add(withdrawalChanges);
        }

        //making transfer from/to this account
        public void MakeTransfer(string senderAccNum, string receiverAccNum, decimal amountToTransfer, string description, AccountTypes typeOfAccount)
        {
            foreach (var account in BankData.Accounts)
            {
                if (account.AccountNumber == senderAccNum && account.Balance > 0)
                {
                    account.MakeWithdrawal(senderAccNum, amountToTransfer, description, typeOfAccount);
                    account.MakeDeposit(receiverAccNum, amountToTransfer, description, typeOfAccount);
                    break;
                }
                //throw new InvalidOperationException("Invalid Operation: Account was not found");
            }
        }
    }

}