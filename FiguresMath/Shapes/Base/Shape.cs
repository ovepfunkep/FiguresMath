using FiguresMath.Validation.Validators.Base;

namespace FiguresMath.Shapes.Base
{
    public abstract record Shape
    {
        public abstract double Area { get; }

        public abstract ValidatorBase Validator { get; set; }
    }
}