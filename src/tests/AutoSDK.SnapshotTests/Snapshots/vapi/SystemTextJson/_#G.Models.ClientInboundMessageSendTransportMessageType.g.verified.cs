//HintName: G.Models.ClientInboundMessageSendTransportMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. Send "send-transport-message" to send a transport-specific message during the call.
    /// </summary>
    public enum ClientInboundMessageSendTransportMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        SendTransportMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientInboundMessageSendTransportMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientInboundMessageSendTransportMessageType value)
        {
            return value switch
            {
                ClientInboundMessageSendTransportMessageType.SendTransportMessage => "send-transport-message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientInboundMessageSendTransportMessageType? ToEnum(string value)
        {
            return value switch
            {
                "send-transport-message" => ClientInboundMessageSendTransportMessageType.SendTransportMessage,
                _ => null,
            };
        }
    }
}