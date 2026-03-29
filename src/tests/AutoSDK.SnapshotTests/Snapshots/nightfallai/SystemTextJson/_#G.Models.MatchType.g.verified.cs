//HintName: G.Models.MatchType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MatchType
    {
        /// <summary>
        /// 
        /// </summary>
        Full,
        /// <summary>
        /// 
        /// </summary>
        Partial,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MatchTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MatchType value)
        {
            return value switch
            {
                MatchType.Full => "FULL",
                MatchType.Partial => "PARTIAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MatchType? ToEnum(string value)
        {
            return value switch
            {
                "FULL" => MatchType.Full,
                "PARTIAL" => MatchType.Partial,
                _ => null,
            };
        }
    }
}