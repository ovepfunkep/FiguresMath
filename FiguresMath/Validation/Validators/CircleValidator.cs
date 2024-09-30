using FiguresMath.Shapes.Circle;
using FiguresMath.Validation.Utils;
using FiguresMath.Validation.Validators.Base;

namespace FiguresMath.Validation.Validators
{
    internal class CircleValidator : ValidatorBase<Circle>
    {
        public new static IEnumerable<Func<Circle, ValidationResult>> ValidationFunctions = ValidatorBase<Circle>.ValidationFunctions.Concat([
            (circle) => ValidateArguments(circle.Radius)
            ]);
    }
}
