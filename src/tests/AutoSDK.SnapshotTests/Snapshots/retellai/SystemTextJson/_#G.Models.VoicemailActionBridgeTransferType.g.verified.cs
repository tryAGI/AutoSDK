//HintName: G.Models.VoicemailActionBridgeTransferType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: bridge_transfer
    /// </summary>
    public enum VoicemailActionBridgeTransferType
    {
        /// <summary>
        /// 
        /// </summary>
        BridgeTransfer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoicemailActionBridgeTransferTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicemailActionBridgeTransferType value)
        {
            return value switch
            {
                VoicemailActionBridgeTransferType.BridgeTransfer => "bridge_transfer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicemailActionBridgeTransferType? ToEnum(string value)
        {
            return value switch
            {
                "bridge_transfer" => VoicemailActionBridgeTransferType.BridgeTransfer,
                _ => null,
            };
        }
    }
}