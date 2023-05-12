using System;

namespace Parcial3POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount checkingAccount = new CheckingAccount("John Doe", "My Bank", 5000);

            checkingAccount.Withdraw(2000);
            checkingAccount.MakePurchase(3000);

            decimal credit = checkingAccount.Credit;
            decimal overdraft = checkingAccount.Overdraft;
            decimal interest = checkingAccount.CalculateOverdueInterest(10);
            decimal balance = checkingAccount.Balance;

            Console.WriteLine("Cuenta Corriente");
            Console.WriteLine("Titular:"+ checkingAccount.Holder);
            Console.WriteLine("Banco: " + checkingAccount.NameBank);
            Console.WriteLine("Crédito: " + credit);
            Console.WriteLine("Sobregiro: " + overdraft);
            Console.WriteLine("Intereses: " + interest);
        


        }
    }
}
