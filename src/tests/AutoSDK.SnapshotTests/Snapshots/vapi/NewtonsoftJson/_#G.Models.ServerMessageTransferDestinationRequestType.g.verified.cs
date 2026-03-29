//HintName: G.Models.ServerMessageTransferDestinationRequestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "transfer-destination-request" is sent when the model is requesting transfer but destination is unknown.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerMessageTransferDestinationRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transfer-destination-request")]
        TransferDestinationRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageTransferDestinationRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageTransferDestinationRequestType value)
        {
            return value switch
            {
                ServerMessageTransferDestinationRequestType.TransferDestinationRequest => "transfer-destination-request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageTransferDestinationRequestType? ToEnum(string value)
        {
            return value switch
            {
                "transfer-destination-request" => ServerMessageTransferDestinationRequestType.TransferDestinationRequest,
                _ => null,
            };
        }
    }
}