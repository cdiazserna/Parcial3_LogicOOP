using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositoinicial;
            int numberAccount;
            string holder, nameBank;

            Console.WriteLine("----------------------------");
            Console.WriteLine("DATOS BANCARIOS");
            Console.WriteLine("----------------------------");

            BankAccount bankAccount = new BankAccount();

            SavingAccount savingAccount = new SavingAccount();

            CheckingAccount checkingAccount = new CheckingAccount();

            Console.Write("Ingrese el numero de cuenta ");
            numberAccount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el nombre del titular de la cuenta: ");
            holder= Console.ReadLine();

            Console.Write("Ingrese el nombre del banco: ");
            nameBank = Console.ReadLine();
        

            Console.WriteLine("Ingrese el valor que depositó el banco en su cuenta de ahorros");
            depositoinicial = Convert.ToDouble(Console.ReadLine());

            MostrarResultados (holder,numberAccount, nameBank);

        }

        public static void MostrarResultados(string holder, int numberAccount, string nameBank)
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("Resultados");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

            Console.WriteLine("Titular de la cuenta: {0}",holder);

            Console.WriteLine("Banco: {0}", nameBank);

            Console.WriteLine("Cuenta corriente:{0}");
            Console.WriteLine("Crédito inicial aprobado: {0}");
            Console.WriteLine("Saldo actual: {0}");
            Console.WriteLine("Sobregiro: {0}");
            Console.WriteLine("Interés en mora: {0}");

            Console.WriteLine("Cuenta de ahorros:{0}", numberAccount);
            Console.WriteLine("Saldo: {0}");
        }
    }
}
