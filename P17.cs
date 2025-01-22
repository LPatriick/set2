using System;

class Program
{
    static bool SecventaCorMaxim(ref int nivelMaxim)
    {
        string secventa = Console.ReadLine();
        int pDeschise = 0;
        nivelMaxim = 0;
        foreach (char caracter in secventa)
        {
            if (caracter == '0')
            {
                pDeschise++;
                nivelMaxim = Math.Max(nivelMaxim, pDeschise);
            }
            else if (caracter == '1')
            {
                if (pDeschise == 0)
                {
                    return false;
                }
                pDeschise--;
            }
            else
            {
                return false;
            }
        }
        return pDeschise == 0;
    }
    static void Main()
    {
        int nivelMaxim = 0;
        if (SecventaCorMaxim(ref nivelMaxim))
        {
            Console.WriteLine("Secventa corecta");
            Console.WriteLine($"Nivelul maxim de incuibare este: {nivelMaxim}");
        }
        else
        {
            Console.WriteLine("Secventa incorecta");
        }
    }
}
