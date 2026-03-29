//HintName: G.Models.UsageLimitsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of credit limit
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UsageLimitsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cost")]
        Cost,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tokens")]
        Tokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageLimitsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageLimitsType value)
        {
            return value switch
            {
                UsageLimitsType.Cost => "cost",
                UsageLimitsType.Tokens => "tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageLimitsType? ToEnum(string value)
        {
            return value switch
            {
                "cost" => UsageLimitsType.Cost,
                "tokens" => UsageLimitsType.Tokens,
                _ => null,
            };
        }
    }
}