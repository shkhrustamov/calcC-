using System;

class Calculator
{
    static double Sum(double num1, double num2)
    {
        return num1 + num2;
    }

    static double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    static double CalculateModules(double num1, double num2)
    {
        return num1 % num2;
    }

    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("1. Sum");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Modules");
        Console.WriteLine("Enter your choice (1/2/3/4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Sum: " + Sum(num1, num2));
                break;
            case 2:
                Console.WriteLine("Subtraction: " + Subtract(num1, num2));
                break;
            case 3:
                Console.WriteLine("Multiplication: " + Multiply(num1, num2));
                break;
            case 4:
                Console.WriteLine("Modules: " + CalculateModules(num1, num2));
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}