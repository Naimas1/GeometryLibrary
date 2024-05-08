using System;

namespace GeometryLibrary
{
    public static class GeometryCalculator
    {
        public static double CalculateSquareArea(double side)
        {
            return side * side;
        }

        public static double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }

        public static double CalculateTriangleArea(double @base, double height)
        {
            return 0.5 * @base * height;
        }
    }
}
