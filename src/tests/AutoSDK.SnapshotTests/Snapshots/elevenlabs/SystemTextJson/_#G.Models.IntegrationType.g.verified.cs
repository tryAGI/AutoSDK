//HintName: G.Models.IntegrationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum IntegrationType
    {
        /// <summary>
        /// 
        /// </summary>
        McpIntegration,
        /// <summary>
        /// 
        /// </summary>
        McpServer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IntegrationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntegrationType value)
        {
            return value switch
            {
                IntegrationType.McpIntegration => "mcp_integration",
                IntegrationType.McpServer => "mcp_server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntegrationType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_integration" => IntegrationType.McpIntegration,
                "mcp_server" => IntegrationType.McpServer,
                _ => null,
            };
        }
    }
}