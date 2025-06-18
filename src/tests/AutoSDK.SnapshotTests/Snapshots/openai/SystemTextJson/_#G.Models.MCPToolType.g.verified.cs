//HintName: G.Models.MCPToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the MCP tool. Always `mcp`.
    /// </summary>
    public enum MCPToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPToolType value)
        {
            return value switch
            {
                MCPToolType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPToolType? ToEnum(string value)
        {
            return value switch
            {
                "mcp" => MCPToolType.Mcp,
                _ => null,
            };
        }
    }
}