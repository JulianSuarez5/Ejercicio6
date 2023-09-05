using System;

class ParImpar
{
    static void Main()
    {
        int numero;

        Console.Write("Ingrese un número: ");
        numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("El número es par");
        }
        else
        {
            Console.WriteLine("El número es impar");
        }

        Console.ReadKey();
    }
}

