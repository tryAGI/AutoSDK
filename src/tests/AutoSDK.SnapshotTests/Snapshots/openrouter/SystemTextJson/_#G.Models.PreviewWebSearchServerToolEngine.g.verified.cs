//HintName: G.Models.PreviewWebSearchServerToolEngine.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API.
    /// </summary>
    public enum PreviewWebSearchServerToolEngine
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
    public static class PreviewWebSearchServerToolEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreviewWebSearchServerToolEngine value)
        {
            return value switch
            {
                PreviewWebSearchServerToolEngine.Auto => "auto",
                PreviewWebSearchServerToolEngine.Exa => "exa",
                PreviewWebSearchServerToolEngine.Firecrawl => "firecrawl",
                PreviewWebSearchServerToolEngine.Native => "native",
                PreviewWebSearchServerToolEngine.Parallel => "parallel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreviewWebSearchServerToolEngine? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PreviewWebSearchServerToolEngine.Auto,
                "exa" => PreviewWebSearchServerToolEngine.Exa,
                "firecrawl" => PreviewWebSearchServerToolEngine.Firecrawl,
                "native" => PreviewWebSearchServerToolEngine.Native,
                "parallel" => PreviewWebSearchServerToolEngine.Parallel,
                _ => null,
            };
        }
    }
}