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
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            if (scv[i] == i)
            {
                count++;
            }
        }

        Console.WriteLine($"numar de elemente egale cu pozitia: {count}");
    }
}
