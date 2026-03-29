//HintName: G.Models.ValidationSummaryValidatorStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether the validator passed or failed.
    /// </summary>
    public enum ValidationSummaryValidatorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Fail,
        /// <summary>
        /// 
        /// </summary>
        Pass,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ValidationSummaryValidatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ValidationSummaryValidatorStatus value)
        {
            return value switch
            {
                ValidationSummaryValidatorStatus.Fail => "fail",
                ValidationSummaryValidatorStatus.Pass => "pass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ValidationSummaryValidatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "fail" => ValidationSummaryValidatorStatus.Fail,
                "pass" => ValidationSummaryValidatorStatus.Pass,
                _ => null,
            };
        }
    }
}