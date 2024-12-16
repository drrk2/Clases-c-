using System;
using System.Collections;

public class Listasmaestros
{
    public static void Main()
    {
        ArrayList listamaestros = new ArrayList();
        
        
        listamaestros.Add("Abraham");
        listamaestros.Add("Cesar");
        listamaestros.Add("Fatima");

        
        foreach (object maestro in listamaestros)
        {
            Console.WriteLine(maestro);
        }
    }
}