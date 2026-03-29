//HintName: G.Models.WebSearchResultType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: web_search_result
    /// </summary>
    public enum WebSearchResultType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchResultType value)
        {
            return value switch
            {
                WebSearchResultType.WebSearchResult => "web_search_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchResultType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_result" => WebSearchResultType.WebSearchResult,
                _ => null,
            };
        }
    }
}