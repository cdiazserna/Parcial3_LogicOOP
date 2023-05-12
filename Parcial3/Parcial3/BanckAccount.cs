using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Parcial3
{
    public class BankAccount
    {

        public string NumberAccount { get; set; }
        public string Holder { get; set; }
        public string NameBank { get; set; }

        public decimal Deposit(decimal amount)
        {
            return amount;
        }
            public decimal Withdraw(decimal amount)
        {
            return amount;
        }

    }
}
