using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance_relationsheep
{
    class Program
    {
        static void Main(string[] args)
        {
            Account anAccount = new Account();
            Account acc1 = new Account();
            Account acc2 = new Checking("jamal", "222", 100, 50);
            Account acc3 = new Savings("devid", "254", 895);

            Savings sv1 = new Savings("pulok", "ac-001", 500);
            sv1.Deposit(5000);
            sv1.Withdraw(200);
            sv1.Withdraw(5000);



            Checking chk1 = new Checking("kamal", "chk-111", 900,3);
            chk1.Deposit(4000);
            chk1.Withdraw(200);
            chk1.Withdraw(4000);

            Savings sv4 = new Savings("pulok", "ac-001", 500);
            sv4.Deposit(8000);
            sv4.Withdraw(100);
            sv4.Withdraw(7000);

            //Console.WriteLine(chk1.NoOfTransaction);
            //Console.ReadKey();

            List<Account> accounts = new List<Account>();

            accounts.Add(sv1);
            accounts.Add(chk1);
            accounts.Add(sv4);

            foreach (Account item in accounts)
            {
               Console.WriteLine(item.Withdraw(500));
                Console.ReadKey();
            }

        }
    }
}
