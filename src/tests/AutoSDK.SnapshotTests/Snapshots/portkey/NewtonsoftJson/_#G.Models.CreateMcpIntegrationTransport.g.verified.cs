//HintName: G.Models.CreateMcpIntegrationTransport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateMcpIntegrationTransport
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="http")]
        Http,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sse")]
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