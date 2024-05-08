using System;
using GeometryLibrary;

class Program1
{
    static void Main(string[] args)
    {
        double squareArea = GeometryCalculator.CalculateSquareArea(5);
        Console.WriteLine($"Площа квадрата зі стороною 5: {squareArea}");

        double rectangleArea = GeometryCalculator.CalculateRectangleArea(4, 6);
        Console.WriteLine($"Площа прямокутника з довжиною 4 і шириною 6: {rectangleArea}");

        double triangleArea = GeometryCalculator.CalculateTriangleArea(3, 4);
        Console.WriteLine($"Площа трикутника з основою 3 і висотою 4: {triangleArea}");
    }
}
