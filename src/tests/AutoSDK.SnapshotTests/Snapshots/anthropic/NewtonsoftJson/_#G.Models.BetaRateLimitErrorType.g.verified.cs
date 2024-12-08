//HintName: G.Models.BetaRateLimitErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: rate_limit_error
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaRateLimitErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rate_limit_error")]
        RateLimitError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRateLimitErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRateLimitErrorType value)
        {
            return value switch
            {
                BetaRateLimitErrorType.RateLimitError => "rate_limit_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRateLimitErrorType? ToEnum(string value)
        {
            return value switch
            {
                "rate_limit_error" => BetaRateLimitErrorType.RateLimitError,
                _ => null,
            };
        }
    }
}