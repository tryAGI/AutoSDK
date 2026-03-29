//HintName: G.Models.BaseMessagesResultContentItemsOneOf5ContentOneOf1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultContentItemsOneOf5ContentOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf5ContentOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf5ContentOneOf1Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf5ContentOneOf1Type.WebSearchToolResultError => "web_search_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf5ContentOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "web_search_tool_result_error" => BaseMessagesResultContentItemsOneOf5ContentOneOf1Type.WebSearchToolResultError,
                _ => null,
            };
        }
    }
}