using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n < 2)
        {
            Console.WriteLine("doar un element");
            return;
        }
        int prev = int.Parse(Console.ReadLine());
        int current = int.Parse(Console.ReadLine());
        bool isIncr = current > prev;
        bool isDecr= current < prev;
        bool isMono = true;
        for (int i = 3; i <= n; i++)
        {
            prev = current;
            current = int.Parse(Console.ReadLine());

            if (isIncr && current < prev || isDecr && current > prev)
            {
                isMono = false;
                break;
            }
            else
            {
                isIncr = isIncr && current > prev;
                isDecr = isDecr && current < prev;
            }
        }
        if (isMono)
            Console.WriteLine("monotona");
        else
            Console.WriteLine("nu este monotona");
    }
}
