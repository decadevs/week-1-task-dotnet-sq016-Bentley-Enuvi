using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bentley_BankApp
{
    public class IBankService
    {
        public interface ICustomerService
        {

            bool CreateCustomer(Customer customer);

            Customer GetCustomerByEmailAndPassword(string email, string password);


            bool AccountCheck(string email, string password);


            Customer GetCustomerById(int id);

        }
    }
}
