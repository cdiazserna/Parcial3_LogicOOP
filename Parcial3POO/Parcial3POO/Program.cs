using System;

namespace Parcial3POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una cuenta corriente
            Console.WriteLine("Ingrese el nombre del titular de la cuenta corriente:");
            string checkingHolder = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del banco:");
            string checkingNameBank = Console.ReadLine();
            Console.WriteLine("Ingrese el crédito mensual de la cuenta corriente:");
            decimal checkingCredit = decimal.Parse(Console.ReadLine());

            CheckingAccount checkingAccount = new CheckingAccount(checkingHolder, checkingNameBank, checkingCredit);

            // Realizar operaciones en la cuenta corriente
            Console.WriteLine("Ingrese el monto a retirar de la cuenta corriente:");
            decimal withdrawalAmount = decimal.Parse(Console.ReadLine());
            checkingAccount.Withdraw(withdrawalAmount);

            Console.WriteLine("Ingrese el monto de la compra con tarjeta:"); 
            decimal purchaseAmount = decimal.Parse(Console.ReadLine());
            checkingAccount.MakePurchase(purchaseAmount);

            // Obtener los valores calculados

            Console.WriteLine("Cuenta Corriente");
            Console.WriteLine("Titular:"+ checkingAccount.Holder);
            Console.WriteLine("Banco: " + checkingAccount.NameBank);
            Console.WriteLine("Crédito: " + checkingAccount.Credit);
            Console.WriteLine("Sobregiro: " + checkingAccount.Overdraft);
            Console.WriteLine("Intereses: " + checkingAccount.InterestRate);
        


        }
    }
}
