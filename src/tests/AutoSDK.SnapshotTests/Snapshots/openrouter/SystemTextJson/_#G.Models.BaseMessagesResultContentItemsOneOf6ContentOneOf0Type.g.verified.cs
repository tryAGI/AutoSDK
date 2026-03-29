//HintName: G.Models.BaseMessagesResultContentItemsOneOf6ContentOneOf0Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultContentItemsOneOf6ContentOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        WebFetchToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf6ContentOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf6ContentOneOf0Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf6ContentOneOf0Type.WebFetchToolResultError => "web_fetch_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf6ContentOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "web_fetch_tool_result_error" => BaseMessagesResultContentItemsOneOf6ContentOneOf0Type.WebFetchToolResultError,
                _ => null,
            };
        }
    }
}