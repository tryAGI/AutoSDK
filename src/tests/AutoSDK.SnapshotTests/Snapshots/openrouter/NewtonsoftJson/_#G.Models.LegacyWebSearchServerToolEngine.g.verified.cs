//HintName: G.Models.LegacyWebSearchServerToolEngine.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LegacyWebSearchServerToolEngine
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="exa")]
        Exa,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="firecrawl")]
        Firecrawl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="native")]
        Native,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parallel")]
        Parallel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LegacyWebSearchServerToolEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LegacyWebSearchServerToolEngine value)
        {
            return value switch
            {
                LegacyWebSearchServerToolEngine.Auto => "auto",
                LegacyWebSearchServerToolEngine.Exa => "exa",
                LegacyWebSearchServerToolEngine.Firecrawl => "firecrawl",
                LegacyWebSearchServerToolEngine.Native => "native",
                LegacyWebSearchServerToolEngine.Parallel => "parallel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LegacyWebSearchServerToolEngine? ToEnum(string value)
        {
            return value switch
            {
                "auto" => LegacyWebSearchServerToolEngine.Auto,
                "exa" => LegacyWebSearchServerToolEngine.Exa,
                "firecrawl" => LegacyWebSearchServerToolEngine.Firecrawl,
                "native" => LegacyWebSearchServerToolEngine.Native,
                "parallel" => LegacyWebSearchServerToolEngine.Parallel,
                _ => null,
            };
        }
    }
}