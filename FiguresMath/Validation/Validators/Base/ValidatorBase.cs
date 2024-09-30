using FiguresMath.Shapes.Base;
using FiguresMath.Validation.Utils;
using static FiguresMath.Validation.Utils.ValidationResult;

namespace FiguresMath.Validation.Validators.Base
{
    public abstract class ValidatorBase<T> where T : Shape
    {
        // Count this as "abstract static"
        public static IEnumerable<Func<T, ValidationResult>> ValidationFunctions { get; }

        public static ValidationResult Validate(T shape)
        {
            IEnumerable<ValidationResult> failedValidationsResults = ValidationFunctions.Select(f => f(shape))
                                                                                        .Where(vr => vr.ResultCode == Code.Error);

            return failedValidationsResults.Any() ? new(Code.Error, string.Join('\n', failedValidationsResults.Select(vr => vr.Message))) :
                                                    new(Code.Ok);
        }

        protected static ValidationResult ValidateArguments(params double[] args) => Validate(args.Any(a => a <= 0), "Each argument must be grater than 0");

        protected static ValidationResult Validate(bool isError, string errorMessage) =>
            isError ? new(Code.Error, errorMessage) :
                      new(Code.Ok);
    }
}
