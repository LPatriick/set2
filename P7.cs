using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("nu contine elemente");
            return;
        }
        int first = int.Parse(Console.ReadLine());
        int maxVal = first;
        int minVal = first;
        for (int i = 1; i < n; i++)
        {
            int current = int.Parse(Console.ReadLine());
            if (current > maxValue)
                maxValue = current;
            if (current < minValue)
                minValue = current;
        }
        Console.WriteLine($" cea mai mare valoare: {maxValue});
        Console.WriteLine($" cea mai mica valoare: {minValue});
    }
}
