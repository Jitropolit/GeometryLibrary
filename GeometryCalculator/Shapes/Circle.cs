namespace GeometryLibrary.Shapes
{
    public class Circle : Shape
    {
        public double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
            => Math.PI * Math.Pow(radius, 2);
    }
}
