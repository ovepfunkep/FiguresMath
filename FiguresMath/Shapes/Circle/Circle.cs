using FiguresMath.Shapes.Base;
using FiguresMath.Validation.Utils;
using FiguresMath.Validation.Validators;

using static FiguresMath.Helpers.CircleHelper;

namespace FiguresMath.Shapes.Circle
{
    public record Circle : Shape
    {
        public double Radius { get; init; }

        public override double Area => GetArea(Radius);

        public override Func<ValidationResult> Validate => () => CircleValidator.Validate(this);

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
