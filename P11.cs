using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            double current = double.Parse(Console.ReadLine());
            if (current != 0)
            {
                sum += 1 / current;
            }
            else
            {
                Console.WriteLine("nu se poate pentru 0");
            }
        }
        Console.WriteLine(sum);
    }
}
