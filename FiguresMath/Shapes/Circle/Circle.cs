using FiguresMath.Shapes.Base;
using FiguresMath.Validation.Utils;
using FiguresMath.Validation.Validators;
using FiguresMath.Validation.Validators.Base;

using static FiguresMath.Helpers.CircleHelper;

namespace FiguresMath.Shapes.Circle
{
    public record Circle : Shape
    {
        public double Radius { get; init; }

        public override double Area => GetArea(Radius);

        public override ValidatorBase Validator { get; set; }

        public Circle(double radius)
        {
            Radius = radius;

            Validator = new CircleValidator(this);

            ValidationResult validationResult = Validator.Validate();

            if (validationResult.ResultCode == ValidationResult.Code.Error)
                throw new ArgumentException(validationResult.Message);
        }
    }
}
