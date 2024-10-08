using FiguresMath.Shapes.Base;
using FiguresMath.Shapes.Circle;

namespace FiguresTest
{
    public class CircleTests
    {
        [Test]
        public void Create_Correct_Creates()
        {
            // Arrange
            double radius = 5.5;
            Circle? circle = null;

            // Act  
            Assert.DoesNotThrow(() => circle = new Circle(radius));

            // Assert  
            Assert.That(circle.Radius, Is.EqualTo(radius));
        }

        [Test]
        public void Create_NegativeArguments_Throws()
        {
            // Arrange
            double radius = -5;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Test]
        public void GetArea_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            Shape shape = new Circle(5);

            // Act & Assert
            Assert.That(shape.Area, Is.EqualTo(Math.PI * Math.Pow(radius, 2)));
        }
    }
}