using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int prev = int.Parse(Console.ReadLine());
        bool isMono = true;
        bool isCresc = true;
        bool isDesc = true;
        int numarRupturi = 0;

        for (int i = 1; i < n; i++)
        {
            int current = int.Parse(Console.ReadLine());
            if (prev > current)
            {
                isCresc = false;
            }
            if (prev < current)
            {
                isDesc = false;
            }
            if (prev > current)
            {
                numarRupturi++;
            }
            prev = current;
        }
        int firstElement = int.Parse(Console.ReadLine());
        if (prev > firstElement)
        {
            numarRupturi++;
        }
        if (isCresc || isDesc || numarRupturi <= 1)
        {
            Console.WriteLine("este monotona ");
        }
        else
        {
            Console.WriteLine("nu este monotona");
        }
    }
}
