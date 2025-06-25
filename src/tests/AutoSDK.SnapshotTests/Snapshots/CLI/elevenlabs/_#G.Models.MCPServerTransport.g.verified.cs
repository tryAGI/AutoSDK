//HintName: G.Models.MCPServerTransport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Supported MCP server transport types.
    /// </summary>
    public enum MCPServerTransport
    {
        /// <summary>
        /// 
        /// </summary>
        SSE,
        /// <summary>
        /// 
        /// </summary>
        STREAMABLEHTTP,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPServerTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPServerTransport value)
        {
            return value switch
            {
                MCPServerTransport.SSE => "SSE",
                MCPServerTransport.STREAMABLEHTTP => "STREAMABLE_HTTP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPServerTransport? ToEnum(string value)
        {
            return value switch
            {
                "SSE" => MCPServerTransport.SSE,
                "STREAMABLE_HTTP" => MCPServerTransport.STREAMABLEHTTP,
                _ => null,
            };
        }
    }
}