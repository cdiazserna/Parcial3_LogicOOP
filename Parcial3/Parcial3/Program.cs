using System;

namespace Parcial3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Balance;
            
            Console.WriteLine("Ingrese el saldo: ")
            Balance = Convert.ToDouble(Console.ReadLine());
            double Credit = 1000;
            decimal Yield;
            // Crear una cuenta corriente con un crédito de 500
            CheckingAccount checking = new CheckingAccount("115271376", "Laydi Puerta", "Bancolombia", 500);

            // Depositar 1000 en la cuenta de ahorros
            SavingAccount savings = new SavingAccount("1152713746", "Laydi Puerta", "Bancolombia", 1000);
            savings.Deposit(1000)

        }
    }
}
