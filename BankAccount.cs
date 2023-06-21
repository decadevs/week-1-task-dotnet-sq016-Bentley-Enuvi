//using Bentley_BankApp;
using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Security.Principal;
//using System.Text;
//using System.Threading.Tasks;

namespace Bentley_BankApp
{
    public  class BankAccount
    {
        public static int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public static string AccountName { get; set; }
        public static long AccountNumber { get; set; }
        public static string AccountType { get; set; }
        public static decimal AccountBalance { get; set; }
        public static string Note { get; set; }
        private static int _id;

        public  BankAccount(string accountName, long accountNumber, string accountType, decimal accountBalance, string note)
        {
            //FirstName = firstName;
            //FirstName = lastName;
            AccountName = accountName;
            AccountNumber = accountNumber;
            AccountType = accountType;
            AccountBalance = accountBalance;
            Note = note;
            Id = ++_id;
        }

        private List<BankAccount> accounts = new List<BankAccount>();
        //private object existingBankAccount;

        // Method to add a new account to the bank
        public void AddAccount(BankAccount account)
        {
            // Check if the account number already exists
            foreach (BankAccount existingAccount in accounts)
            {
                if (AccountNumber == BankAccount.AccountNumber)
                {
                    continue;
                    throw new Exception("Account number already exist");
                }

            }

            // Check if the user already has an account of the same type
            foreach (BankAccount existingAccount in accounts)
            {
                if (AccountType == BankAccount.AccountType && existingAccount.FirstName == account.FirstName && existingAccount.LastName == account.LastName)
                {
                    throw new Exception("User cannot have the same account type");
                }
            }

            // Add the account to the list of accounts
            //accounts.Add(account);
        }
    }
}
