//HintName: G.Models.ClientInboundMessageEndCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. Send "end-call" message to end the call.
    /// </summary>
    public enum ClientInboundMessageEndCallType
    {
        /// <summary>
        /// 
        /// </summary>
        EndCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientInboundMessageEndCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientInboundMessageEndCallType value)
        {
            return value switch
            {
                ClientInboundMessageEndCallType.EndCall => "end-call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientInboundMessageEndCallType? ToEnum(string value)
        {
            return value switch
            {
                "end-call" => ClientInboundMessageEndCallType.EndCall,
                _ => null,
            };
        }
    }
}