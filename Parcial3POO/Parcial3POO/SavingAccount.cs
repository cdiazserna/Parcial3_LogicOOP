using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial3POO
{
    public class SavingAccount : BankAccount
    {
        public decimal Balance { get; private set; }
        public decimal InterestRate { get; } = 0.015m;

        public SavingAccount(string holder, string nameBank, decimal initialDeposit)
        {
            Holder = holder;
            NameBank = nameBank;
            Balance = initialDeposit;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Fondos Insuficientes");
            }
        }

        public decimal CalculateInterest()
        {
            return Balance * InterestRate;
        }


    }
}
