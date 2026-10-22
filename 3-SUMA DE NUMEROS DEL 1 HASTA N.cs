// Calcular la suma de todos los números desde el 1 hasta el n.
using System;

class Program3
{
    static int Suma(int n)
    {
        if (n <= 0)
            return 0;

        return n + Suma(n - 1);
    }

    static void Main()
    {
        Console.Write("Ingrese el número: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 10000)
        {
            Console.WriteLine("Ingresa un numero entre 0 y 10000");
        }

        Console.WriteLine("la suma es: " + Suma(n));
    }
}