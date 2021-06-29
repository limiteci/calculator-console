using System;

namespace Calculator_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = 0; decimal num2 = 0;

            Console.WriteLine("Console Calculator\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Type your first number, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type your second number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
