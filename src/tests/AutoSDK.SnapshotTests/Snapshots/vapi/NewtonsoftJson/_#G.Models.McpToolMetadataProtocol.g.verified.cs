//HintName: G.Models.McpToolMetadataProtocol.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the protocol used for MCP communication. Defaults to Streamable HTTP.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum McpToolMetadataProtocol
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shttp")]
        Shttp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sse")]
        Sse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpToolMetadataProtocolExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpToolMetadataProtocol value)
        {
            return value switch
            {
                McpToolMetadataProtocol.Shttp => "shttp",
                McpToolMetadataProtocol.Sse => "sse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpToolMetadataProtocol? ToEnum(string value)
        {
            return value switch
            {
                "shttp" => McpToolMetadataProtocol.Shttp,
                "sse" => McpToolMetadataProtocol.Sse,
                _ => null,
            };
        }
    }
}