//HintName: G.Models.WebSearchToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool.
    /// </summary>
    public enum WebSearchToolType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchToolType value)
        {
            return value switch
            {
                WebSearchToolType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchToolType? ToEnum(string value)
        {
            return value switch
            {
                "web_search" => WebSearchToolType.WebSearch,
                _ => null,
            };
        }
    }
}