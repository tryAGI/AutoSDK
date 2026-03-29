//HintName: G.Models.WebSearchServerToolEngine.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API.
    /// </summary>
    public enum WebSearchServerToolEngine
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
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
    public static class WebSearchServerToolEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchServerToolEngine value)
        {
            return value switch
            {
                WebSearchServerToolEngine.Auto => "auto",
                WebSearchServerToolEngine.Exa => "exa",
                WebSearchServerToolEngine.Firecrawl => "firecrawl",
                WebSearchServerToolEngine.Native => "native",
                WebSearchServerToolEngine.Parallel => "parallel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchServerToolEngine? ToEnum(string value)
        {
            return value switch
            {
                "auto" => WebSearchServerToolEngine.Auto,
                "exa" => WebSearchServerToolEngine.Exa,
                "firecrawl" => WebSearchServerToolEngine.Firecrawl,
                "native" => WebSearchServerToolEngine.Native,
                "parallel" => WebSearchServerToolEngine.Parallel,
                _ => null,
            };
        }
    }
}