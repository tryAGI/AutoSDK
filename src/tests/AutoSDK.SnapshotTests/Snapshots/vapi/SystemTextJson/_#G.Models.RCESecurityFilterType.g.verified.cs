//HintName: G.Models.RCESecurityFilterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of security threat to filter.
    /// </summary>
    public enum RCESecurityFilterType
    {
        /// <summary>
        /// 
        /// </summary>
        Rce,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RCESecurityFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RCESecurityFilterType value)
        {
            return value switch
            {
                RCESecurityFilterType.Rce => "rce",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RCESecurityFilterType? ToEnum(string value)
        {
            return value switch
            {
                "rce" => RCESecurityFilterType.Rce,
                _ => null,
            };
        }
    }
}