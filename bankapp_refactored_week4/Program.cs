using bankapp_refactored_week4.BankStore;
using bankapp_refactored_week4.ClassLibraries;
using System;

namespace bankapp_refactored_week4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Za-Bank");
            Console.WriteLine("Pls select a command to continue");

            var hold = "";
            while (hold != "8")
            {
                Console.WriteLine("1. Register\n2. Login\n3. Create account\n4. Deposit\n5. Withdraw\n6. Transfer\n7. View transaction details\n8. Logout");
                var response = Console.ReadLine();


                //Customer Register section
                if (response == "1")
                {
                    try
                    {
                        Console.WriteLine("Kindly register with the following details:\n");
                        Console.WriteLine("Enter your Name");
                        var Fname = Console.ReadLine();
                        Console.WriteLine("Enter your email");
                        var email = Console.ReadLine();
                        //Console.WriteLine("Enter your password");
                        //var password = Console.ReadLine();

                        _ = new Customer(Fname, email);
                        Console.WriteLine("A new customer was added!\n");
                        //BankData.Customers.Add(newCustomer);
                        //myownBank.Login(Fname, password, email);
                    }
                    catch (Exception)
                    {
                        throw new ArgumentException("Input data was incorrect\n");
                    }
                    
                }

                //Account Creation
                //if (response == "2")
                //{
                //    Console.WriteLine("Enter your Fullname");
                //    var Fname = Console.ReadLine();
                //    foreach (var item in myownBank.customers)
                //    {
                //        if (item.FullName == Fname)
                //        {
                //            break;
                //        }
                //    }

                //    Console.WriteLine("Enter your minimum deposit");
                //    var deposit = Int32.Parse(Console.ReadLine());
                //    Console.WriteLine("Enter your account type: Savings/Current");
                //    var accountType = Console.ReadLine();
                //}

                if (response == "3")
                {
                    Console.WriteLine("Not yet implemented");
                }
                if (response == "4")
                {
                    Console.WriteLine("Not yet implemented");
                }
                if (response == "5")
                {
                    Console.WriteLine("Not yet implemented");
                }
                if (response == "6")
                {
                    Console.WriteLine("Not yet implemented");
                }
                if (response == "7")
                {
                    Console.WriteLine("\nThank you for banking with us");
                    break;
                }
            }


            //// customer account init
            //var account = new Accounts();

            //// welcome scree message
            //Console.WriteLine(@"        
            //                                        Welcome To MyBank
            //                                Open any account with as low as #0");

            //// get customer's operation
            //string customerOp1 = "";
            //int processCount = 1;

            //while (customerOp1 != "1" || customerOp1 != "2")
            //{
            //    if (processCount > 1)
            //        Console.WriteLine(@"
            //                           Login Or Register to perform a transaction");

            //    Console.WriteLine(@" 
            //                        ---------------------------------------------------    
            //                         To Login: Press 1      |     To Register: Press 2
            //                        ---------------------------------------------------");

            //    // get customer's operation
            //    customerOp1 = Console.ReadLine();

            //    if (customerOp1 == "1")
            //    {
            //        // get login details
            //        var inputs = GetLoginInputs();
            //        account = AuthServices.Login(inputs.Email, inputs.Password);

            //        if (account == null)
            //        {
            //            Console.WriteLine("\nInvalid parameters. Try again.");
            //            Environment.Exit(0);
            //        }
            //    }
            //    else if (customerOp1 == "2")
            //    {
            //        // get registration details
            //        var inputs = GetRegistrationInput();

            //        // register customer
            //        account = AuthServices.Register(inputs.Name, inputs.Email, inputs.Password, inputs.AccType, inputs.Bal);

            //        if (account == null)
            //        {
            //            Console.WriteLine("\nOperation failed. Try again.");
            //            Environment.Exit(0);
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("\nInvalid operation!");
            //        Environment.Exit(0);
            //    }

            //    if (account != null)
            //    {
            //        Console.WriteLine(@"        
            //                        Hi " + LoginSession.CustomerName + " you are logged-in at " + DateTime.Now.ToString("hh:mm tt"));

            //        Console.WriteLine(@"        
            //                       Deposit: Press 1           Withdrawal: Press 2          

            //                       Transfer: Press 3          Add New Account: 4  

            //                       Account Bal: Press 5       Account Transction: 6

            //                                      Logout: Press 7
            //    ");


            //        // get customer's operation
            //        string customerOp2 = "";
            //        int counter = 1;

            //        while (customerOp2 != "7")
            //        {
            //            if (counter > 1)
            //                Console.WriteLine("\nWould you like to perform another transaction?");

            //            // get customer's operation
            //            customerOp2 = Console.ReadLine();

            //            if (customerOp2 == "1")
            //            {
            //                Delay1Sec();
            //                try
            //                {
            //                    Console.WriteLine("\nHow much do you wish to deposit?");
            //                    decimal deposit = Convert.ToDecimal(Console.ReadLine());

            //                    Console.WriteLine("\nPlease enter a short description note.");
            //                    string note = Console.ReadLine();
            //                    note = !string.IsNullOrWhiteSpace(note) ? note : "No note";

            //                    account.MakeDeposite(LoginSession.AccNum, deposit, note, account.AccountType);

            //                    Console.WriteLine($"\nDeposited successfully. Your balance is {GetBalance()}");
            //                }
            //                catch (Exception e)
            //                {
            //                    Console.WriteLine("Error: " + e.Message);
            //                }
            //            }
            //            else if (customerOp2 == "2")
            //            {
            //                Delay1Sec();
            //                try
            //                {
            //                    Console.WriteLine("How much do you want to withdraw?");
            //                    decimal withdrawal = Convert.ToDecimal(Console.ReadLine());

            //                    Console.WriteLine("\nPlease enter a short description note.");
            //                    string note = Console.ReadLine();
            //                    note = !string.IsNullOrWhiteSpace(note) ? note : "No note";

            //                    account.MakeWithdrawal(LoginSession.AccNum, withdrawal, note, account.AccountType);

            //                    Console.WriteLine($"\nWithdrawn successfully. Your balance is {GetBalance()}");

            //                }
            //                catch (Exception e)
            //                {
            //                    Console.WriteLine("Error: " + e.Message);
            //                }

            //            }
            //            else if (customerOp2 == "5")
            //            {
            //                Delay1Sec();
            //                Console.WriteLine($"Your balance is: {GetBalance()}");
            //            }
            //            else if (customerOp2 == "6")
            //            {
            //                Delay1Sec();
            //                decimal bal = 0;
            //                Console.WriteLine("Account Number\tAmount\tBalance\tNote");
            //                foreach (var transaction in BankData.Transactions)
            //                {
            //                    if (transaction.AccountNumber == LoginSession.AccNum)
            //                    {
            //                        bal += transaction.Amount;
            //                        Console.WriteLine($"{transaction.AccountNumber}\t{transaction.Amount}\t{bal}\t{transaction.Note}");
            //                    }
            //                }
            //            }
            //            else if (customerOp2 == "7")
            //            {
            //                // logout
            //                AuthServices.Logout();
            //                Delay1Sec();
            //                Console.WriteLine("\nGood bye. Thank you for banking with us...");
            //                Console.WriteLine("\tFrom the Team at Bank X");

            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid operation!");
            //            }
            //            counter++;
            //        }

            //    }
            //    processCount++;
            //}
        }
    }
}
