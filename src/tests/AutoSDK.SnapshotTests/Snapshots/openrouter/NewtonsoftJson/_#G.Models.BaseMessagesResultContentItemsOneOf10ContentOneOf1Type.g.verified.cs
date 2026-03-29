//HintName: G.Models.BaseMessagesResultContentItemsOneOf10ContentOneOf1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultContentItemsOneOf10ContentOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_search_tool_search_result")]
        ToolSearchToolSearchResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf10ContentOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf10ContentOneOf1Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf10ContentOneOf1Type.ToolSearchToolSearchResult => "tool_search_tool_search_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf10ContentOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_tool_search_result" => BaseMessagesResultContentItemsOneOf10ContentOneOf1Type.ToolSearchToolSearchResult,
                _ => null,
            };
        }
    }
}