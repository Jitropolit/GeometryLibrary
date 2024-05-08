namespace GeometryLibrary
{
    public static class GeometryCalculator
    {
        public static double CalculateCircleArea(double radius)
            => Math.PI * Math.Pow(radius, 2);

        public static double CalculateTriangleArea(double side1, double side2, double side3)
        {
            double semiperimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
        }

        public static bool IsRightTriangle(double side1, double side2, double side3)
        {
            double[] sides = [side1, side2, side3];
            Array.Sort(sides);

            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }
    }
}