using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num1= 10;
        int num2= 15;
        int add=num1+num2;
        Console.WriteLine ("Addition of 2 Numbers is: "+add);

        Console.WriteLine ("------------------------------------------");

        int substration= num2 - num1;
        Console.WriteLine ("Soubstration of 2 Numbers are: "+substration);

        Console.WriteLine ("------------------------------------------");

        int mult= num2 * num1;
        Console.WriteLine ("multiplication of 2 Numbers are: "+mult);

        Console.WriteLine ("------------------------------------------");

        int div= num2 / num1;
        Console.WriteLine ("division of 2 Numbers are: "+div);

        Console.WriteLine ("------------------------------------------");

        int mod = num2%num1;
        Console.WriteLine ("division of 2 Numbers are: "+mod);
    }
}