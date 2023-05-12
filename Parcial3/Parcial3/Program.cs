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
            SavingAccount savingsAccount = new SavingAccount
            {
                NumberAccount = "0987654321",
                Holder = "Maria Lopez",
                NameBank = "Banco XYZ",
                Balance = 1500m,
                Yield = 1.5m
            };

            Console.WriteLine("\nCuenta de Ahorros");
            Console.WriteLine($"Titular: {savingsAccount.Holder}");
            Console.WriteLine($"Banco: {savingsAccount.NameBank}");
            Console.WriteLine($"Número de cuenta: {savingsAccount.NumberAccount}");

            decimal depositAmount2 = 1000m;
            decimal withdrawAmount2 = 2000m;
            decimal transferAmount = 500m;

            decimal currentBalance2 = savingsAccount.Deposit(depositAmount2);
            Console.WriteLine($"Depósito de {depositAmount2:C}. Saldo actual: {currentBalance2:C}");

            currentBalance2 = savingsAccount.Withdraw(withdrawAmount2);
            Console.WriteLine($"Retiro de {withdrawAmount2:C}. Saldo actual: {currentBalance2:C}");

            decimal transferAmountResult = savingsAccount.Transfer(transferAmount);
            Console.WriteLine($"Transferencia de {transferAmount:C}. Saldo actual: {currentBalance2:C}");

            decimal currentYield = savingsAccount.CalculateYield();
            Console.WriteLine($"Rendimiento mensual: {currentYield:C}");
        }
    }
}
