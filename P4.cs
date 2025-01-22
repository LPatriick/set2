using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a = int.Parse(Console.ReadLine());
        int pos = -1;
        for (int i = 0; i < n; i++)
        {
            int curent = int.Parse(Console.ReadLine());
            if (curent == a)
            {
                pos = i;
                break;
            }
        }
        Console.WriteLine($"Numarul {a} este pe pozitia: {pos}");
    }
}
