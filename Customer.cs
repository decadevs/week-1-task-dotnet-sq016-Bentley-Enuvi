using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bentley_BankApp
{

    public class Customer
    {
        private string firstName;
        public string FirstName
        {
            get => firstName;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name is required");
                }

                if (value.Length > 20)
                {
                    throw new ArgumentException("First name must not exceed 20 characters");
                }

                if (char.IsLower(value[0]))
                {
                    throw new ArgumentException("First name must not start with lowercase");
                }

                if (char.IsDigit(value[0]))
                {
                    throw new ArgumentException("First name must not start with a number");
                }

                firstName = value;
            }
        }

        private string lastName;
        public string LastName
        {
            get => lastName;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name is required");
                }

                if (value.Length > 20)
                {
                    throw new ArgumentException("Last name must not exceed 20 characters");
                }

                if (char.IsDigit(value[0]))
                {
                    throw new ArgumentException("Last name must not start with a number");
                }

                lastName = value;
            }


        }




        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }


}
 
