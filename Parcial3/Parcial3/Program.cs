using System;

namespace BankAccounts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Crear una cuenta corriente con un crédito de 500
            CheckingAccount checking = new CheckingAccount("1152713746", "Leydi Puerta", "Bancolombia", 200);

            // Depositar 5000 en la cuenta de ahorros
            SavingsAccount savings = new SavingsAccount("1152713746", "Leydi Puerta", "Bancolombia", 5000);
            savings.Deposit(1000);

            // Realizar algunas transacciones en cada cuenta
            checking.Withdraw(200);
            checking.Withdraw(400);
            checking.Deposit(100);
            checking.Withdraw(600);
            savings.Transfer(checking, 500);
            savings.CalculateYields();

            // Mostrar la información de las cuentas
            Console.WriteLine("Cuenta Corriente:");
            Console.WriteLine("Titular: " + checking.Holder);
            Console.WriteLine("Banco: " + checking.NameBank);
            Console.WriteLine("Crédito: " + checking.Credit);
            Console.WriteLine("Sobregiro: " + checking.Overdraft);
            Console.WriteLine("Interés: " + checking.InterestRate);
            Console.WriteLine("Saldo: " + checking.Balance);
            Console.WriteLine();

            Console.WriteLine("Cuenta de Ahorros:");
            Console.WriteLine("Titular: " + savings.Holder);
            Console.WriteLine("Banco: " + savings.NameBank);
            Console.WriteLine("Saldo: " + savings.Balance);
            Console.WriteLine("Rendimientos: " + savings.Yield);
        }
    }

}