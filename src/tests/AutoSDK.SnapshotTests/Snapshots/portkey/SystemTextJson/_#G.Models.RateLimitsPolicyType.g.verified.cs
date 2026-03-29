//HintName: G.Models.RateLimitsPolicyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Policy type
    /// </summary>
    public enum RateLimitsPolicyType
    {
        /// <summary>
        /// 
        /// </summary>
        Requests,
        /// <summary>
        /// 
        /// </summary>
        Tokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RateLimitsPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RateLimitsPolicyType value)
        {
            return value switch
            {
                RateLimitsPolicyType.Requests => "requests",
                RateLimitsPolicyType.Tokens => "tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RateLimitsPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "requests" => RateLimitsPolicyType.Requests,
                "tokens" => RateLimitsPolicyType.Tokens,
                _ => null,
            };
        }
    }
}