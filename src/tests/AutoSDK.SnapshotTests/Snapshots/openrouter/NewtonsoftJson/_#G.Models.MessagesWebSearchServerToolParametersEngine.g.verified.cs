//HintName: G.Models.MessagesWebSearchServerToolParametersEngine.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesWebSearchServerToolParametersEngine
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
    public static class MessagesWebSearchServerToolParametersEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesWebSearchServerToolParametersEngine value)
        {
            return value switch
            {
                MessagesWebSearchServerToolParametersEngine.Auto => "auto",
                MessagesWebSearchServerToolParametersEngine.Exa => "exa",
                MessagesWebSearchServerToolParametersEngine.Firecrawl => "firecrawl",
                MessagesWebSearchServerToolParametersEngine.Native => "native",
                MessagesWebSearchServerToolParametersEngine.Parallel => "parallel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesWebSearchServerToolParametersEngine? ToEnum(string value)
        {
            return value switch
            {
                "auto" => MessagesWebSearchServerToolParametersEngine.Auto,
                "exa" => MessagesWebSearchServerToolParametersEngine.Exa,
                "firecrawl" => MessagesWebSearchServerToolParametersEngine.Firecrawl,
                "native" => MessagesWebSearchServerToolParametersEngine.Native,
                "parallel" => MessagesWebSearchServerToolParametersEngine.Parallel,
                _ => null,
            };
        }
    }
}