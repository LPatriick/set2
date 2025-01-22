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
        bool Cresc = true;
        for (int i = 0; i < n - 1; i++)
        {
            if (scv[i] > scv[i + 1])
            {
                Cresc = false;
                break;
            }
        }

        if (Cresc)
        {
            Console.WriteLine("crescatoare.");
        }
        else
        {
            Console.WriteLine("nu este crescatoare.");
        }
    }
}
