using FiguresMath.Shapes.Triangle;
using FiguresMath.Validation.Utils;
using FiguresMath.Validation.Validators.Base;

namespace FiguresMath.Validation.Validators
{
    internal class TriangleValidator : ValidatorBase<Triangle>
    {
        public static ValidationResult ValidateTriangleInequality(double sideA, double sideB, double sideC) =>
            Validate(sideA >= sideB + sideC ||
                     sideB >= sideA + sideC ||
                     sideC >= sideA + sideB, "Each triangle side must be less that the other two");

        public new static IEnumerable<Func<Triangle, ValidationResult>> ValidationFunctions = ValidatorBase<Triangle>.ValidationFunctions.Concat([
            (triangle) => ValidateTriangleInequality(triangle.Sides[0], triangle.Sides[1], triangle.Sides[2])
           ,(triangle) => ValidateArguments(triangle.Sides)
            ]);
    }
}
