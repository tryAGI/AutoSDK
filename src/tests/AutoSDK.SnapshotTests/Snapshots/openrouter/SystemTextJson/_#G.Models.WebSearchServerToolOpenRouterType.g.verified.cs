//HintName: G.Models.WebSearchServerToolOpenRouterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebSearchServerToolOpenRouterType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_webSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchServerToolOpenRouterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchServerToolOpenRouterType value)
        {
            return value switch
            {
                WebSearchServerToolOpenRouterType.Openrouter_webSearch => "openrouter:web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchServerToolOpenRouterType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:web_search" => WebSearchServerToolOpenRouterType.Openrouter_webSearch,
                _ => null,
            };
        }
    }
}