//HintName: G.Models.ClientInboundMessageTransferType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. Send "transfer" message to transfer the call to a destination.
    /// </summary>
    public enum ClientInboundMessageTransferType
    {
        /// <summary>
        /// 
        /// </summary>
        Transfer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientInboundMessageTransferTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientInboundMessageTransferType value)
        {
            return value switch
            {
                ClientInboundMessageTransferType.Transfer => "transfer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientInboundMessageTransferType? ToEnum(string value)
        {
            return value switch
            {
                "transfer" => ClientInboundMessageTransferType.Transfer,
                _ => null,
            };
        }
    }
}