using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] scv = new int[n];
        for (int i = 0; i < n; i++)
        {
            scv[i] = int.Parse(Console.ReadLine());
        }
        int a = int.Parse(Console.ReadLine());
        int poz = -1;
        for (int i = 0; i < n; i++)
        {
            if (scv[i] == a)
            {
                poz = i; 
                break; 
            }
        }

        if (poz == -1)
        {
            Console.WriteLine($"{a} nu se afla in secventa.");
        }
        else
        {
            Console.WriteLine($"{a} se afla pe pozitia: {pozitie}");
        }
    }
}
