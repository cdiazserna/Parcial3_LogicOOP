using System;

namespace Parcial3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Cuenta Corriente
            CheckingAccount checkingAccount = new CheckingAccount
            {
                NumberAccount = "12345673",
                Holder = "Juan Perez",
                NameBank = "Banco XYZ",
                Credit = 1000m,
                Overdraft = 0.4m,
                InterestRate = 0.0265m,
            };

            Console.WriteLine("Cuenta Corriente");
            Console.WriteLine($"Titular: {checkingAccount.Holder}");
            Console.WriteLine($"Banco: {checkingAccount.NameBank}");
            Console.WriteLine($"Número de cuenta: {checkingAccount.NumberAccount}");

            Console.WriteLine("Ingrese la cantidad de dinero a depositar");
            decimal depositAmount = Convert.ToDecimal( Console.ReadLine() );
            decimal currentCredit = checkingAccount.Deposit(depositAmount);
            Console.WriteLine($"Depósito de {depositAmount:C}. Crédito actual: {currentCredit:C}");

            Console.WriteLine("Ingrese la cantidad de dinero a retirar");
            decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
            decimal currentBalance = checkingAccount.Withdraw(withdrawAmount);
            Console.WriteLine($"Retiro de {withdrawAmount:C}. Saldo actual: {currentBalance:C}");
           
            decimal currentOverdraft = checkingAccount.CalculateOverdraft();
            Console.WriteLine($"Sobregiro disponible: {currentOverdraft:C}");

            Console.WriteLine("Ingrese la cantidad de días de retraso");
            int daysLate = Convert.ToInt32(Console.ReadLine());
            decimal latePaymentFee = checkingAccount.CalculateLatePayment(daysLate);
            Console.WriteLine($"Intereses por pago tardío ({daysLate} días): {latePaymentFee:C}");

            // Cuenta de Ahorros
            SavingAccount savingAccount = new SavingAccount
            {
                NumberAccount = "0987654321",
                Holder = "Maria Lopez",
                NameBank = "Banco XYZ",
                Balance = 1500m,
                Yield = 1.5m
            };

            Console.WriteLine("\nCuenta de Ahorros");
            Console.WriteLine($"Titular: {savingAccount.Holder}");
            Console.WriteLine($"Banco: {savingAccount.NameBank}");
            Console.WriteLine($"Número de cuenta: {savingAccount.NumberAccount}");

            Console.WriteLine("Ingrese la cantidad de dinero a depositar");
            decimal depositAmount2 = Convert.ToDecimal(Console.ReadLine());
            decimal currentBalance2 = savingAccount.Deposit(depositAmount2);
            Console.WriteLine($"Depósito de {depositAmount2:C}. Saldo actual: {currentBalance2:C}");

            Console.WriteLine("Ingrese la cantidad de dinero a retirar");
            decimal withdrawAmount2 = Convert.ToDecimal(Console.ReadLine());
            currentBalance2 = savingAccount.Deposit(depositAmount2);
            Console.WriteLine($"Retiro de {withdrawAmount2:C}. Saldo actual: {currentBalance2:C}");

            Console.WriteLine("Ingrese la cantidad de dinero que desea transferir");
            decimal transferAmount = Convert.ToDecimal(Console.ReadLine());
            decimal transferAmountResult = savingAccount.Transfer(transferAmount);
            Console.WriteLine($"Transferencia de {transferAmount:C}. Saldo actual: {currentBalance2:C}");

            decimal currentYield = savingAccount.CalculateYield();
            Console.WriteLine($"Rendimiento mensual: {currentYield:C}");
        }
    }
}
