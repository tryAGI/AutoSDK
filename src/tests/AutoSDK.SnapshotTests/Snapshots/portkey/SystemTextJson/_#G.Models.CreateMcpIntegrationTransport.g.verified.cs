//HintName: G.Models.CreateMcpIntegrationTransport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateMcpIntegrationTransport
    {
        /// <summary>
        /// 
        /// </summary>
        Http,
        /// <summary>
        /// 
        /// </summary>
        Sse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateMcpIntegrationTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMcpIntegrationTransport value)
        {
            return value switch
            {
                CreateMcpIntegrationTransport.Http => "http",
                CreateMcpIntegrationTransport.Sse => "sse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMcpIntegrationTransport? ToEnum(string value)
        {
            return value switch
            {
                "http" => CreateMcpIntegrationTransport.Http,
                "sse" => CreateMcpIntegrationTransport.Sse,
                _ => null,
            };
        }
    }
}