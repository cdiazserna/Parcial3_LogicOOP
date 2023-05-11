using System;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool par;
            Console.WriteLine("POO NUMERO");
            Numero numero = new Numero();
            Console.WriteLine("Ingrese un numero");
            numero.NumeroEntero = Convert.ToInt32(Console.ReadLine());
            par= numero.esPar();

            if (par)
            {
                Console.WriteLine("El numero es par");
            }

        }
    }
}
