//HintName: G.Models.McpListToolsCompletedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum McpListToolsCompletedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mcp_list_tools.completed")]
        McpListToolsCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpListToolsCompletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpListToolsCompletedEventType value)
        {
            return value switch
            {
                McpListToolsCompletedEventType.McpListToolsCompleted => "mcp_list_tools.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpListToolsCompletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_list_tools.completed" => McpListToolsCompletedEventType.McpListToolsCompleted,
                _ => null,
            };
        }
    }
}