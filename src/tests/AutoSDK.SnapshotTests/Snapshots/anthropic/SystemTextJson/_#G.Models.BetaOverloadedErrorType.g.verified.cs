//HintName: G.Models.BetaOverloadedErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: overloaded_error
    /// </summary>
    public enum BetaOverloadedErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        OverloadedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaOverloadedErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaOverloadedErrorType value)
        {
            return value switch
            {
                BetaOverloadedErrorType.OverloadedError => "overloaded_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaOverloadedErrorType? ToEnum(string value)
        {
            return value switch
            {
                "overloaded_error" => BetaOverloadedErrorType.OverloadedError,
                _ => null,
            };
        }
    }
}