using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nqobile's Calculator");
        Console.WriteLine("--------------------");

        bool running = true;

        while (running)
        {
            Console.Write("Enter first number: ");
            string? inputA = Console.ReadLine();

            if (!double.TryParse(inputA, out double a))
            {
                Console.WriteLine("Invalid number.");
                continue;
            }

            Console.Write("Enter operator (+, -, *, /, sqrt): ");
            string? op = Console.ReadLine();

            if (string.IsNullOrEmpty(op))
            {
                Console.WriteLine("Invalid operator.");
                continue;
            }

            double result = 0;

            if (op == "sqrt")
            {
                result = Math.Sqrt(a);
            }
            else
            {
                Console.Write("Enter second number: ");
                string? inputB = Console.ReadLine();

                if (!double.TryParse(inputB, out double b))
                {
                    Console.WriteLine("Invalid number.");
                    continue;
                }

                switch (op)
                {
                    case "+":
                        result = a + b;
                        break;

                    case "-":
                        result = a - b;
                        break;

                    case "*":
                        result = a * b;
                        break;

                    case "/":
                        if (b == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            continue;
                        }
                        result = a / b;
                        break;

                    default:
                        Console.WriteLine("Unknown operator.");
                        continue;
                }
            }

            Console.WriteLine($"Result: {result}");
            Console.WriteLine();

            Console.Write("Do another calculation? (y/n): ");
            string? answer = Console.ReadLine();

            if (answer?.ToLower() != "y")
            {
                running = false;
            }
        }

        Console.WriteLine("Calculator closed.");
    }
}