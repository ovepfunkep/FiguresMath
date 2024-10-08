using FiguresMath.Shapes.Base;
using FiguresMath.Shapes.Circle;
using FiguresMath.Validation.Utils;
using FiguresMath.Validation.Validators.Base;

namespace FiguresMath.Validation.Validators
{
    public class CircleValidator : ValidatorBase
    {
        public override Shape ValidatingShape { get; set; }

        public override IEnumerable<Func<ValidationResult>> ValidationFunctions { get; }

        public CircleValidator(Circle validatingShape)
        {
            ValidatingShape = validatingShape;

            ValidationFunctions = [
                () => ValidateArguments(validatingShape.Radius)
            ];
        }
    }
}
