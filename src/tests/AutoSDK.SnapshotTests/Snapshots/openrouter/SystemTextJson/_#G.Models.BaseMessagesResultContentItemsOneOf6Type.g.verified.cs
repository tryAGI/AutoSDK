//HintName: G.Models.BaseMessagesResultContentItemsOneOf6Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultContentItemsOneOf6Type
    {
        /// <summary>
        /// 
        /// </summary>
        WebFetchToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf6Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf6Type.WebFetchToolResult => "web_fetch_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf6Type? ToEnum(string value)
        {
            return value switch
            {
                "web_fetch_tool_result" => BaseMessagesResultContentItemsOneOf6Type.WebFetchToolResult,
                _ => null,
            };
        }
    }
}