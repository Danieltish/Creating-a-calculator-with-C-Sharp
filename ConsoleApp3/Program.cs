using System;

namespace AdvancedCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Advanced Calculator");
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.WriteLine("5. Square Root (√)");
            Console.WriteLine("6. Power (^)");
            Console.WriteLine("7. Sine (sin)");
            Console.WriteLine("8. Cosine (cos)");
            Console.WriteLine("9. Tangent (tan)");
            Console.WriteLine("10. Logarithm (log)");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            double num1 = 0, num2 = 0, result = 0;

            if (choice >= 1 && choice <= 4 || choice == 6)
            {
                Console.Write("Enter the first number: ");
                num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                num2 = double.Parse(Console.ReadLine());
            }
            else if (choice == 5 || choice >= 7 && choice <= 10)
            {
                Console.Write("Enter the number: ");
                num1 = double.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero.");
                    }
                    break;
                case 5:
                    if (num1 >= 0)
                    {
                        result = Math.Sqrt(num1);
                        Console.WriteLine($"Result: √{num1} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot calculate the square root of a negative number.");
                    }
                    break;
                case 6:
                    result = Math.Pow(num1, num2);
                    Console.WriteLine($"Result: {num1} ^ {num2} = {result}");
                    break;
                case 7:
                    result = Math.Sin(num1 * Math.PI / 180); // Converts degrees to radians
                    Console.WriteLine($"Result: sin({num1}) = {result}");
                    break;
                case 8:
                    result = Math.Cos(num1 * Math.PI / 180); // Converts degrees to radians
                    Console.WriteLine($"Result: cos({num1}) = {result}");
                    break;
                case 9:
                    result = Math.Tan(num1 * Math.PI / 180); // Converts degrees to radians
                    Console.WriteLine($"Result: tan({num1}) = {result}");
                    break;
                case 10:
                    if (num1 > 0)
                    {
                        result = Math.Log10(num1);
                        Console.WriteLine($"Result: log({num1}) = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Logarithm of non-positive number is undefined.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
