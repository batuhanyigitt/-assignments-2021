using System;
using System.Linq;

public class PrimesSieve
{
    private static int Maximum, Count;
    private static bool[] Primes;

    private static void Main()
    {
        Console.Write("Please write number: ");

        Maximum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Primes = Enumerable.Repeat(true, Maximum).ToArray();

        for (int P = 2; P < Math.Sqrt(Maximum) + 1; P++)
        {
            for (int N = (int)Math.Pow(P, 2); N <= Maximum; N += P)
            {
                Primes[N - 1] = false;
            }
        }

        for (int P = 2; P <= Primes.Length; P++) 
        {
            if (Primes[P - 1])
            {
                Count++;
                Console.Write($"{P} ");
            }
        }

        Console.WriteLine("\n");
        Console.WriteLine($"There are {Count} primes up to {Maximum}"); 
        Console.Write("Press a key to exit.");
        Console.ReadKey();
    }
}