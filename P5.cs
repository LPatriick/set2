using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            int current = int.Parse(Console.ReadLine());
            if (current == i)
            {
                count++;
            }
        }
        Console.WriteLine($"Numarul de elemente egale cu pozitia este:{count}");
    }
}
