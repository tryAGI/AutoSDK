//HintName: G.Models.ChatWebSearchShorthandEngine.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API.
    /// </summary>
    public enum ChatWebSearchShorthandEngine
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
    public static class ChatWebSearchShorthandEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatWebSearchShorthandEngine value)
        {
            return value switch
            {
                ChatWebSearchShorthandEngine.Auto => "auto",
                ChatWebSearchShorthandEngine.Exa => "exa",
                ChatWebSearchShorthandEngine.Firecrawl => "firecrawl",
                ChatWebSearchShorthandEngine.Native => "native",
                ChatWebSearchShorthandEngine.Parallel => "parallel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatWebSearchShorthandEngine? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatWebSearchShorthandEngine.Auto,
                "exa" => ChatWebSearchShorthandEngine.Exa,
                "firecrawl" => ChatWebSearchShorthandEngine.Firecrawl,
                "native" => ChatWebSearchShorthandEngine.Native,
                "parallel" => ChatWebSearchShorthandEngine.Parallel,
                _ => null,
            };
        }
    }
}