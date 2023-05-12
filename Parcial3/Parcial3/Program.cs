using System;

namespace Parcial3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Cuenta Corriente
            var checkingAccount = new CheckingAccount
            {
                NumberAccount = "1234567890",
                Holder = "Juan Perez",
                NameBank = "Banco XYZ",
                Credit = 1000m,
                Overdraft = 0.4m,
                InterestRate = 0.0265m
            };

            Console.WriteLine("Cuenta Corriente");
            Console.WriteLine($"Titular: {checkingAccount.Holder}");
            Console.WriteLine($"Banco: {checkingAccount.NameBank}");
            Console.WriteLine($"Número de cuenta: {checkingAccount.NumberAccount}");

            decimal depositAmount = 500m;
            decimal withdrawAmount = 700m;
            int daysLate = 3;

            decimal currentCredit = checkingAccount.Deposit(depositAmount);
            Console.WriteLine($"Depósito de {depositAmount:C}. Crédito actual: {currentCredit:C}");

            decimal currentBalance = checkingAccount.Withdraw(withdrawAmount);
            Console.WriteLine($"Retiro de {withdrawAmount:C}. Saldo actual: {currentBalance:C}");

            decimal currentOverdraft = checkingAccount.CalculateOverdraft();
            Console.WriteLine($"Sobregiro disponible: {currentOverdraft:C}");

            decimal latePaymentFee = checkingAccount.CalculateLatePayment(daysLate);
            Console.WriteLine($"Intereses por pago tardío ({daysLate} días): {latePaymentFee:C}");
        }
    }
}
