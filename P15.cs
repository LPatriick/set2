using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n < 3)
        {
            Console.WriteLine("nu este bitonica");
            return;
        }

        int prev = int.Parse(Console.ReadLine());
        int current = int.Parse(Console.ReadLine());
        bool aCres = false;
        bool aScaz = false;
        for (int i = 2; i < n; i++)
        {
            prev = current;
            current = int.Parse(Console.ReadLine());
            if (!aCres && current > prev)
            {
                aCres = true;
            }
            else if (aCres && current < prev)
            {
                aScaz = true;
            }
            else if (aScaz && current >= prev)
            {
                Console.WriteLine("nu este bitonica");
                return;
            }
        }
        if (aCres && aScaz)
        {
            Console.WriteLine("este bitonica");
        }
        else
        {
            Console.WriteLine("nu este bitonica");
        }
    }
}
