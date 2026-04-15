using System;
class Program
{
   static void Main()
   {
       Console.WriteLine("Prime Numbers between 1 and 100:");
       for (int i = 2; i <= 100; i++)
       {
           bool isPrime = true;
           for (int j = 2; j <= Math.Sqrt(i); j++)
           {
               if (i % j == 0)
               {
                   isPrime = false;
                   break;
               }
           }
           if (isPrime)
               Console.Write(i + " ");
       }
       Console.ReadKey();
   }
}