//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf4Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesMessageParamContentOneOf1ItemsOneOf4Type
    {
        /// <summary>
        /// 
        /// </summary>
        ToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentOneOf1ItemsOneOf4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf4Type value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf4Type.ToolResult => "tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf4Type? ToEnum(string value)
        {
            return value switch
            {
                "tool_result" => MessagesMessageParamContentOneOf1ItemsOneOf4Type.ToolResult,
                _ => null,
            };
        }
    }
}