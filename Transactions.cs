using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bentley_BankApp
{
    public class Transactions
    {
        public int Deposit;
        public int Withdraw;
        public int Transfer;
        public decimal AccountBalance;

        public  Transactions(int deposit, int withdraw, int transfer, decimal accountBalance)
        {
            Deposit = deposit;
            Withdraw = withdraw;
            Transfer = transfer;
            AccountBalance = accountBalance;
        }

     
    }


}
