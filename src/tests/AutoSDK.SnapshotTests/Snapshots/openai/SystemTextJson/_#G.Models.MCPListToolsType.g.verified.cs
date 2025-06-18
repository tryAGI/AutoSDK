//HintName: G.Models.MCPListToolsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the item. Always `mcp_list_tools`.
    /// </summary>
    public enum MCPListToolsType
    {
        /// <summary>
        /// 
        /// </summary>
        McpListTools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPListToolsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPListToolsType value)
        {
            return value switch
            {
                MCPListToolsType.McpListTools => "mcp_list_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPListToolsType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_list_tools" => MCPListToolsType.McpListTools,
                _ => null,
            };
        }
    }
}