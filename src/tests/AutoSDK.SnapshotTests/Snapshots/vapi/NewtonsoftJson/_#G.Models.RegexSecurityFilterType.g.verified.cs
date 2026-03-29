//HintName: G.Models.RegexSecurityFilterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of security threat to filter.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RegexSecurityFilterType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="regex")]
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegexSecurityFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegexSecurityFilterType value)
        {
            return value switch
            {
                RegexSecurityFilterType.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegexSecurityFilterType? ToEnum(string value)
        {
            return value switch
            {
                "regex" => RegexSecurityFilterType.Regex,
                _ => null,
            };
        }
    }
}