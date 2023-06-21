using Bentley_BankApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Bentley_BankApp
{
    public class PrintStatement : Transactions
    {
        public PrintStatement(int deposit, int withdraw, int transfer, decimal accountBalance)
            : base(deposit, withdraw, transfer, accountBalance)
        {
            // Perform any initialization logic here
            // You can use the constructor parameters to initialize the base class or perform other operations
        }

        public void Print()
        {
          
            Console.WriteLine("Printing statement...");
        }
        
    }
}
