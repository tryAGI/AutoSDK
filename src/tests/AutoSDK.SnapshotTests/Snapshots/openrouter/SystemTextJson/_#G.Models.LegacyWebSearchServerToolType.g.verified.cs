//HintName: G.Models.LegacyWebSearchServerToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LegacyWebSearchServerToolType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LegacyWebSearchServerToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LegacyWebSearchServerToolType value)
        {
            return value switch
            {
                LegacyWebSearchServerToolType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LegacyWebSearchServerToolType? ToEnum(string value)
        {
            return value switch
            {
                "web_search" => LegacyWebSearchServerToolType.WebSearch,
                _ => null,
            };
        }
    }
}