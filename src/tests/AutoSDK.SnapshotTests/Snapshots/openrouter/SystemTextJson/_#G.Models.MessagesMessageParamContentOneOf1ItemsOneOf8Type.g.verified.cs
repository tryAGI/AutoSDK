//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf8Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesMessageParamContentOneOf1ItemsOneOf8Type
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentOneOf1ItemsOneOf8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf8Type value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf8Type.WebSearchToolResult => "web_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf8Type? ToEnum(string value)
        {
            return value switch
            {
                "web_search_tool_result" => MessagesMessageParamContentOneOf1ItemsOneOf8Type.WebSearchToolResult,
                _ => null,
            };
        }
    }
}