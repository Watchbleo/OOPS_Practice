using System;
using System.Linq;

class Program
{
    static void Main()
    {
        try
        {
            
            // Generate uppercase alphabet A-Z
            //char[] alphabet = Enumerable.Range('A', 26)
            //                            .Select(c => (char)c)
            //                            .ToArray();

            // Generate numbers 1-100
            int[] numbers = Enumerable.Range(1, 100).ToArray();
        
            // Display alphabet
           // Console.WriteLine("Alphabet (A-Z):");
          //  Console.WriteLine(string.Join(" ", alphabet));

            // Display numbers
            Console.WriteLine("\nNumbers (1-100):");
            Console.WriteLine(string.Join(" ", numbers));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}

