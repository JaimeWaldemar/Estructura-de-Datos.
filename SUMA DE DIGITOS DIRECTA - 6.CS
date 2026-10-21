using System;

class Program
{
    static int SumaDigitos(int n)
    {
        if (n == 0) return 0;                       // caso base: ya no quedan dígitos
        return (n % 10) + SumaDigitos(n / 10);      // último dígito + suma del resto
    }

    static void Main()
    {
        Console.Write("Ingresa un número entero positivo: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("El número debe ser positivo.");
            return;
        }

        Console.WriteLine($"La suma de los dígitos de {n} es: {SumaDigitos(n)}");
    }
}