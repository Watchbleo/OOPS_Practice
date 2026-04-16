using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        List<int> numbers = Enumerable.Range(1, 10).ToList();
        
    
        Random rng = new Random();

    
        int n = numbers.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
          
            int value = numbers[k];
            numbers[k] = numbers[n];
            numbers[n] = value;
        }

     
        Console.WriteLine("Numbers from 1 to 100 in random order:");
        foreach (int numb in numbers)
        {
            Console.Write(numb + " ");
        }
    }
}
