//HintName: G.Models.ClientMessageTransferUpdateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "transfer-update" is sent whenever a transfer happens.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClientMessageTransferUpdateType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transfer-update")]
        TransferUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientMessageTransferUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageTransferUpdateType value)
        {
            return value switch
            {
                ClientMessageTransferUpdateType.TransferUpdate => "transfer-update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageTransferUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "transfer-update" => ClientMessageTransferUpdateType.TransferUpdate,
                _ => null,
            };
        }
    }
}