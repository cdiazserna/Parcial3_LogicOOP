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

    }




}
