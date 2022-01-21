using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts.Encapsulation
{
    class Account
    {
        private double balance = 2000;
        public void SetbBalance(double balance)
        {
            if (balance < 0)
            {
                Console.WriteLine("Please enter valid amount in multiples of 100");
            }
            else
            {
                this.balance = this.balance + balance;
            }
        }
        public void GetBalance()
        {
            Console.WriteLine(balance);
        }
    }
}
