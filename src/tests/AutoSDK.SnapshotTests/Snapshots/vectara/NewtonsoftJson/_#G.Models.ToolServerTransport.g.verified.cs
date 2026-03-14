//HintName: G.Models.ToolServerTransport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Transport protocol for MCP server connections. Both use Server-Sent Events (SSE).<br/>
    /// - `sse`: Legacy format (https://modelcontextprotocol.io/specification/2024-11-05/basic/transports)<br/>
    /// - `streamable-http`: New format (https://modelcontextprotocol.io/specification/2025-03-26/basic/transports)<br/>
    /// Example: sse
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolServerTransport
    {
        /// <summary>
        /// Legacy format (https://modelcontextprotocol.io/specification/2024-11-05/basic/transports)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sse")]
        Sse,
        /// <summary>
        /// New format (https://modelcontextprotocol.io/specification/2025-03-26/basic/transports)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="streamable-http")]
        StreamableHttp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolServerTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolServerTransport value)
        {
            return value switch
            {
                ToolServerTransport.Sse => "sse",
                ToolServerTransport.StreamableHttp => "streamable-http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolServerTransport? ToEnum(string value)
        {
            return value switch
            {
                "sse" => ToolServerTransport.Sse,
                "streamable-http" => ToolServerTransport.StreamableHttp,
                _ => null,
            };
        }
    }
}