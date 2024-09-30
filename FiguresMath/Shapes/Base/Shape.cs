using FiguresMath.Validation.Utils;

namespace FiguresMath.Shapes.Base
{
    public abstract record Shape
    {
        public abstract double Area { get; }

        public abstract Func<ValidationResult> IsValid { get; }

        protected Shape()
        {
            ValidationResult validationResult = IsValid();
            if (validationResult.ResultCode == ValidationResult.Code.Error) 
                throw new ArgumentException($"Such shape can not exist because:{validationResult.Message}");
        }
    }
}