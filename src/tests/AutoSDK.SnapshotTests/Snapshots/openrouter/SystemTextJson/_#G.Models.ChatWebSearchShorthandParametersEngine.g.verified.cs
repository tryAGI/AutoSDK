//HintName: G.Models.ChatWebSearchShorthandParametersEngine.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API.
    /// </summary>
    public enum ChatWebSearchShorthandParametersEngine
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
    public static class ChatWebSearchShorthandParametersEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatWebSearchShorthandParametersEngine value)
        {
            return value switch
            {
                ChatWebSearchShorthandParametersEngine.Auto => "auto",
                ChatWebSearchShorthandParametersEngine.Exa => "exa",
                ChatWebSearchShorthandParametersEngine.Firecrawl => "firecrawl",
                ChatWebSearchShorthandParametersEngine.Native => "native",
                ChatWebSearchShorthandParametersEngine.Parallel => "parallel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatWebSearchShorthandParametersEngine? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatWebSearchShorthandParametersEngine.Auto,
                "exa" => ChatWebSearchShorthandParametersEngine.Exa,
                "firecrawl" => ChatWebSearchShorthandParametersEngine.Firecrawl,
                "native" => ChatWebSearchShorthandParametersEngine.Native,
                "parallel" => ChatWebSearchShorthandParametersEngine.Parallel,
                _ => null,
            };
        }
    }
}