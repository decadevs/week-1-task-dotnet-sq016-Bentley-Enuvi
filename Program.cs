using Bentley_BankApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bentley_BankApp
{
    public class BankApp
    {
        IBankService customerService = new IBankService();
        public void LogIn_CreateAccount()
        {
            LogIn_CreateAccount logIn_CreateAccount = new LogIn_CreateAccount();
        }
        public string AccountType;
        public string AccountName;
        public string AccountNumber;
        public int AccountBalance;
        public void Transactions()
        { }
        public void Withdraw(int money)
        {
            if (money <= AccountBalance)
            {
                AccountBalance = AccountBalance - money;
                Console.WriteLine("Balance after withdrawal: " + AccountBalance);
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }

        }
        public void Deposit(int money)
        {
            AccountBalance = AccountBalance + money;
            Console.WriteLine("Balance after deposit: " + AccountBalance);
        }

        public void Transfer(int money)
        {
            AccountBalance = AccountBalance - money;
            Console.WriteLine("Balance after transfer: " + AccountBalance);
        }
          
            

        public void CheckBalance()
        {
            Console.WriteLine("Your account balance is: " + AccountBalance);
        }

        public void Display()
        {
            Console.WriteLine("Account Type: " + AccountType);
            Console.WriteLine("Account Name: " + AccountName);
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Account Balance: " + AccountBalance);
        }

        internal void PrintStatement()
        {
            throw new NotImplementedException();
        }
    }
    public class Program
    {
        private static readonly IEnumerable<object> Account;

        static void Main(string[] args)
        {
            void PrintAccount(IEnumerable<object> BankAccountDetails)
            {
                BankApp bank = new BankApp();
            }



            Console.WriteLine("Welcome to Bentley BankApp. Please select an option:");
            int initialResponse = 0;
            while (initialResponse > 2 || initialResponse <= 0)
            {
                Console.WriteLine(" 1. Already have an account? Log In");
                Console.WriteLine(" 2. New User? Sign up");
                initialResponse = int.Parse(Console.ReadLine());
                Console.Clear();

                if (initialResponse > 0)
                {
                    Console.Clear();
                    Console.WriteLine("LogIn Details");
                    LogIn_CreateAccount.LogInDetails();
                    Console.Clear();
                    Console.WriteLine();
                }

                void BankAccount(string accountName, string accountNumber, int AccountType, int AccountBalance, string Note)
                {
                    BankAccount account1 = new BankAccount("Cheng Yi Min", 0093732014, "Current", 100000.00m, "Orphanage");
                    BankAccount account2 = new BankAccount("Cheng Yi Min", 8109847414, "Savings", 50000.00m, "School Fees");
                    //Type = AccountType;
                    //AccountName = accountName;
                    // AccountNumber = AccountNumber;
                    //AccountBalance = AccountBalance;
                }

                BankApp b1 = new BankApp();
                //b1.OpenAccount("Current", "Bentley Enuvi", 0093732014, 100000);
                //b1.Display();
                //b1.Withdraw(20000);
                //b1.Deposit(500000);
                //b1.CheckBalance();
                int AccountNumber;
                do
                {
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Transfer");
                    Console.WriteLine("4. Check your balance");
                    Console.WriteLine("5. Display your account information");
                    Console.WriteLine("6. Print your Account Statement");
                    Console.WriteLine("0. Exit");
                    AccountNumber = int.Parse(Console.ReadLine());
                    int transfer = 0;
                    switch (AccountNumber)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Enter amount to deposit: ");
                            int amount = int.Parse(Console.ReadLine());
                            b1.Deposit(amount);
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("Enter amount to withdraw: ");
                            int withdrawal = int.Parse(Console.ReadLine());
                            b1.Withdraw(withdrawal);
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("Enter amount to transfer: ");
                            int amount1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter recipient's number: ");
                            long account = long.Parse(Console.ReadLine());
                            b1.Transfer(transfer);
                            break;

                        case 4:
                            Console.Clear();
                            b1.CheckBalance();
                            break;

                        case 5: 
                            Console.Clear();
                            b1.Display();
                            break;

                        case 6:
                            Console.Clear();
                            b1.PrintStatement();
                            break;
                    }
                } while (AccountNumber != 0);

                Console.ReadLine();
            }



            // Print all accounts and balances
            void PrintStatement()
            {
                Console.WriteLine("|---------------|------------------|--------------|-----------------|-----------------|");
                Console.WriteLine("| FULL NAME     | ACCOUNT NUMBER   | ACCOUNT TYPE | ACCOUNT BALANCE |    NOTE         |");
                Console.WriteLine("|---------------|------------------|--------------|-----------------|-----------------|");


                foreach (var account in Account)
                {
                   Console.WriteLine($"| {account.AccountName,-9} | {account.AccountNumber,-16} | {account.AccountType,-13} | {account.Balance,-11} | {account.Note,-6} |");
                 }

                Console.WriteLine("|---------------|------------------|--------------|-------------|--------|");
                }
            }
        }
    }
}
