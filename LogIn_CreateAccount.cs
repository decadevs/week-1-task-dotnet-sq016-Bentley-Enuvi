using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bentley_BankApp
{
    public class LogIn_CreateAccount
    {
        public string Customer_Input;
        //public string NewCustomer;
        //public string GetCustomerByEmailAndPassword;
        public static void LogInDetails()
        {
            Console.Write("Enter email address? ");
            string email = Console.ReadLine();
            Console.Write("Password? ");
            string password = Console.ReadLine();

            while (email == null)
            {
                Console.Clear();
                Console.WriteLine("User not Found, Enter an  existing email and Password.");
                email = Console.ReadLine();
                LogInDetails();
                
            }


          /*    GetCustomerByEmailAndPassword customer = new GetCustomerByEmailAndPassword(email, password);
              Console.ReadLine();
              Console.Clear();
              Transactions.TransactionMenu(customer);*/

        }
    }
}
