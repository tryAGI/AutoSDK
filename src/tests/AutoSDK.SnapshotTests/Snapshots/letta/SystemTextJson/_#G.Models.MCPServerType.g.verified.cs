//HintName: G.Models.MCPServerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MCPServerType
    {
        /// <summary>
        /// 
        /// </summary>
        Sse,
        /// <summary>
        /// 
        /// </summary>
        Stdio,
        /// <summary>
        /// 
        /// </summary>
        StreamableHttp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPServerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPServerType value)
        {
            return value switch
            {
                MCPServerType.Sse => "sse",
                MCPServerType.Stdio => "stdio",
                MCPServerType.StreamableHttp => "streamable_http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPServerType? ToEnum(string value)
        {
            return value switch
            {
                "sse" => MCPServerType.Sse,
                "stdio" => MCPServerType.Stdio,
                "streamable_http" => MCPServerType.StreamableHttp,
                _ => null,
            };
        }
    }
}