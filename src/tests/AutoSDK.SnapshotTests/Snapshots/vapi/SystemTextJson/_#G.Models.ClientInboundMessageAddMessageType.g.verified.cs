//HintName: G.Models.ClientInboundMessageAddMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. Send "add-message" message to add a message to the conversation history.
    /// </summary>
    public enum ClientInboundMessageAddMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        AddMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientInboundMessageAddMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientInboundMessageAddMessageType value)
        {
            return value switch
            {
                ClientInboundMessageAddMessageType.AddMessage => "add-message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientInboundMessageAddMessageType? ToEnum(string value)
        {
            return value switch
            {
                "add-message" => ClientInboundMessageAddMessageType.AddMessage,
                _ => null,
            };
        }
    }
}