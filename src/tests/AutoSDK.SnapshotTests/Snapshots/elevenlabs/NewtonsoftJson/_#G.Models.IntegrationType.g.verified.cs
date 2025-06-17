//HintName: G.Models.IntegrationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IntegrationType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mcp_server")]
        McpServer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mcp_integration")]
        McpIntegration,
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
                IntegrationType.McpServer => "mcp_server",
                IntegrationType.McpIntegration => "mcp_integration",
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
                "mcp_server" => IntegrationType.McpServer,
                "mcp_integration" => IntegrationType.McpIntegration,
                _ => null,
            };
        }
    }
}