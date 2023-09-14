// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Net.Security;

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
        int b = 40;
        if (b > 40) {
            Console.WriteLine("Yes");
        }
        else {
            Console.WriteLine("No");
        }
        int[] array = {1, 2, 3, 4, 5, 6};
        Console.WriteLine(array[0]);
        foreach (int num in array) {
            Console.WriteLine(num);
        }
        double value = 0.99;
        double cos = Math.Asin(value);
        Console.WriteLine(cos);
        Console.Write("Enter a number: ");
        double number = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(number);
    }
}
