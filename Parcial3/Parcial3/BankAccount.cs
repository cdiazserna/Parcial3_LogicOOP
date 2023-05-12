using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial3
{
    public class BankAccount
    {
        public string Number { get; set; }
        public string Holder { get; set; }
        public string NameBank { get; set; }
        public double Balance { get; protected set; }

        public BankAccount(string number, string holder, string nameBank, double balance)
        {
            Number = number;
            Holder = holder;
            NameBank = nameBank;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance = Balance + amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance = Balance - amount;
            }
        }
    }
}