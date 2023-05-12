using System;
using System.Drawing;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount count1 = new CheckingAccount();
            Console.WriteLine("Ingrese el numero de cuenta: ");
            count1.numberAccount = Convert.ToInt32(Console.ReadLine());
            count1.deposit();
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
            Console.WriteLine("ingrese los dias en mora: ");
            count1.daysLate = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Mora: " + count1.calculateLatePayment());

            Console.Clear();

            SavingAccount account = new SavingAccount();
            Console.WriteLine("Ingrese el numero de cuenta: ");
            account.numberAccount = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingrese saldo: ");
            account.balance = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("ingrese dinero a depositar al usuario: ");
            account.deposit();


            Console.WriteLine("Ingrese el número de trasferencias");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (account.balance >= 0)
                {
                    account.trasfer();
                }
                else
                {
                    Console.WriteLine("Sin saldo");
                }



            }


            Console.WriteLine("Ingrese el número de trasferencias \n");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (count1.credit >= 0)
                {
                    account.trasfer();
                }
                else
                {
                    Console.WriteLine("Sin saldo");
                }
            }
            Console.Clear();

            //Console.WriteLine("el rendimiento es de: " + account.calculateYield());
            //Debes mostrar al final de la pantalla, el valor depositado en cada cuenta,
            //nombre del titular, nombre del banco, crédito, sobregiro, intereses, saldo y rendimientos y los valores dados por los cálculos de cada método.
            Console.WriteLine("Checking account:");
            Console.WriteLine("valor depositado actual(credito) es: " + count1.credit);




        }
    }
}
