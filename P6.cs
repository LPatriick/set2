using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n < 2)
        {
            Console.WriteLine("ordine crescatoare");
            return;
        }
        int prev = int.Parse(Console.ReadLine());
        bool isIncr = true;
        for (int i = 1; i < n; i++)
        {
            int current = int.Parse(Console.ReadLine());
            if (current < prev)
            {
                isIncr= false;
                break;
            }
            prev = current;
        }
        if (isIncr)
            Console.WriteLine("ordine crescatoare");
        else
            Console.WriteLine("nu este in ordine crescatoare");
    }
}
