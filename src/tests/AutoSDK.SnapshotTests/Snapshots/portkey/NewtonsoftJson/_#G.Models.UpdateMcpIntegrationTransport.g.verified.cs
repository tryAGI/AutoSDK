//HintName: G.Models.UpdateMcpIntegrationTransport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateMcpIntegrationTransport
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
    public static class UpdateMcpIntegrationTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMcpIntegrationTransport value)
        {
            return value switch
            {
                UpdateMcpIntegrationTransport.Http => "http",
                UpdateMcpIntegrationTransport.Sse => "sse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMcpIntegrationTransport? ToEnum(string value)
        {
            return value switch
            {
                "http" => UpdateMcpIntegrationTransport.Http,
                "sse" => UpdateMcpIntegrationTransport.Sse,
                _ => null,
            };
        }
    }
}