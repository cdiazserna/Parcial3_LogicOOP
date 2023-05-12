using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial3
{
    public class SavingAccount : BanckAccount
    {
        public decimal Balance { get; set; }
        public decimal Yield { get; set; }

        public decimal Deposit(decimal amount)
        {
           Balance += amount;
            return amount;
        }
        public decimal Withdraw(decimal amount)
        {
            if (amount >Balance)
            {
                Console.WriteLine("Error - Fondos Insuficientes");

                return 0;
            }
            else 
            {
                Balance -= amount;
                return amount;
            }
            
        }

        public decimal Transfer(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Error - Fondos Insuficientes");

                return 0;
            }
            else
            {
                Balance -= amount;
                return amount;
            }
        }

        public decimal CalculateYield()
        {
            return Balance * (Yield/100);
        }
    }
}
