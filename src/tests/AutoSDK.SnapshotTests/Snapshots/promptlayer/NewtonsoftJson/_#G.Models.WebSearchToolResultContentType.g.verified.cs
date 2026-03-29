//HintName: G.Models.WebSearchToolResultContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: web_search_tool_result
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebSearchToolResultContentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="web_search_tool_result")]
        WebSearchToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchToolResultContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchToolResultContentType value)
        {
            return value switch
            {
                WebSearchToolResultContentType.WebSearchToolResult => "web_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchToolResultContentType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_tool_result" => WebSearchToolResultContentType.WebSearchToolResult,
                _ => null,
            };
        }
    }
}