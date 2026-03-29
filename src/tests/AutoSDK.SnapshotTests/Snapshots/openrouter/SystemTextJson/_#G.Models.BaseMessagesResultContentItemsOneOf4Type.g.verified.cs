//HintName: G.Models.BaseMessagesResultContentItemsOneOf4Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultContentItemsOneOf4Type
    {
        /// <summary>
        /// 
        /// </summary>
        ServerToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf4Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf4Type.ServerToolUse => "server_tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf4Type? ToEnum(string value)
        {
            return value switch
            {
                "server_tool_use" => BaseMessagesResultContentItemsOneOf4Type.ServerToolUse,
                _ => null,
            };
        }
    }
}