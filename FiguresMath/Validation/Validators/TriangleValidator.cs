using FiguresMath.Shapes.Base;
using FiguresMath.Shapes.Triangle;
using FiguresMath.Validation.Utils;
using FiguresMath.Validation.Validators.Base;

namespace FiguresMath.Validation.Validators
{
    internal class TriangleValidator : ValidatorBase
    {
        public override Shape ValidatingShape { get; set; }

        public static ValidationResult ValidateTriangleInequality(double sideA, double sideB, double sideC) =>
            Validate(sideA >= sideB + sideC ||
                     sideB >= sideA + sideC ||
                     sideC >= sideA + sideB, "Each triangle side must be less that the other two");

        public static ValidationResult ValidateTriangleInequality(double[] sides) => ValidateTriangleInequality(sides[0], sides[1], sides[2]);

        public override IEnumerable<Func<ValidationResult>> ValidationFunctions { get; }

        public TriangleValidator(Triangle validatingShape)
        {
            ValidatingShape = validatingShape;

            ValidationFunctions = [
                () => ValidateTriangleInequality(validatingShape.Sides)
               ,() => ValidateArguments(validatingShape.Sides)
            ];
        }
    }
}
