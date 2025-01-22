using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int nCount = 0;
        int zCount = 0;
        int pCount = 0;
        for (int i = 0; i < n; i++)
        {
            int numar = int.Parse(Console.ReadLine());

            if (numar < 0)
            {
                negativeCount++;
            }
            else if (numar == 0)
            {
                zeroCount++;
            }
            else
            {
                positiveCount++;
            }
        }
        Console.WriteLine($"negative: {nCount}");
        Console.WriteLine($"zero: {zCount}");
        Console.WriteLine($"pozitive: {pCount}");
    }
}
