using System;

namespace Parcial3POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount checkingAccount = new CheckingAccount();

            checkingAccount.Withdraw(2000);
            checkingAccount.MakePurchase(3000);

            decimal credit = checkingAccount.Credit;
            decimal overdraft = checkingAccount.Overdraft;
            decimal interest = checkingAccount.InterestRite;
            decimal balance = checkingAccount.Balance;

            Console.WriteLine("Cuenta Corriente");
            Console.WriteLine("Titular:"+ checkingAccount.Holder);
            Console.WriteLine("Banco: " + checkingAccount.NameBank);
            Console.WriteLine("Crédito: " + credit);
            Console.WriteLine("Sobregiro: " + overdraft);
        


        }
    }
}
