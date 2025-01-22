using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            int nr = int.Parse(Console.ReadLine());
            if (nr % 2 == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}
