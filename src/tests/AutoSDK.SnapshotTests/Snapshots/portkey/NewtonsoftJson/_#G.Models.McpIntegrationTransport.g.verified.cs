//HintName: G.Models.McpIntegrationTransport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum McpIntegrationTransport
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="http")]
        Http,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="interactive")]
        Interactive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sse")]
        Sse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpIntegrationTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpIntegrationTransport value)
        {
            return value switch
            {
                McpIntegrationTransport.Http => "http",
                McpIntegrationTransport.Interactive => "interactive",
                McpIntegrationTransport.Sse => "sse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpIntegrationTransport? ToEnum(string value)
        {
            return value switch
            {
                "http" => McpIntegrationTransport.Http,
                "interactive" => McpIntegrationTransport.Interactive,
                "sse" => McpIntegrationTransport.Sse,
                _ => null,
            };
        }
    }
}