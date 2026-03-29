//HintName: G.Models.BaseMessagesResultContentItemsOneOf10ContentOneOf0Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultContentItemsOneOf10ContentOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        ToolSearchToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf10ContentOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf10ContentOneOf0Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf10ContentOneOf0Type.ToolSearchToolResultError => "tool_search_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf10ContentOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_tool_result_error" => BaseMessagesResultContentItemsOneOf10ContentOneOf0Type.ToolSearchToolResultError,
                _ => null,
            };
        }
    }
}