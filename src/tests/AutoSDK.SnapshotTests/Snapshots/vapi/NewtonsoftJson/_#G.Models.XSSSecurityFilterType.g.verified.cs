//HintName: G.Models.XSSSecurityFilterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of security threat to filter.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum XSSSecurityFilterType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="xss")]
        Xss,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class XSSSecurityFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this XSSSecurityFilterType value)
        {
            return value switch
            {
                XSSSecurityFilterType.Xss => "xss",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static XSSSecurityFilterType? ToEnum(string value)
        {
            return value switch
            {
                "xss" => XSSSecurityFilterType.Xss,
                _ => null,
            };
        }
    }
}