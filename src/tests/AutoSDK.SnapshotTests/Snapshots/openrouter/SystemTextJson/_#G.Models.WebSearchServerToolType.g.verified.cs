//HintName: G.Models.WebSearchServerToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebSearchServerToolType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearch20250826,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchServerToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchServerToolType value)
        {
            return value switch
            {
                WebSearchServerToolType.WebSearch20250826 => "web_search_2025_08_26",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchServerToolType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_2025_08_26" => WebSearchServerToolType.WebSearch20250826,
                _ => null,
            };
        }
    }
}