﻿namespace FiguresMath.Validation.Utils
{
    public record ValidationResult
    {
        public enum Code
        {
            Ok,
            Error
        }

        public Code ResultCode { get; init; }
        public string? Message { get; init; }

        public ValidationResult(Code resultCode, string? message = null)
        {
            ResultCode = resultCode;
            Message = message;
        }
    }
}
