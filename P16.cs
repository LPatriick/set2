using System;

class Program
{
    static bool EsteBitonica(int n)
    {
        int prev = int.Parse(Console.ReadLine());
        int current = int.Parse(Console.ReadLine());
        if (n < 3)
            return false;
        bool crescut = false, scazut = false;
        for (int i = 2; i < n; i++)
        {
            prev = current;
            current = int.Parse(Console.ReadLine());
            if (!crescut && current > prev)
            {
                crescut = true;
            }
            else if (crescut && current < prev)
            {
                scazut = true;
            }
            else if (scazut && current >= prev)
            {
                return false;
            }
        }
        return crescut && scazut;
    }

    static bool EsteBitonicaRotita(int n)
    {
        if (EsteBitonica(n))
        {
            return true;
        }
        for (int i = 1; i < n; i++)
        {
            int first = int.Parse(Console.ReadLine());
            int prev = first;
            int current = int.Parse(Console.ReadLine());
            bool crescut = false, scazut = false;
            for (int j = 1; j < n; j++)
            {
                prev = current;
                current = int.Parse(Console.ReadLine());
                if (!crescut && current > prev)
                {
                    crescut = true;
                }
                else if (crescut && current < prev)
                {
                    scazut = true;
                }
                else if (scazut && current >= prev)
                {
                    break;
                }
            }
            if (crescut && scazut)
            {
                return true;
            }
        }

        return false;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (EsteBitonicaRotita(n))
        {
            Console.WriteLine("este bitonica rotita");
        }
        else
        {
            Console.WriteLine("nu este bitonica rotita");
        }
    }
}
