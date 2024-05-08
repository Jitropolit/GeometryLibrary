namespace GeometryLibrary.Shapes
{
    public class Rectangle : Shape
    {
        public double width { get; set; }
        public double height { get; set; }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculateArea()
            => width * height;
    }
}