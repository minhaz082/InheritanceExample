using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance_relationsheep
{
    class Savings:Account
    {
        public double InterestAmount { get; set; }

        public Savings(string name, string number, double interestAmount):base(number,name)
        {
            InterestAmount = interestAmount;
        }

        public override string Withdraw(double amount)
        {
            if (Balance<=0)
            {
                return "insufficient";
            }
            else if (amount>Balance)
            {
                return "insufficient balance";
            }
            else
            {
                return base.Withdraw(amount);
            }
           
        }
    }
}
