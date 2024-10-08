using FiguresMath.Shapes.Base;
using FiguresMath.Validation.Utils;

using static FiguresMath.Validation.Utils.ValidationResult;

namespace FiguresMath.Validation.Validators.Base
{
    public abstract class ValidatorBase
    {
        public abstract Shape ValidatingShape { get; set; }
        public abstract IEnumerable<Func<ValidationResult>> ValidationFunctions { get; }

        public ValidationResult Validate()
        {
            IEnumerable<ValidationResult> failedValidationsResults = ValidationFunctions.Select(f => f())
                                                                                        .Where(vr => vr.ResultCode == Code.Error);

            return failedValidationsResults.Any() ? new ValidationResult(Code.Error, string.Join('\n', failedValidationsResults.Select(vr => vr.Message))) :
                                                    new ValidationResult(Code.Ok);
        }

        public static ValidationResult ValidateArguments(params double[] args) =>
            Validate(args.Any(a => a <= 0), "Each argument must be greater than 0");

        protected static ValidationResult Validate(bool isError, string errorMessage) =>
            isError ? new ValidationResult(Code.Error, errorMessage) :
                      new ValidationResult(Code.Ok);
    }
}