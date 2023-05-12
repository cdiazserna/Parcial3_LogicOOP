using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Parcial3POO
{
    public class CheckingAccount : BankAccount
    {
        public decimal Credit { get; set; }
        public decimal Overdraft { get; private set; }
        public decimal Balance { get; private set; }
        public decimal InterestRate { get; } = 0.0265m;

        public CheckingAccount(string holder, string nameBank, decimal credit)
        {
            Holder = holder;
            NameBank = nameBank;
            Credit = credit;
            Balance = credit;
            Overdraft = credit * 0.4m;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Fondos insuficientes");
            }
        }

        public void MakePurchase(decimal amount)
        {
            if (Balance + Overdraft >= amount)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                }
                else
                {
                    decimal remainingAmount = amount - Balance;
                    Balance = 0;
                    Overdraft -= remainingAmount;
                }
            }
            else
            {
                Console.WriteLine("El monto de la compra excede los fondos disponibles");
            }
        }

    }




}
