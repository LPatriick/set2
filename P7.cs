using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] scv = new int[n];
        for (int i = 0; i < n; i++)
        {
            scv[i] = int.Parse(Console.ReadLine());
        }
        int min= scv[0];
        int max = scv[0];
        for (int i = 1; i < n; i++)
        {
            if (scv[i] < min)
            {
                min = scv[i];
            }
            if (scv[i] > max)
            {
                max = scv[i];
            }
        }

        Console.WriteLine($"Cea mai mica valoare: {min}");
        Console.WriteLine($"Cea mai mare valoare: {max}");
    }
}
