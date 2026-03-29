//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1Type value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1Type.WebSearchToolResultError => "web_search_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "web_search_tool_result_error" => MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1Type.WebSearchToolResultError,
                _ => null,
            };
        }
    }
}