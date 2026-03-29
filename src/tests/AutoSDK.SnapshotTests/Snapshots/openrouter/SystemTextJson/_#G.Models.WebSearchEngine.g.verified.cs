//HintName: G.Models.WebSearchEngine.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The search engine to use for web search.
    /// </summary>
    public enum WebSearchEngine
    {
        /// <summary>
        /// 
        /// </summary>
        Exa,
        /// <summary>
        /// 
        /// </summary>
        Firecrawl,
        /// <summary>
        /// 
        /// </summary>
        Native,
        /// <summary>
        /// 
        /// </summary>
        Parallel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchEngine value)
        {
            return value switch
            {
                WebSearchEngine.Exa => "exa",
                WebSearchEngine.Firecrawl => "firecrawl",
                WebSearchEngine.Native => "native",
                WebSearchEngine.Parallel => "parallel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchEngine? ToEnum(string value)
        {
            return value switch
            {
                "exa" => WebSearchEngine.Exa,
                "firecrawl" => WebSearchEngine.Firecrawl,
                "native" => WebSearchEngine.Native,
                "parallel" => WebSearchEngine.Parallel,
                _ => null,
            };
        }
    }
}