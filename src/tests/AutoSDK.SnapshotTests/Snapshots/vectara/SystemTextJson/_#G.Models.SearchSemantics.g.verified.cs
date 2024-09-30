//HintName: G.Models.SearchSemantics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates whether to consider a query against this corpus as a query or a response.<br/>
    /// Default Value: default
    /// </summary>
    public enum SearchSemantics
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Query,
        /// <summary>
        /// 
        /// </summary>
        Response,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchSemanticsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchSemantics value)
        {
            return value switch
            {
                SearchSemantics.Default => "default",
                SearchSemantics.Query => "query",
                SearchSemantics.Response => "response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchSemantics? ToEnum(string value)
        {
            return value switch
            {
                "default" => SearchSemantics.Default,
                "query" => SearchSemantics.Query,
                "response" => SearchSemantics.Response,
                _ => null,
            };
        }
    }
}