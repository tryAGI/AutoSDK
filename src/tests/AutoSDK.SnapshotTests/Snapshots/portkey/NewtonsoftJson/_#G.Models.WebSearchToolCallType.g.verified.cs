//HintName: G.Models.WebSearchToolCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the web search tool call. Always `web_search_call`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebSearchToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="web_search_call")]
        WebSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchToolCallType value)
        {
            return value switch
            {
                WebSearchToolCallType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_call" => WebSearchToolCallType.WebSearchCall,
                _ => null,
            };
        }
    }
}