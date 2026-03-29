//HintName: G.Models.SSRFSecurityFilterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of security threat to filter.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SSRFSecurityFilterType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ssrf")]
        Ssrf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SSRFSecurityFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SSRFSecurityFilterType value)
        {
            return value switch
            {
                SSRFSecurityFilterType.Ssrf => "ssrf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SSRFSecurityFilterType? ToEnum(string value)
        {
            return value switch
            {
                "ssrf" => SSRFSecurityFilterType.Ssrf,
                _ => null,
            };
        }
    }
}