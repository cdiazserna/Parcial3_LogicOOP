using System;

namespace Parcial3POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre del titular de la cuenta corriente:");
            string checkingOwner = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del banco:");
            string checkingBankName = Console.ReadLine();
            Console.WriteLine("Ingrese el crédito mensual de la cuenta corriente:");
            decimal checkingCredit = decimal.Parse(Console.ReadLine());

            CheckingAccount checkingAccount = new CheckingAccount(checkingOwner, checkingBankName, checkingCredit);

            Console.WriteLine("Ingrese el monto a retirar de la cuenta corriente:");
            decimal withdrawalAmount = decimal.Parse(Console.ReadLine());
            checkingAccount.Withdraw(withdrawalAmount);

            Console.WriteLine("Ingrese el monto de la compra con tarjeta:");
            decimal purchaseAmount = decimal.Parse(Console.ReadLine());
            checkingAccount.MakePurchase(purchaseAmount);

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
