using Parcial3_OPP.Classes;
using System;

namespace Parcial3_OPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingAccount savingAccount = new SavingAccount();
            CheckingAccount checkingAccount = new CheckingAccount();
            BankAccount bankAccount = new BankAccount();
            Console.WriteLine("Calculate banking transactions ");
            Console.WriteLine("");

            Console.WriteLine("Enter Bank account number");
            bankAccount.NumberAccount=Convert.ToInt16( Console.ReadLine());
            Console.WriteLine("Enter  bank account Holder");
            bankAccount.Holder=(Console.ReadLine());
            Console.WriteLine("Enter Bank name");
            bankAccount.NameBank=(Console.ReadLine());
        }
    }
}
