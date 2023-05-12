using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial3
{
    public class BankAccount
    {
        //public class BankAccount()
			//{
				
        public int NumberAccount { get; set; }
        public string Holder { get; set; }
        public string NameBank { get; set; }

        public void Deposit(decimal amount, decimal Balance)
        {
            Balance = Balance + amount;
        }
        public void Withdraw(decimal amount, decimal Balance)
        {
            Balance = Balance - amount;
        }
      //}
    }
}

