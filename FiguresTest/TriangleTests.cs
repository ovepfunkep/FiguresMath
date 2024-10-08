using FiguresMath.Shapes.Base;
using FiguresMath.Shapes.Triangle;

namespace FiguresTest
{
    public class TriangleTests
    {
        [Test]
        public void Create_Correct_Creates()
        {
            // Arrange
            double sideA = 3.5;
            double sideB = 4;
            double sideC = 5;
            Triangle? triangle = null;

            // Act  
            Assert.DoesNotThrow(() => triangle = new Triangle(sideA, sideB, sideC));

            // Assert  
            Assert.That(triangle.Sides, Is.EquivalentTo(new[] { sideA, sideB, sideC }));
        }

        [Test]
        public void Create_NegativeArguments_Throws()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = -1;

            // Act & Assert 
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Test]
        public void Create_ViolatesInequalityRule_Throws()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 7;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Test]
        public void GetArea_ReturnsCorrectArea()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            Shape shape = new Triangle(sideA, sideB, sideC);

            // Act & Assert
            Assert.That(shape.Area, Is.EqualTo(Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC))));
        }

        [Test]
        public void GetIsRectangular_IsRectangular_ReturnsTrue()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new(sideA, sideB, sideC);

            // Act & Assert
            Assert.That(triangle.IsRectangular, Is.EqualTo(true));
        }

        [Test]
        public void GetIsRectangular_IsNotRectangular_ReturnsFalse()
        {
            // Arrange
            double sideA = 6;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new(sideA, sideB, sideC);

            // Act & Assert
            Assert.That(triangle.IsRectangular, Is.EqualTo(false));
        }
    }
}