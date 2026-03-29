//HintName: G.Models.McpListToolsContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: mcp_list_tools
    /// </summary>
    public enum McpListToolsContentType
    {
        /// <summary>
        /// 
        /// </summary>
        McpListTools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpListToolsContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpListToolsContentType value)
        {
            return value switch
            {
                McpListToolsContentType.McpListTools => "mcp_list_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpListToolsContentType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_list_tools" => McpListToolsContentType.McpListTools,
                _ => null,
            };
        }
    }
}