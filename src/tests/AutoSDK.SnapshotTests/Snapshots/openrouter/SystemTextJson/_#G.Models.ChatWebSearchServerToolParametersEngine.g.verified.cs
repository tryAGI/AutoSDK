//HintName: G.Models.ChatWebSearchServerToolParametersEngine.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API.
    /// </summary>
    public enum ChatWebSearchServerToolParametersEngine
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
    public static class ChatWebSearchServerToolParametersEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatWebSearchServerToolParametersEngine value)
        {
            return value switch
            {
                ChatWebSearchServerToolParametersEngine.Auto => "auto",
                ChatWebSearchServerToolParametersEngine.Exa => "exa",
                ChatWebSearchServerToolParametersEngine.Firecrawl => "firecrawl",
                ChatWebSearchServerToolParametersEngine.Native => "native",
                ChatWebSearchServerToolParametersEngine.Parallel => "parallel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatWebSearchServerToolParametersEngine? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatWebSearchServerToolParametersEngine.Auto,
                "exa" => ChatWebSearchServerToolParametersEngine.Exa,
                "firecrawl" => ChatWebSearchServerToolParametersEngine.Firecrawl,
                "native" => ChatWebSearchServerToolParametersEngine.Native,
                "parallel" => ChatWebSearchServerToolParametersEngine.Parallel,
                _ => null,
            };
        }
    }
}