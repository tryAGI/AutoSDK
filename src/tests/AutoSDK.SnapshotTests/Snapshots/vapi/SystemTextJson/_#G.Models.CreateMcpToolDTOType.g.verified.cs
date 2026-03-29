//HintName: G.Models.CreateMcpToolDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "mcp" for MCP tool.
    /// </summary>
    public enum CreateMcpToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateMcpToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMcpToolDTOType value)
        {
            return value switch
            {
                CreateMcpToolDTOType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMcpToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "mcp" => CreateMcpToolDTOType.Mcp,
                _ => null,
            };
        }
    }
}