//HintName: G.Models.MCPToolCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the item. Always `mcp_call`.
    /// </summary>
    public enum MCPToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        McpCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPToolCallType value)
        {
            return value switch
            {
                MCPToolCallType.McpCall => "mcp_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_call" => MCPToolCallType.McpCall,
                _ => null,
            };
        }
    }
}