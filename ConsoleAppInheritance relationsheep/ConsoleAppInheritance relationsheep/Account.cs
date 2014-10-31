using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance_relationsheep
{
    class Account
    {
        public string Number { get; set; }
        public string  Customername { get; set; }
        public double Balance { get; set; }

        public Account(string number, string name)
        {
            Number = number;
            Customername = name;
        }

        public Account()
        {
            Balance = 0;
        }
        public virtual string Deposit(double amount)
        {
            Balance += amount;
            return "deposited";
        }

        public virtual string Withdraw(double amount)
        {
            Balance -= amount;
            return "withdrawn";
        }
    }
}
