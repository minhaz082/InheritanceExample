using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance_relationsheep
{
    class Checking:Account
    {
        public double  ServiceCharge { get; set; }
        public int NoOfTransaction { private set; get; }

        public Checking(string name, string number, int noOfTransaction, double serviceCharge) : base(number, name)
        {
            NoOfTransaction = noOfTransaction;
            ServiceCharge = serviceCharge;
        }

        

        public override string Withdraw(double amount)
        {
            if (amount < 0)
            {
                NoOfTransaction++;
                return base.Withdraw(amount);
                //NoOfTransaction++;
            }
            return "";
        }
    }
}
