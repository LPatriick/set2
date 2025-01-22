using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("n trebuie să fie pozitiv.");
            return;
        }

        long fibonacci = Fibonacci(n);
        Console.WriteLine($"{n} numar din sir este: {fib}");
    }

    static long Fib(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        long a = 0, b = 1, temp;
        for (int i = 2; i <= n; i++)
        {
            temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }
}
