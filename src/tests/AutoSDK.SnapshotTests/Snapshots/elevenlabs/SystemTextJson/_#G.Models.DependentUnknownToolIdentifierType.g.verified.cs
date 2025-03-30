//HintName: G.Models.DependentUnknownToolIdentifierType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: unknown
    /// </summary>
    public enum DependentUnknownToolIdentifierType
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependentUnknownToolIdentifierTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependentUnknownToolIdentifierType value)
        {
            return value switch
            {
                DependentUnknownToolIdentifierType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependentUnknownToolIdentifierType? ToEnum(string value)
        {
            return value switch
            {
                "unknown" => DependentUnknownToolIdentifierType.Unknown,
                _ => null,
            };
        }
    }
}