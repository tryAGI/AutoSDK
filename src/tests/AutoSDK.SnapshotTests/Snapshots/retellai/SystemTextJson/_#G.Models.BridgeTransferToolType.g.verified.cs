//HintName: G.Models.BridgeTransferToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BridgeTransferToolType
    {
        /// <summary>
        /// 
        /// </summary>
        BridgeTransfer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BridgeTransferToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BridgeTransferToolType value)
        {
            return value switch
            {
                BridgeTransferToolType.BridgeTransfer => "bridge_transfer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BridgeTransferToolType? ToEnum(string value)
        {
            return value switch
            {
                "bridge_transfer" => BridgeTransferToolType.BridgeTransfer,
                _ => null,
            };
        }
    }
}