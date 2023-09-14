// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello from C# Script!");
        Console.WriteLine("Hello, World!");
        var a = 50;
        Console.WriteLine(a);
        Console.Write("Write your name here: ");
        string input = Console.ReadLine();
        Console.WriteLine($"Hello, {input}!");
        Console.Write("Enter the value of x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        double result = Math.Sin(x);
        Console.WriteLine($"The value of sin{x} is: " + result);
    }
}
