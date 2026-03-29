//HintName: G.Models.McpToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "mcp" for MCP tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum McpToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mcp")]
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpToolType value)
        {
            return value switch
            {
                McpToolType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpToolType? ToEnum(string value)
        {
            return value switch
            {
                "mcp" => McpToolType.Mcp,
                _ => null,
            };
        }
    }
}