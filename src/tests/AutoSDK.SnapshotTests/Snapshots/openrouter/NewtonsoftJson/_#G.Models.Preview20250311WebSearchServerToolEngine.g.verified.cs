//HintName: G.Models.Preview20250311WebSearchServerToolEngine.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Preview20250311WebSearchServerToolEngine
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
    public static class Preview20250311WebSearchServerToolEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Preview20250311WebSearchServerToolEngine value)
        {
            return value switch
            {
                Preview20250311WebSearchServerToolEngine.Auto => "auto",
                Preview20250311WebSearchServerToolEngine.Exa => "exa",
                Preview20250311WebSearchServerToolEngine.Firecrawl => "firecrawl",
                Preview20250311WebSearchServerToolEngine.Native => "native",
                Preview20250311WebSearchServerToolEngine.Parallel => "parallel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Preview20250311WebSearchServerToolEngine? ToEnum(string value)
        {
            return value switch
            {
                "auto" => Preview20250311WebSearchServerToolEngine.Auto,
                "exa" => Preview20250311WebSearchServerToolEngine.Exa,
                "firecrawl" => Preview20250311WebSearchServerToolEngine.Firecrawl,
                "native" => Preview20250311WebSearchServerToolEngine.Native,
                "parallel" => Preview20250311WebSearchServerToolEngine.Parallel,
                _ => null,
            };
        }
    }
}