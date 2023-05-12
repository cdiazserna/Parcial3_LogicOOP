using System;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount count1 = new CheckingAccount();
            Console.WriteLine("Ingrese el credito\n");
            count1.credit = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese el número de retiros");
            int n = Convert.ToInt32(Console.ReadLine());
            decimal overdraft;

            for (int i = 0; i < n; i++)
            {
                if (count1.credit >= 0)
                {
                    count1.withDraw();
                }
                else
                {
                    overdraft = count1.calculateOverdraft();
                    count1.credit = count1.credit + overdraft;
                }
                
            }

            Console.WriteLine("Ingrese el número de Compras con tarjeta \n");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (count1.credit >= 0)
                {
                    count1.withDraw();
                }
                else
                {
                    overdraft = count1.calculateOverdraft();
                    count1.credit = count1.credit + overdraft;
                }
            }
            Console.WriteLine("ingrese los dias en mora");
            count1.daysLate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Mora: " + count1.calculateLatePayment());


        }
    }
}
