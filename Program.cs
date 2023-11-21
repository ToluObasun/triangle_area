using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Triangle Area Calculator");

        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Input 1 to use this Method--- Calculate area based on base and height");
        Console.WriteLine("2. Input 2 to use this Method--- Calculate area based on three sides");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                CalculateAreaByBaseAndHeight();
                break;
            case 2:
                CalculateAreaByThreeSides();
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting...");
                break;
        }

        // Wait for user input before closing the console window
        Console.ReadLine();
    }

    static void CalculateAreaByBaseAndHeight()
    {
        Console.Write("Enter the base of the triangle: ");
        double baseLength = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double area = CalculateTriangleArea(baseLength, height);
        Console.WriteLine($"The area of the triangle with base {baseLength} and height {height} is: {area}");
    }

    static void CalculateAreaByThreeSides()
    {
        Console.Write("Enter the length of side 1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 3: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        double area = CalculateTriangleArea(side1, side2, side3);
        Console.WriteLine($"The area of the triangle with sides {side1}, {side2}, and {side3} is: {area}");
    }

    static double CalculateTriangleArea(double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }

    static double CalculateTriangleArea(double side1, double side2, double side3)
    {
        // Heron's formula for the area of a triangle
        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }
}
