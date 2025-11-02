using System;
namespace add;

class Program
{
    public static void Main(string[] args)
    {
        int number1,number2;
        Console.Write("Enter the number 1: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the number 2: ");
        number2 = Convert.ToInt32(Console.ReadLine());
        int result = number1 + number2;
        Console.WriteLine("Result: "+result);
    }
}