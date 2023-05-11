using System;

public class Numero
{
    public int NumeroEntero { get; set; }


    public bool esPrimo()
    {

        if (NumeroEntero % 2 == 0)
        {
            return true;
        }
        else return false;
    }
}
