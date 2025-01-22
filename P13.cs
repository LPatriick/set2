using System;

class Program
{
    static void Main()
    {
     int n = int.Parse(Console.ReadLine());
        if (n <= 1)
        {
            Console.WriteLine("secventa este crescatoare");
            return;
        }

        int prev = int.Parse(Console.ReadLine());
        int numarRupturi = 0;
        bool estePrimul = true;
        for (int i = 1; i < n; i++)
        {
            int current = int.Parse(Console.ReadLine());
            if (prev > current)
            {
                numarRupturi++;
            }
            if (numarRupturi > 1)
            {
                Console.WriteLine("secventa nu este crescatoare");
                return;
            }

            prev = current;
        }
        int firstElement = int.Parse(Console.ReadLine());
        if (prev > firstElement)
        {
            numarRupturi++;
        }
        if (numarRupturi <= 1)
        {
            Console.WriteLine("secventa este crescatoare");
        }
        else
        {
            Console.WriteLine("secventa nu este crescatoare");
        }
    }
}
