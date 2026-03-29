//HintName: G.Models.UsageLimitsPolicyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Policy type
    /// </summary>
    public enum UsageLimitsPolicyType
    {
        /// <summary>
        /// 
        /// </summary>
        Cost,
        /// <summary>
        /// 
        /// </summary>
        Tokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageLimitsPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageLimitsPolicyType value)
        {
            return value switch
            {
                UsageLimitsPolicyType.Cost => "cost",
                UsageLimitsPolicyType.Tokens => "tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageLimitsPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "cost" => UsageLimitsPolicyType.Cost,
                "tokens" => UsageLimitsPolicyType.Tokens,
                _ => null,
            };
        }
    }
}