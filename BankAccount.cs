using System;
using System.Collections.Generic;

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
            AccountName = accountName;
            AccountNumber = accountNumber;
            AccountType = accountType;
            AccountBalance = accountBalance;
            Note = note;
            Id = ++_id;
        }

        private List<BankAccount> accounts = new List<BankAccount>();
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
        }
    }
}
