//HintName: G.Models.McpIntegrationListItemTransport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum McpIntegrationListItemTransport
    {
        /// <summary>
        /// 
        /// </summary>
        Http,
        /// <summary>
        /// 
        /// </summary>
        Interactive,
        /// <summary>
        /// 
        /// </summary>
        Sse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpIntegrationListItemTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpIntegrationListItemTransport value)
        {
            return value switch
            {
                McpIntegrationListItemTransport.Http => "http",
                McpIntegrationListItemTransport.Interactive => "interactive",
                McpIntegrationListItemTransport.Sse => "sse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpIntegrationListItemTransport? ToEnum(string value)
        {
            return value switch
            {
                "http" => McpIntegrationListItemTransport.Http,
                "interactive" => McpIntegrationListItemTransport.Interactive,
                "sse" => McpIntegrationListItemTransport.Sse,
                _ => null,
            };
        }
    }
}