//HintName: G.Models.BaseMessagesResultContentItemsOneOf10Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultContentItemsOneOf10Type
    {
        /// <summary>
        /// 
        /// </summary>
        ToolSearchToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf10TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf10Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf10Type.ToolSearchToolResult => "tool_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf10Type? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_tool_result" => BaseMessagesResultContentItemsOneOf10Type.ToolSearchToolResult,
                _ => null,
            };
        }
    }
}