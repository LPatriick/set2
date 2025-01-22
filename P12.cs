using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int groupCount = 0;
        bool inGroup = false;
        for (int i = 0; i < n; i++)
        {
            int current = int.Parse(Console.ReadLine());
            if (current != 0)
            {
                if (!inGroup)
                {
                    groupCount++;
                    inGroup = true;
                }
            }
            else
            {
                inGroup = false;
            }
        }
        Console.WriteLine($"numarul de grupuri de numere consecutive diferite de zero este: {groupCount}");
    }
}
