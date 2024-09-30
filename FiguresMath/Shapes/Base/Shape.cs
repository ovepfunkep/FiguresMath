using FiguresMath.Validation.Utils;

namespace FiguresMath.Shapes.Base
{
    public abstract record Shape
    {
        public abstract double Area { get; }

        public abstract Func<ValidationResult> Validate { get; }

        protected Shape()
        {
            ValidationResult validationResult = Validate();
            if (validationResult.ResultCode == ValidationResult.Code.Error) 
                throw new ArgumentException($"Such shape can not exist because:{validationResult.Message}");
        }
    }
}