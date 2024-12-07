//HintName: G.Models.RateLimitErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: rate_limit_error
    /// </summary>
    public enum RateLimitErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        RateLimitError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RateLimitErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RateLimitErrorType value)
        {
            return value switch
            {
                RateLimitErrorType.RateLimitError => "rate_limit_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RateLimitErrorType? ToEnum(string value)
        {
            return value switch
            {
                "rate_limit_error" => RateLimitErrorType.RateLimitError,
                _ => null,
            };
        }
    }
}