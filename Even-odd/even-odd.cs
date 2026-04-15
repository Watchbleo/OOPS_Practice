using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Even numbers from 1 to 100:");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0) // Even check
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine("\n\nOdd numbers from 1 to 100:");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 != 0) // Odd check
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine(); // Final newline
    }
}
