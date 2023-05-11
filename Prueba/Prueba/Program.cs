using System;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool primo;
            Console.WriteLine("POO NUMERO");
            Numero numero = new Numero();
            Console.WriteLine("Ingrese un numero");
            numero.NumeroEntero = Convert.ToInt32(Console.ReadLine());
            primo = numero.esPrimo();

            if (primo)
            {
                Console.WriteLine("El numero es primo");
            }

        }
    }
}
