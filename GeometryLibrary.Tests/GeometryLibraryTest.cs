using static GeometryLibrary.GeometryCalculator;
using GeometryLibrary.Shapes;

namespace GeometryLibrary.Tests
{
    public class GeometryLibraryTest
    {
        [Test]
        public void TestCalculateCircleArea()
            => Assert.That(Math.Round(CalculateCircleArea(10)), Is.EqualTo(314));
        [Test]
        public void TestCalculateTriangleArea()
            => Assert.That(Math.Round(CalculateTriangleArea(2, 3, 4)), Is.EqualTo(3));
        [Test]
        public void TestIsRightTriangle()
            => Assert.That(IsRightTriangle(3, 4, 5), Is.EqualTo(true));

        [Test]
        public void TestShapeCircle()
        {
            Circle circle = new Circle(12);
            Assert.That(Math.Round(circle.CalculateArea()), Is.EqualTo(452));
        }

        [Test]
        public void TestShapeRectangle()
        {
            Rectangle rectangle = new Rectangle(15, 20);
            Assert.That(Math.Round(rectangle.CalculateArea()), Is.EqualTo(300));
        }
    }
}