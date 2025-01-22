using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("nu contine elemente");
            return;
        }
        int prev = int.Parse(Console.ReadLine());
        int maxCount = 1;
        int currentCount = 1;
        for (int i = 1; i < n; i++)
        {
            int current = int.Parse(Console.ReadLine());
            if (current == prev)
            {
                currentCount++;
            }
            else
            {
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
                currentCount = 1;
            }
            prev = current;
        }
        if (currentCount > maxCount)
        {
            maxCount = currentCount;
        }

        Console.WriteLine($"Numarul maxim de numere consecutive egale este {maxCount}");
    }
}
