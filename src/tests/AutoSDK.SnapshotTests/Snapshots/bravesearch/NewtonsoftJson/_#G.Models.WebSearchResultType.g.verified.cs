//HintName: G.Models.WebSearchResultType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the result.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebSearchResultType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="search_result")]
        SearchResult,
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
                WebSearchResultType.SearchResult => "search_result",
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
                "search_result" => WebSearchResultType.SearchResult,
                _ => null,
            };
        }
    }
}