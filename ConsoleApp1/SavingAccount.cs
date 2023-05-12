using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class SavingAccount : BankAccount
    {
        public double Balance { get; set; }
        public double Yield = 0.015;
        public decimal Transfer()
        {
            return Transfer();
        }
        public double CalculateYields()
        {
            Balance = Deposit() * Yield;
            return Balance;
        }



    }
}
