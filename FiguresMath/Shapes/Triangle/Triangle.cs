using FiguresMath.Shapes.Base;
using FiguresMath.Validation.Utils;
using FiguresMath.Validation.Validators;

using static FiguresMath.Helpers.TriangeHelper;

namespace FiguresMath.Shapes.Triangle
{
    public record Triangle : ShapeWithSides
    {
        public override double Area => Math.Sqrt(SemiPerimeter * (SemiPerimeter - Sides[0]) * (SemiPerimeter - Sides[1]) * (SemiPerimeter - Sides[2]));

        public bool IsRectangular => IsRectangular(Sides[0], Sides[1], Sides[2]);

        public override Func<ValidationResult> Validate => () => TriangleValidator.Validate(this);

        public Triangle(double sideA, double sideB, double sideC) : base([sideA, sideB, sideC])
        {
            Sides[0] = sideA;
            Sides[1] = sideB;
            Sides[2] = sideC;
        }

        public void Deconstruct(out double sideA, out double sideB, out double sideC)
        {
            sideA = Sides[0];
            sideB = Sides[1];
            sideC = Sides[2];
        }
    }
}
