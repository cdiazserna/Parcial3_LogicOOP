using System;

public class Numero
{
    public int NumeroEntero { get; set; }


    public bool esPar()
    {

        if (NumeroEntero % 2 == 0)
        {
            return true;
        }
        else return false;
    }
}
