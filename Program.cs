using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Triangle Area Calculator");

        // Get user input for the base
        Console.Write("Enter the base of the triangle: ");
        double baseLength = Convert.ToDouble(Console.ReadLine());

        // Get user input for the height
        Console.Write("Enter the height of the triangle: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the triangle
        double area = CalculateTriangleArea(baseLength, height);

        // Display the result
        Console.WriteLine($"The area of the triangle with base {baseLength} and height {height} is: {area}");

        // Wait for user input before closing the console window
        Console.ReadLine();
    }

    // Function to calculate the area of a triangle
    static double CalculateTriangleArea(double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }
}
