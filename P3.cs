using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long sum = 0;
        long pr = 1;

        for (int i = 1; i <= n; i++)
        {
            sum += i;
            pr *= i;
        }

        Console.WriteLine($"Suma este: {sum}");
        Console.WriteLine($"Produsul este: {pr}");
    }
}
